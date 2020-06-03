using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookShopLibrary;

namespace BookShop
{
    public class Client
    {
        public int ClientID; //Номер торгового места на ярмарке
        public List<BookInServer> BookInServerList;
        private const string ServerIP = "127.0.0.1";
        private const int ServerPort = 50000;
        MessageSerialier ClientMessageSerializer;
        private Socket TcpSocket;
        private Thread ListenTcpThread;
        MessageSerialier MessageSerialier = new MessageSerialier();

        public void SetBookInServerList(List<Book> books)
        {
            List<BookInServer> bookInServerList = new List<BookInServer>();
            foreach(Book book in books)
            {
                bookInServerList.Add(new BookInServer(book.Name, book.Autor, book.Genre, book.Type, book.PublishingHouse, book.Year, book.Price, book.Number));
            }
            BookInServerList = bookInServerList;
        }

        public void SendMessage(BookShopLibrary.Message message)
        {
            TcpSocket.Send(ClientMessageSerializer.Serialize(message));
        }

        public Client(int clientID, List<Book> books)
        {
            ClientID = clientID;
            TcpSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            ListenTcpThread = new Thread(ListenTcp);
            ClientMessageSerializer = new MessageSerialier();
            SetBookInServerList(books);
            IPEndPoint serverIPEndPoint = new IPEndPoint(IPAddress.Parse(ServerIP), ServerPort);
            TcpSocket.Connect(serverIPEndPoint);
            ListenTcpThread.Start();

            IPEndPoint clientIp = (IPEndPoint)(TcpSocket.LocalEndPoint);
            ConnectionRequest connectionRequest = new ConnectionRequest(clientIp.Address.ToString(), clientIp.Port, clientID, BookInServerList);
            SendMessage(connectionRequest);
        }

        public void ListenTcp()
        {
            int receivedDataBytesCount;
            byte[] receivedDataBuffer;

            while (true)
            {
                receivedDataBuffer = new byte[1024];
                using (MemoryStream memoryStream = new MemoryStream())
                {
                    do
                    {
                        receivedDataBytesCount = TcpSocket.Receive(receivedDataBuffer, receivedDataBuffer.Length, SocketFlags.None);
                        memoryStream.Write(receivedDataBuffer, 0, receivedDataBytesCount);
                    }
                    while (TcpSocket.Available > 0);
                    if (receivedDataBytesCount > 0)
                        HandleReceivedMessage(ClientMessageSerializer.Deserialize(memoryStream.ToArray()));
                }
            }
        }

        public void HandleReceivedMessage(BookShopLibrary.Message message)
        {
            if (message is SearchResponse)
            {
                string response = "";
                BookShopLibrary.SearchResponse searchResponse = (SearchResponse)message;
                foreach(string hit in searchResponse.HitList)
                {
                    response = hit + Environment.NewLine;
                }
                MessageBox.Show(response);
            }
        }

        public void SendUpdateBookListRequest(List<Book> books)
        {
            IPEndPoint clientIP = (IPEndPoint)(TcpSocket.LocalEndPoint);
            SetBookInServerList(books);
            UpdateBookListRequest updateBookListRequest = new UpdateBookListRequest(clientIP.Address.ToString(), clientIP.Port, ClientID, BookInServerList);
            SendMessage(updateBookListRequest);
        }

        public void SendSearchRequest(BookInServer searchingBook)
        {
            IPEndPoint clientIp = (IPEndPoint)(TcpSocket.LocalEndPoint);
            SearchRequest searchRequest = new SearchRequest(clientIp.Address.ToString(), clientIp.Port, ClientID, searchingBook);
            SendMessage(searchRequest);
        }



    }
}


