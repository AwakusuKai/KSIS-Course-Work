using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using BookShopLibrary;

namespace BookShop
{
    public class Client
    {
        public int ClientID; //Номер торгового места на ярмарке
        public TcpClient TcpClient;
        public List<BookInServer> BookInServerList;
        private const string ServerIP = "127.0.0.1";
        private const int ServerPort = 50000;
        MessageSerialier ClientMessageSerializer;

        public void SetBookInServerList(List<Book> books)
        {
            List<BookInServer> bookInServerList = new List<BookInServer>();
            foreach(Book book in books)
            {
                bookInServerList.Add(new BookInServer(book.Name, book.Autor, book.Genre, book.Type, book.PublishingHouse, book.Year, book.Price, book.Number));
            }
            BookInServerList = bookInServerList;
        }

        public void SendMessage(Message message)
        {
            NetworkStream networkStream = TcpClient.GetStream();
            byte[] data = ClientMessageSerializer.Serialize(message);
            networkStream.Write(data, 0, data.Length);
        }

        public Client(int clientID, List<Book> books)
        {
            ClientID = clientID;
            TcpClient = new TcpClient();
            ClientMessageSerializer = new MessageSerialier();
            TcpClient.Connect(IPAddress.Parse(ServerIP), ServerPort);
            SetBookInServerList(books);
            ConnectionRequest connectionRequest = new ConnectionRequest(ClientID, BookInServerList);
            SendMessage(connectionRequest);

        }
    }
}
