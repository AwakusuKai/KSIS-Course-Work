using BookShopLibrary;
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
    public partial class FormSearch : Form
    {
        FormMain Main;
        public FormSearch(FormMain owner)
        {
            InitializeComponent();
            this.Owner = owner;
            Main = this.Owner as FormMain;
        }

        private void buttonSendSearchRequest_Click(object sender, EventArgs e)
        {
            //сделать норм проверку
            BookInServer searchingBook = new BookInServer(NameTB.Text, "", "", "", "", 0, 0, 0);
            Main.Client.SendSearchRequest(searchingBook);
        }
    }
}
