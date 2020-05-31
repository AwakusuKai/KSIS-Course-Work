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
    public partial class FormMain : Form
    {
        BookSerializer Serializer = new BookSerializer();
        public string CurrentFilePath = "";
        public List<Book> Books = new List<Book>();
        public List<Book> BooksInCart = new List<Book>();
        private int SortColumn = -1;
        private int SortMode = 1;
        Client Client;

        public FormMain()
        {
            InitializeComponent();
            Books = new List<Book>();
            BooksInCart = new List<Book>();
        }

        private void toolStripButtonAdd_Click(object sender, EventArgs e)
        {
            FormAddEdit formAddEdit = new FormAddEdit(ref Books, this, 0);
            formAddEdit.Owner = this;
            formAddEdit.Show();
        }

        public bool CorrectName(string bookName)
        {
            if (NameTB.Text == "")
            {
                return true;
            }
            
            if (bookName.Contains(NameTB.Text))
            {
                return true;
            }

            return false;
        }

        public bool CorrectAutor(string bookAutor)
        {
            if (AutorTB.Text == "")
            {
                return true;
            }

            if (bookAutor.Contains(AutorTB.Text))
            {
                return true;
            }

            return false;
        }

        public bool CorrectGenre(string bookGenre)
        {
            if (GenreCB.Text == "")
            {
                return true;
            }

            if (bookGenre.Contains(GenreCB.Text))
            {
                return true;
            }

            return false;
        }

        public bool CorrectType(string bookType)
        {
            if (TypeCB.Text == "")
            {
                return true;
            }

            if (bookType.Contains(TypeCB.Text))
            {
                return true;
            }

            return false;
        }

        public bool CorrectMinPrice(float bookPrice)
        {
            if (PriceFromTB.Text == "")
            {
                return true;
            }

            try
            {
                float minPrice = float.Parse(PriceFromTB.Text);
                if (bookPrice >= minPrice)
                {
                    return true;
                }

                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool CorrectMaxPrice(float bookPrice)
        {
            if (PriceToTB.Text == "")
            {
                return true;
            }

            try
            {
                float maxPrice = float.Parse(PriceToTB.Text);
                if (bookPrice <= maxPrice)
                {
                    return true;
                }

                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool CorrectBook(Book book)
        {
            if (CorrectName(book.Name) &&
                CorrectAutor(book.Autor) &&
                CorrectGenre(book.Genre) &&
                CorrectType(book.Type) &&
                CorrectMinPrice(book.Price) &&
                CorrectMaxPrice(book.Price))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void RedrawList()
        {
            booksLV.Items.Clear();
            foreach (Book book in Books)
            {
                if (CorrectBook(book))
                {
                    booksLV.Items.Add(book);
                } 
            }
        }

        private void toolStripButtonOpen_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            List<Book> buffer = Serializer.Deserialize(openFileDialog.FileName);
            if (buffer != null)
            {
                Books = buffer;
                CurrentFilePath = openFileDialog.FileName;
            }
            else
                CurrentFilePath = "";
            RedrawList();
        }

        private void toolStripButtonSave_Click(object sender, EventArgs e)
        {
            Serializer.Serialize(Books, CurrentFilePath);
        }

        private void toolStripButtonSaveAs_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            Serializer.Serialize(Books, saveFileDialog.FileName);
        }

        private void toolStripDelete_Click(object sender, EventArgs e)
        {
            if (booksLV.SelectedItems.Count == 0)
            {
                MessageBox.Show("Выберите книгу!");
                return;
            }
            Books.Remove((Book)booksLV.SelectedItems[0]);
            RedrawList();
        }

        private void toolStripEdit_Click(object sender, EventArgs e)
        {
            int i = -1;
            foreach (Book book in Books)
            {
                i++;
                if (book == (Book)booksLV.SelectedItems[0])
                {
                    break;
                }
            }
            Book bookToEdit = Books[i];
            FormAddEdit formAddEdit = new FormAddEdit(ref Books, this, 1, i, bookToEdit);
            formAddEdit.Owner = this;
            formAddEdit.Show();
        }

        private void NameTB_TextChanged(object sender, EventArgs e)
        {
            RedrawList();
        }

        private void AutorTB_TextChanged(object sender, EventArgs e)
        {
            RedrawList();
        }

        private void GenreCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            RedrawList();
        }

        private void TypeCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            RedrawList();
        }

        private void PriceFromTB_TextChanged(object sender, EventArgs e)
        {
            RedrawList();
        }

        private void PriceToTB_TextChanged(object sender, EventArgs e)
        {
            RedrawList();
        }

        private void GenreCB_TextUpdate(object sender, EventArgs e)
        {
            RedrawList();
        }

        private void TypeCB_TextUpdate(object sender, EventArgs e)
        {
            RedrawList();
        }

        private void booksLV_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            
            if (e.Column != SortColumn)
            {
                SortColumn = e.Column;
                SortMode = 1;
            }
            else
            {  
                SortMode = SortMode * -1;
            }

            this.booksLV.ListViewItemSorter = new ListViewItemComparer(e.Column, SortMode);
            booksLV.Sort();
        }

        private void toolStripButtonAddToCart_Click(object sender, EventArgs e)
        {
            if (booksLV.SelectedItems.Count == 0)
            {
                MessageBox.Show("Выберите книгу!");
                return;
            }

            int i = -1;
            foreach (Book book in Books)
            {
                i++;
                if (book == (Book)booksLV.SelectedItems[0])
                {
                    break;
                }
            }
            Book bookToAddInCart = Books[i];

            foreach (Book book in BooksInCart)
            {
                if(book == (Book)booksLV.SelectedItems[0])
                {
                    MessageBox.Show("Это уже есть в вашей корзине!");
                    return;
                }
            }

            int number = bookToAddInCart.Number;
            FormHowMany formHowMany = new FormHowMany(number, this, ref bookToAddInCart);
            formHowMany.Owner = this;
            formHowMany.Show();
        }

        private void toolStripButtonOpenCart_Click(object sender, EventArgs e)
        {
            FormCart formCart = new FormCart(this);
            formCart.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Client = new Client(int.Parse(IDTB.Text), Books);
        }
    }
}
