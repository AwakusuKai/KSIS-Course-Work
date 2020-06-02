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
        int Mode; // 0-Add, 1-Edit
        int EditIndex;

        public FormAddEdit(ref List<Book> books, Form owner, int mode)
        {
            InitializeComponent();
            this.Owner = owner;
            Main = this.Owner as FormMain;
            Books = books;
            Mode = mode;



        }

        public FormAddEdit(ref List<Book> books, Form owner, int mode, int editIndex, Book bookToEdit)
        {
            InitializeComponent();
            this.Owner = owner;
            Main = this.Owner as FormMain;
            Books = books;
            Mode = mode;
            EditIndex = editIndex;
            NameTB.Text = bookToEdit.Name;
            AutorTB.Text = bookToEdit.Autor;
            GenteCB.Text = bookToEdit.Genre;
            TypeCB.Text = bookToEdit.Type;
            PublishingHouseTB.Text = bookToEdit.PublishingHouse;
            YearTB.Text = bookToEdit.Year.ToString();
            PriceTB.Text = bookToEdit.Price.ToString();
            NumberTB.Text = bookToEdit.Number.ToString();
            buttonAddEdit.Text = "Редактировать";

        }

        private void buttonAddEdit_Click(object sender, EventArgs e)
        {
            if (Mode == 0)
            {
                Books.Add(new Book(NameTB.Text, AutorTB.Text, GenteCB.Text, TypeCB.Text, PublishingHouseTB.Text, int.Parse(YearTB.Text), float.Parse(PriceTB.Text), int.Parse(NumberTB.Text)));
                this.Close();
                Main.RedrawList();
            }
            if (Mode == 1)
            {
                Books[EditIndex] = new Book(NameTB.Text, AutorTB.Text, GenteCB.Text, TypeCB.Text, PublishingHouseTB.Text, int.Parse(YearTB.Text), float.Parse(PriceTB.Text), int.Parse(NumberTB.Text));
                this.Close();
                Main.RedrawList();
            }
            
        }
    }
}
