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
    public partial class Frm_SimpleCalculator : Form
    {
        public Frm_SimpleCalculator()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(CheckEntry())
            {
                decimal firstNumber = decimal.Parse(txtFirstNumber.Text);
                decimal secondNumber = decimal.Parse(txtSecondNumber.Text);
                txtResult.Text = (firstNumber + secondNumber).ToString();
            }
        }

        private void btnSubtruct_Click(object sender, EventArgs e)
        {
            if (CheckEntry())
            {
                decimal firstNumber = decimal.Parse(txtFirstNumber.Text);
                decimal secondNumber = decimal.Parse(txtSecondNumber.Text);
                txtResult.Text = (firstNumber - secondNumber).ToString();
            }
        }

        private void btnDevide_Click(object sender, EventArgs e)
        {
            if (CheckEntry())
            {
                decimal firstNumber = decimal.Parse(txtFirstNumber.Text);
                decimal secondNumber = decimal.Parse(txtSecondNumber.Text);
                txtResult.Text = (firstNumber / secondNumber).ToString();
            }
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            if (CheckEntry())
            {
                decimal firstNumber = decimal.Parse(txtFirstNumber.Text);
                decimal secondNumber = decimal.Parse(txtSecondNumber.Text);
                txtResult.Text = (firstNumber * secondNumber).ToString();
            }
        }
        private bool CheckEntry()
        {
            decimal _DecimalValue = 0;
            if (!decimal.TryParse(txtFirstNumber.Text, out _DecimalValue))
            {
                MessageBox.Show("Enter 1st number correctly.");
                return false;
            }
            else if (!decimal.TryParse(txtSecondNumber.Text, out _DecimalValue))
            {
                MessageBox.Show("Enter 2nd number correctly.");
                return false;
            }
            else
                return true;
        }
    }
}
