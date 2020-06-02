using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShopLibrary
{
    [Serializable]
    public class SearchResponse : Message
    {
        public List<string> HitList;
        public SearchResponse(string senderIP, int senderPort, int clientID, List<string> hitList) : base(senderIP, senderPort, clientID)
        {
            HitList = hitList;
        }
    }
}
