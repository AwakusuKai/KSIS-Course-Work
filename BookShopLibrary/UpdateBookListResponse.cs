using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShopLibrary
{
    [Serializable]
    public class UpdateBookListRequest : Message
    {
        public List<BookInServer> NewBookList;
        public UpdateBookListRequest(string senderIP, int senderPort, int clientID, List<BookInServer> newBookList) : base(senderIP, senderPort, clientID)
        {
            NewBookList = newBookList;
        }
    }
}
