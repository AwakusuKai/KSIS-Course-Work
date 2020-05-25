using System.Collections.Generic;

namespace BookShop
{
    public interface ISerializer
    {
        void Serialize(List<Book> books, string path);
        List<Book> Deserialize(string path);
    }
}
