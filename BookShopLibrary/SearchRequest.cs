using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShopLibrary
{
    [Serializable]
    public class SearchRequest : Message
    {
        public BookInServer SearchingBook;

        public SearchRequest(string senderIP, int senderPort, int clientID, BookInServer searchingBook) : base(senderIP, senderPort, clientID)
        {
            SearchingBook = searchingBook;
        }
    }
}
