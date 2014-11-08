using OOP_50.Class;
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
    public partial class SalaryCalulatorUI : Form
    {
        public SalaryCalulatorUI()
        {
            InitializeComponent();
        }

        private void SalaryCalulatorUI_Load(object sender, EventArgs e)
        {

        }

        private void showMeSalaryButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckEntry())
                {
                    Employee anEmployee = new Employee();;
                    anEmployee.EmployeeName= nameTextBox.Text;
                    anEmployee.BasicSalary = Decimal.Parse(basicAmountTextBox.Text);
                    anEmployee.PercentageOfHouseRent = Decimal.Parse(houseRentTextBox.Text);
                    anEmployee.PercentageOfMedicalAllowance = Decimal.Parse(medicalAllowanceTextBox.Text);
                    
                    Decimal totalSalary = anEmployee.GetTotalSalary();
                    MessageBox.Show("Total Salary for " + anEmployee.EmployeeName + " is " + totalSalary);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public Boolean CheckEntry()
        {
            decimal decimalValue;
            if (!decimal.TryParse( basicAmountTextBox.Text, out decimalValue))
            {
                MessageBox.Show("Please enter Basic Amount correctly");
                return false;
            }
            if (!decimal.TryParse(houseRentTextBox.Text, out decimalValue))
            {
                MessageBox.Show("Please enter House Rent correctly");
                return false;
            }
            if (!decimal.TryParse(medicalAllowanceTextBox.Text, out decimalValue))
            {
                MessageBox.Show("Please enter Medical Allowance correctly");
                return false;
            }
            else
                return true;
        }
    }
}
