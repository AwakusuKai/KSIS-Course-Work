using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using BookShopLibrary;

namespace BookShopServer
{
    public class Server
    {
        //Dictionary<int, List<BookInServer>> BooksDictionary;
        private const string ServerIP = "127.0.0.1";
        private const int ServerPort = 50000;
        private Socket tcpSocket;
        private Thread tcpListenThread;
        MessageSerialier MessageSerializer;
        private List<ConnectedClient> clientsList;

        public Server()
        {
            //BooksDictionary = new Dictionary<int, List<BookInServer>>();
            MessageSerializer = new MessageSerialier();
            clientsList = new List<ConnectedClient>();
            tcpListenThread = new Thread(ListenTCP);
        }

        public void ListenTCP()
        {
            int receivedDataBytesCount;
            byte[] receivedDataBuffer;
            tcpSocket.Listen(10);
            while (true)
            {

                Socket connectedSocket = tcpSocket.Accept();
                receivedDataBuffer = new byte[5000];
                using (MemoryStream memoryStream = new MemoryStream())
                {
                    do
                    {
                        receivedDataBytesCount = connectedSocket.Receive(receivedDataBuffer, receivedDataBuffer.Length, SocketFlags.None);
                        memoryStream.Write(receivedDataBuffer, 0, receivedDataBytesCount);
                    }
                    while (tcpSocket.Available > 0); // проверить
                if (receivedDataBytesCount > 0)
                    HandleConnectionMessage(MessageSerializer.Deserialize(memoryStream.ToArray()), connectedSocket);
                }
            }
        }

        public void HandleReceivedMessage(Message message) //обработчик сообщений
        {
            if (message is SearchRequest)
            {
                SearchResponse searchResponse = GetSearchResponse((SearchRequest)message);
                foreach(ConnectedClient connectedClient in clientsList)
                {
                    if (connectedClient.ClientID == searchResponse.ClientID)
                    {
                        connectedClient.TcpSocket.Send(MessageSerializer.Serialize(searchResponse));
                    }
                }
            }

        }

        public void HandleConnectionMessage(Message message, Socket connectedSocket) //обработчик сообщений
        {
            if (message is ConnectionRequest)
            {
                ConnectionRequest connectionRequest = (ConnectionRequest)message;

                ConnectedClient connectedClient = new ConnectedClient(connectionRequest.ClientID, connectedSocket, connectionRequest.BookInServerList);
                connectedClient.ReceiveMessageEvent += HandleReceivedMessage;
                clientsList.Add(connectedClient);
                connectedClient.StartListenTcp();

                Console.WriteLine("[" + DateTime.Now.ToString() + "]: Пользователь с торговым местом " + connectionRequest.ClientID.ToString() + " присоединился.");
            }

        }

    public void Start()
        {
            if (SetupTcpLocalIp())
            {
                Console.WriteLine("Server is ready!");
                tcpListenThread.Start();
            }
        }

        private bool SetupTcpLocalIp()
        {

            tcpSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint localTcpIp = new IPEndPoint(IPAddress.Parse(ServerIP), ServerPort);
            try
            {
                tcpSocket.Bind(localTcpIp);
                return true;
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
                return false;
            }

        }


        public bool CorrectName(BookInServer book, BookInServer searchingBook)
        {
            if (book.Name.ToUpper().Contains(searchingBook.Name.ToUpper()))
            {
                return true;
            }
            return false;
        }

        public bool CorrectAutor(BookInServer book, BookInServer searchingBook)
        {
            if (searchingBook.Autor == "")
            {
                return true;
            }
            if (book.Autor.ToUpper().Contains(searchingBook.Autor.ToUpper()))
            {
                return true;
            }
            return false;
        }

        public bool CorrectPublishingHouse(BookInServer book, BookInServer searchingBook)
        {
            if (searchingBook.PublishingHouse == "")
            {
                return true;
            }
            if (book.PublishingHouse.ToUpper().Contains(searchingBook.PublishingHouse.ToUpper()))
            {
                return true;
            }
            return false;
        }

        public bool CorrectType(BookInServer book, BookInServer searchingBook)
        {
            if (searchingBook.Type == "")
            {
                return true;
            }
            if (searchingBook.Type == book.Type)
            {
                return true;
            }
            return false;
        }

        public bool CorrectYear(BookInServer book, BookInServer searchingBook)
        {
            if (searchingBook.Year == 0)
            {
                return true;
            }
            if (searchingBook.Type == book.Type)
            {
                return true;
            }
            return false;
        }

        public bool CorrectBook(BookInServer book, BookInServer searchingBook)
        {
            if (CorrectName(book, searchingBook) &&
                CorrectAutor(book, searchingBook) &&
                CorrectPublishingHouse(book, searchingBook) &&
                CorrectType(book, searchingBook) &&
                CorrectYear(book, searchingBook))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public SearchResponse GetSearchResponse(SearchRequest searchRequest)
        {
            List<string> hitList = new List<string>(); 
            BookInServer searchingBook = searchRequest.SearchingBook;

            foreach (ConnectedClient connectedClient in clientsList)
            {
                foreach(BookInServer book in connectedClient.ClientBookList)
                {
                    if (CorrectBook(book, searchingBook))
                    {
                        hitList.Add("Торговое место № " + connectedClient.ClientID.ToString() + " :" + book.Name + " " + book.Autor + " " + book.Genre + " " + book.PublishingHouse + " " + book.Year.ToString() + " год " + book.Price.ToString() + " рублей " + book.Number.ToString() + " экземпляр(а).");
                    }
                }
            }

            SearchResponse searchResponse = new SearchResponse(NetworkInformation.GetCurrrentHostIp().ToString(), ServerPort, searchRequest.ClientID, hitList);
            return searchResponse;
        }
        
    }
}
