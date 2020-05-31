using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BookShopLibrary
{
    [Serializable]
    public class BookInServer
    {
        public string Name;
        public string Autor;
        public string Genre;
        public string Type;
        public string PublishingHouse;
        public int Year;
        public float Price;
        public int Number;

        public BookInServer(string name, string autor, string genre, string type, string publishingHouse, int year, float price, int number)
        {
            Name = name;
            Autor = autor;
            Genre = genre;
            Type = type;
            PublishingHouse = publishingHouse;
            Year = year;
            Price = price;
            Number = number;
        }
    }
}
