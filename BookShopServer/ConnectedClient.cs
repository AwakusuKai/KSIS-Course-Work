using BookShopLibrary;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BookShopServer
{
    public class ConnectedClient
    {
        public int ClientID;
        public Socket TcpSocket;
        private Thread ListenTcpThread;
        public delegate void ReceiveMessageDelegate(Message message);
        public event ReceiveMessageDelegate ReceiveMessageEvent;
        private MessageSerialier MessageSerializer;
        public List<BookInServer> ClientBookList;

        public ConnectedClient(int id, Socket tcpSocket, List<BookInServer> clientBookList)
        {
            MessageSerializer = new MessageSerialier();
            this.ClientID = id;
            this.TcpSocket = tcpSocket;
            ClientBookList = clientBookList;
        }

        public void StartListenTcp()
        {
            ListenTcpThread = new Thread(ListenTcp);
            ListenTcpThread.Start();
        }

        private void ListenTcp()
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
                        ReceiveMessageEvent(MessageSerializer.Deserialize(memoryStream.ToArray()));
                }
            }
        }
    }
}
