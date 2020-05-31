using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using BookShopLibrary;

namespace BookShopServer
{
    public class Server
    {
        Dictionary<int, List<BookInServer>> BooksDictionary;
        TcpListener ServerTcpListener;
        private const string ServerIP = "127.0.0.1";
        private const int ServerPort = 50000;
        MessageSerialier MessageSerializer;

        public Server()
        {
            BooksDictionary = new Dictionary<int, List<BookInServer>>();
            ServerTcpListener = new TcpListener(IPAddress.Parse(ServerIP), ServerPort);
            MessageSerializer = new MessageSerialier();
            ServerTcpListener.Start();
        }

        Message GetMessage(NetworkStream stream, TcpClient client)
        {
            
            byte[] buffer = new byte[64]; 
            int bytes = 0;
            using (MemoryStream memoryStream = new MemoryStream())
            {
                do
                {
                    bytes = stream.Read(buffer, 0, buffer.Length);
                    memoryStream.Write(buffer, 0, bytes);
                }
                while (stream.DataAvailable);
                return (MessageSerializer.Deserialize(memoryStream.ToArray()));
            }
        }

        public void HandleConnectionRequest(ConnectionRequest connectionRequest)
        {
            BooksDictionary.Add(connectionRequest.ClientID, connectionRequest.BookInServerList);
            Console.WriteLine("Добавлен список книг торгового места № " + connectionRequest.ClientID.ToString());
        }

        public void Start()
        {
            while (true)
            {
                TcpClient client = ServerTcpListener.AcceptTcpClient();

                NetworkStream stream = client.GetStream();
                Message message = GetMessage(stream, client);
                if (message is ConnectionRequest)
                {
                    HandleConnectionRequest((ConnectionRequest)message);
                }

                stream.Close();
                client.Close();
            }
        }
        
    }
}
