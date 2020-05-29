using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookShop
{
    public partial class FormCart : Form
    {
        FormMain Main;

        public FormCart(Form owner)
        {
            InitializeComponent();
            this.Owner = owner;
            Main = this.Owner as FormMain;
            RedrawCartList();
        }

        public float PriceSum()
        {
            float sum = 0;
            foreach (Book book in Main.BooksInCart)
            {
                sum += book.PriceAll;
            }
            return sum;
        }

        public void RedrawCartList()
        {
            booksInCartLV.Items.Clear();
            foreach (Book book in Main.BooksInCart)
            {
                BookInCart bookInCart = new BookInCart(book.Name, book.Autor, book.Genre, book.Type, book.PublishingHouse, book.Year, book.Price, book.Number, book);
                booksInCartLV.Items.Add(bookInCart);
                labelItogo.Text = PriceSum().ToString();
            }
        }

        private void FormCart_Click(object sender, EventArgs e)
        {
            RedrawCartList();
        }

        private void buttonDeleteFromCart_Click(object sender, EventArgs e)
        {
            if (booksInCartLV.SelectedItems.Count == 0)
            {
                MessageBox.Show("Выберите книгу!");
                return;
            }
            BookInCart deletedBook = (BookInCart)booksInCartLV.SelectedItems[0];
            deletedBook.ParentBook.NumberForSale = 0;
            deletedBook.ParentBook.PriceAll = 0;
            Main.BooksInCart.Remove(deletedBook.ParentBook);
            RedrawCartList();
        }
    }
}
