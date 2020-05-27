using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookShop
{
    class ListViewItemComparer : IComparer
    {
        private int SortMode;
        private int Сolumn;
        public ListViewItemComparer()
        {
            Сolumn = 0;
        }
        public ListViewItemComparer(int column, int sortMode)
        {
            Сolumn = column;
            SortMode = sortMode;
        }
        public int Compare(object x, object y)
        {
            int returnVal = -1;
            if (Сolumn == 0 || Сolumn == 1 || Сolumn == 2 || Сolumn == 3 || Сolumn == 4)
            { 
                returnVal = String.Compare(((ListViewItem)x).SubItems[Сolumn].Text, ((ListViewItem)y).SubItems[Сolumn].Text);
            }

            if (Сolumn == 5 || Сolumn == 7)
            {
                if (int.Parse(((ListViewItem)x).SubItems[Сolumn].Text) > int.Parse(((ListViewItem)y).SubItems[Сolumn].Text))
                {
                    returnVal = 1;
                }
            }

            if (Сolumn == 6)
            {
                if (float.Parse(((ListViewItem)x).SubItems[Сolumn].Text) > float.Parse(((ListViewItem)y).SubItems[Сolumn].Text))
                {
                    returnVal = 1;
                }
            }
            returnVal = returnVal * SortMode;
            return returnVal;
        }
    }
}
