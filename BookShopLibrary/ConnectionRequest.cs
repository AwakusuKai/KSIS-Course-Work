using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShopLibrary
{
    [Serializable]
    public class ConnectionRequest : Message
    {
        public List<BookInServer> BookInServerList;

        public ConnectionRequest(int clientID, List<BookInServer> bookInServerList) : base(clientID)
        {
            BookInServerList = bookInServerList;
        }
    }
}
