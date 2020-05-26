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

        public void RedrawList()
        {
            booksLV.Items.Clear();
            foreach (Book book in Books)
            {
                booksLV.Items.Add(book);
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

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Book book in Books)
            {
                if (book.Name == "1984")
                {
                    MessageBox.Show("Yfqltyj");
                }
            }
        }
    }
}
