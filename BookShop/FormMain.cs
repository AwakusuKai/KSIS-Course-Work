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
            FormAddEdit formAddEdit = new FormAddEdit(ref Books, this);
            formAddEdit.Owner = this;
            formAddEdit.Show();
        }

        public void RedrawList()
        {
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
    }
}
