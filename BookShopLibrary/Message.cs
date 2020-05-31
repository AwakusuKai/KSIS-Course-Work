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
        public int ClientID;

        public Message(int clientID)
        {
            ClientID = clientID;
        }
    }
}
