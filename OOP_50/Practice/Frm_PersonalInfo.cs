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
    public partial class Frm_PersonalInfo : Form
    {

        private string firstName = "";
        private string lastName = "";
        private string fatherName = "";
        private string motherName = "";
        private string Address = "";

        public Frm_PersonalInfo()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtFirstName.Text.Length == 0 || txtLastName.Text.Length == 0 || txtFatherName.Text.Length == 0 ||
                txtMotherName.Text.Length == 0 || txtAddress.Text.Length == 0)
            {
                MessageBox.Show("Please provide all data");
            }
            else
            {
                firstName = txtFirstName.Text;
                lastName = txtLastName.Text;
                fatherName = txtFatherName.Text;
                motherName = txtMotherName.Text;
                Address = txtAddress.Text;
                MessageBox.Show("Saved successfully");
                New();
            }
        }

        private void btnShowAllInfo_Click(object sender, EventArgs e)
        {
            string ShowMessage = "Name: " + firstName + " " + lastName + "\n" +
                                 "Father Name: " + fatherName + "\n" +
                                 "Mother Name: " + motherName + "\n" +
                                 "Address: "+Address;
            MessageBox.Show(ShowMessage);
        }

        private void btnName_Click(object sender, EventArgs e)
        {
            string ShowMessage = "Name: " + firstName + " " + lastName;
            MessageBox.Show(ShowMessage);
        }

        private void New()
        {
            txtAddress.Text = "";
            txtFatherName.Text = "";
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtMotherName.Text = "";
        }

        private void btnParentName_Click(object sender, EventArgs e)
        {
            string ShowMessage = "Father: " + fatherName + " and Mother:" +motherName;
            MessageBox.Show(ShowMessage);
        }

        private void btnAddress_Click(object sender, EventArgs e)
        {
            string ShowMessage = "Address: " + Address;
            MessageBox.Show(ShowMessage);
        }

        private bool CheckEntry()
        {
            if (txtFirstName.Text.Length == 0)
            {
                MessageBox.Show("Please enter first name");
                return false;
            }

            if (txtLastName.Text.Length == 0)
            {
                MessageBox.Show("Please enter last name");
                return false;
            }

            if (txtFatherName.Text.Length == 0)
            {
                MessageBox.Show("Please enter fatthr name");
                return false;
            }
            if (txtMotherName.Text.Length == 0)
            {
                MessageBox.Show("Please enter mother name");
                return false;
            }
            if (txtAddress.Text.Length == 0)
            {
                MessageBox.Show("Please enter Address");
                return false;
            }
            else
            {
                return true;
            }


        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            txtFirstName.Text = firstName;
            txtLastName.Text = lastName ;
            txtFatherName.Text = fatherName ;
            txtMotherName.Text = motherName ;
            txtAddress.Text = Address ;
        }
    }
}
