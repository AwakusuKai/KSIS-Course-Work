using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShopLibrary
{
    [Serializable]
    public abstract class Message
    {
        public string SenderIP;
        public int SenderPort;
        public int ClientID;

        public Message(string senderIP, int senderPort, int clientID)
        {
            SenderIP = senderIP;
            SenderPort = senderPort;
            ClientID = clientID;
        }
    }
}
