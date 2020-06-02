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
    public partial class FormHowMany : Form
    {
        Book BookToAddInCart;
        FormMain Main;
        public FormHowMany(int maxCount, Form owner, ref Book bookToAddInCart)
        {
            InitializeComponent();
            trackBarNumber.Maximum = maxCount;
            this.Owner = owner;
            Main = this.Owner as FormMain;
            labelCount.Text = trackBarNumber.Minimum.ToString();
            BookToAddInCart = bookToAddInCart;
        }

        private void trackBarNumber_ValueChanged(object sender, EventArgs e)
        {
            labelCount.Text = trackBarNumber.Value.ToString();
        }

        private void buttonAddToCart_Click(object sender, EventArgs e)
        {
            BookToAddInCart.NumberForSale = trackBarNumber.Value;
            BookToAddInCart.PriceAll = BookToAddInCart.Price * BookToAddInCart.NumberForSale;
            Main.BooksInCart.Add(BookToAddInCart);
            this.Close();
        }
    }
}
