using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OOP_50.HomeWork
{
    public partial class Frm_BonusCalculator : Form
    {
        public Frm_BonusCalculator()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if(checkEntry())
            {
                decimal salary = decimal.Parse(txtSalary.Text);
                if(salary<=10000)
                {
                    txtBonus.Text = (salary * 5/100).ToString();
                }
                else if(salary > 10000 && salary<= 18000)
                {
                    txtBonus.Text = (salary * 6 / 100).ToString();
                }
                else
                {
                    txtBonus.Text = (salary * 7 / 100).ToString();
                }
            }
        }
        private bool checkEntry()
        {
            decimal decimalValue = 0;
            if (!decimal.TryParse(txtSalary.Text, out decimalValue))
            {
                MessageBox.Show("Please enter a correct salary");
                return false;
            }
            else
                return true;
        }
    }
}
