using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListViewHelperApp
{
    public class ListViewHelper
    {
        public static void AddDataInListView(ListView userListView,int id,string name,double salary)
        {
            ListViewItem theListViewItem = new ListViewItem();
            theListViewItem.SubItems.Add(id.ToString());
            theListViewItem.SubItems.Add(name);
            theListViewItem.SubItems.Add(salary.ToString());
            userListView.Items.Add(theListViewItem);
        }
    }
}
