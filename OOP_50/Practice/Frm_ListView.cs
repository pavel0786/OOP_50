using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//using ListViewHelperApp;


namespace OOP_50.Practice
{
    public partial class Frm_ListView : Form
    {
        public Frm_ListView()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //new ListViewHelper().AddDataInListView(lViewEmployee, int.Parse(txtID.Text), txtName.Text, double.Parse(txtSalary.Text));
        }
    }
}
