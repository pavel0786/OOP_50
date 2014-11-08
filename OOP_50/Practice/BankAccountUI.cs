using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OOP_50.Class;

namespace OOP_50.Practice
{
    public partial class BankAccountUI : Form
    {
        Account account;
        public BankAccountUI()
        {
            InitializeComponent();
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            const string message = "Created successfully";
            try
            {
                account = new Account(accountNameTextBox.Text,accountNumberTextBox.Text);
                //account.AccountName = accountNameTextBox.Text;
                //account.AccountNumber = accountNumberTextBox.Text;
                MessageBox.Show(message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void depositButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckEntry())
                {
                    decimal amount = Convert.ToDecimal(amountTextBox.Text);
                    bool success = account.Deposit(amount);
                    if (success == true)
                    {
                        MessageBox.Show("Deposited successfully");
                    }
                    else
                    {
                        MessageBox.Show("Deposite fail.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void withdrawButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckEntry())
                {
                    decimal amount = Convert.ToDecimal(amountTextBox.Text);
                    bool success = account.Withdraw(amount);
                    if (success == true)
                    {
                        MessageBox.Show("Withdrawn successfully");
                    }
                    else
                    {
                        MessageBox.Show("Withdraw fail.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void reportButton_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Current balance for " + account.AccountName + " is " + account.Balance);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private bool CheckEntry()
        {
            decimal decimalValue = 0;
            if (!decimal.TryParse(amountTextBox.Text, out decimalValue))
            {
                MessageBox.Show("Please enter amount correctly");
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
