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
    public partial class CalculatorUI : Form
    {
        decimal firstNumber;
        decimal secondNumber;
        Calculator aCalculator = new Calculator();


        public CalculatorUI()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                if(CheckEntry())
                {
                    
                    SetTwoNumbers();                    
                    resultTextBox.Text = (aCalculator.Add(firstNumber,secondNumber)).ToString();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void SetTwoNumbers()
        {
            firstNumber = Decimal.Parse(firstNumberTextBox.Text);
            secondNumber = Decimal.Parse(secondNumberTextBox.Text);
        }

        public Boolean CheckEntry()
        {
            decimal decimalValue;
            if(!decimal.TryParse(firstNumberTextBox.Text,out decimalValue))
            {
                MessageBox.Show("Please enter first Number correctly");
                return false;
            }
            if (!decimal.TryParse(secondNumberTextBox.Text, out decimalValue))
            {
                MessageBox.Show("Please enter second Number correctly");
                return false;
            }
            else
                return true;
        }

        private void subtractButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckEntry())
                {
                    SetTwoNumbers();
                    resultTextBox.Text = (aCalculator.Subtract(firstNumber, secondNumber)).ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void multiplyButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckEntry())
                {
                    SetTwoNumbers();
                    resultTextBox.Text = (aCalculator.Multiply(firstNumber, secondNumber)).ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void divideButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckEntry())
                {
                    SetTwoNumbers();
                    resultTextBox.Text = (aCalculator.Divide(firstNumber, secondNumber)).ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
