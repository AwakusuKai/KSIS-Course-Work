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

        protected Book(SerializationInfo info, StreamingContext context) : base(info, context)
        {

            Name = base.Text;
            Autor = base.SubItems[1].Text;
            Genre = base.SubItems[2].Text;
            Type = base.SubItems[3].Text;
            PublishingHouse = base.SubItems[4].Text;
            Year = int.Parse(base.SubItems[5].Text.ToString());
            Price = float.Parse(base.SubItems[6].Text.ToString());
            Number = int.Parse(base.SubItems[7].Text.ToString());

        }
    }
}
