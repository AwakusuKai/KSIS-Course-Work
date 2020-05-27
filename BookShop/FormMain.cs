﻿using System;
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

        public FormMain()
        {
            InitializeComponent();
            Books = new List<Book>();
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
    }
}
