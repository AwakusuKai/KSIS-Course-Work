using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookShop
{
    public partial class FormAddEdit : Form
    {
        FormMain Main;
        List<Book> Books;
        public FormAddEdit(ref List<Book> books)
        {
            InitializeComponent();
            Main = this.Owner as FormMain;
            Books = books;
        }

        private void buttonAddEdit_Click(object sender, EventArgs e)
        {
            Books.Add(new Book(NameTB.Text, AutorTB.Text, GenteCB.Text, TypeCB.Text, PublishingHouseTB.Text, int.Parse(YearTB.Text), float.Parse(PriceTB.Text), int.Parse(NumberTB.Text)));
            this.Close();
            Main.RedrawList();
        }
    }
}
