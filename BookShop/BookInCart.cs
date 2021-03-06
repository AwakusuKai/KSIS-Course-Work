﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookShop
{
    public class BookInCart : ListViewItem
    {
        public new string Name;
        public string Autor;
        public string Genre;
        public string Type;
        public string PublishingHouse;
        public int Year;
        public float Price;
        public int Number;
        public int NumberForSale;
        public float PriceAll;
        public Book ParentBook;

        public BookInCart(string name, string autor, string genre, string type, string publishingHouse, int year, float price, int number, Book parentBook)
        {
            Name = name;
            Autor = autor;
            Genre = genre;
            Type = type;
            PublishingHouse = publishingHouse;
            Year = year;
            Price = price;
            Number = number;
            ParentBook = parentBook;
            NumberForSale = parentBook.NumberForSale;
            PriceAll = parentBook.PriceAll;

            base.Text = Name;
            base.SubItems.Add(Autor);
            base.SubItems.Add(Genre);
            base.SubItems.Add(Type);
            base.SubItems.Add(PublishingHouse);
            base.SubItems.Add(Year.ToString());
            base.SubItems.Add(Price.ToString());
            base.SubItems.Add(Number.ToString());
            base.SubItems.Add(NumberForSale.ToString());
            base.SubItems.Add(PriceAll.ToString()); 
        }
    }
}
