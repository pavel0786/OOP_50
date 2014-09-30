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
    public partial class Frm_InterestCalculation : Form
    {
        public Frm_InterestCalculation()
        {
            InitializeComponent();
        }

        private void btnCalumateInterest_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckValue())
                {
                    int rate = 0;
                    if (cmbBankName.Text == "BRAC")
                    {
                        rate = 6;
                    }
                    else if (cmbBankName.Text == "DBBL")
                    {
                        rate = 7;
                    }
                    else if (cmbBankName.Text == "HSBC")
                    {
                        rate = 8;
                    }
                    int year = Convert.ToInt32(txtTime.Text);
                    decimal balance = Convert.ToDecimal(txtBalance.Text);
                    decimal result = balance * rate * year / 100;
                    lblInterest.Text = result.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private bool CheckValue()
        {
            int intValue = 0;
            decimal decimalValue = 0;
            if((int.TryParse(txtTime.Text,out intValue)) == false                      )
            {
                MessageBox.Show("Please enter year correctly.");
                return false;
            }
            if(!(decimal.TryParse(txtBalance.Text,out decimalValue)))
            {
                MessageBox.Show("Please enter balance correctly.");
                return false;
            }
            if(cmbBankName.SelectedIndex  == -1)
            {
                MessageBox.Show("Please select a Bank.");
                return false;
            }
            else
                return true;
        }

    }
}
