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

            if(Main.Client == null)
            {
                MessageBox.Show("Для отправки поисковых запросов необходимо подключение к серверу!");
            }

            string name = "";
            if(NameTB.Text != null)
            {
                name = NameTB.Text;
            }

            string autor = "";
            if (AutorTB.Text != null)
            {
                autor = AutorTB.Text;
            }

            string type = "";
            if (TypeCB.Text != null)
            {
                type = TypeCB.Text;
            }

            string publishingHouse = "";
            if (NameTB.Text != null)
            {
                publishingHouse = PublishingHouseTB.Text;
            }

            int year  = 0;
            if (YearTB.Text != "")
            {
                try
                {
                    year = int.Parse(YearTB.Text);
                }
                catch (Exception)
                {
                    year = 0;
                    MessageBox.Show("Некорректные данные");
                    return;
                }
                
            }

            BookInServer searchingBook = new BookInServer(name, autor, "", type, publishingHouse, year, 0, 0);
            Main.Client.SendSearchRequest(searchingBook);
        }
    }
}
