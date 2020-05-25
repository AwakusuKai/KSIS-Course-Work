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
        public List<Book> Books = new List<Book>();

        public FormMain()
        {
            InitializeComponent();
            Books = new List<Book>();
        }

        private void toolStripButtonAdd_Click(object sender, EventArgs e)
        {
            FormAddEdit formAddEdit = new FormAddEdit(ref Books);
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
    }
}
