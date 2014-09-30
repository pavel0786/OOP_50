using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_50.Practice
{
    public partial class Frm_GenerateSeries : Form
    {
        public Frm_GenerateSeries()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            if(CheckEntry())
            {
                int count = int.Parse(txtItemNumber.Text);
                lbxItems.Items.Clear();
                for (int i = 1; i <= count; i++)
                {
                    lbxItems.Items.Add(i);
                }
            }
        }

        private bool CheckEntry()
        {
            int intValue = 0;
            if (!int.TryParse(txtItemNumber.Text, out intValue))
            {
                MessageBox.Show("Please enter a number correctly");
                return false;
            }
            else
                return true;
        }
    }
}
