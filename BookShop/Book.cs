using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookShop
{
    [Serializable]
    public class Book : ListViewItem
    {
        public new string Name;
        public string Autor;
        public string Genre;
        public string Type;
        public string PublishingHouse;
        public int Year;
        public float Price;
        public int Number;

        public Book(string name, string autor, string genre, string type, string publishingHouse, int year, float price, int number)
        {
            Name = name;
            Autor = autor;
            Genre = genre;
            Type = type;
            PublishingHouse = publishingHouse;
            Year = year;
            Price = price;
            Number = number;
            base.Text = Name;
            base.SubItems.Add(Autor);
            base.SubItems.Add(Genre);
            base.SubItems.Add(Type);
            base.SubItems.Add(PublishingHouse);
            base.SubItems.Add(Year.ToString());
            base.SubItems.Add(Price.ToString());
            base.SubItems.Add(Number.ToString());
        }

        public override string ToString()
        {
            return Name;
        }

        protected Book(SerializationInfo info, StreamingContext context) : base(info, context) { }


    }
}
