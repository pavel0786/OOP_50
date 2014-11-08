using System.Data.SqlClient;
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
using Database;
using OOP_50.Gateway;

namespace OOP_50.Practice
{
    public partial class DepartmentUI : Form
    {
        private Department aDepartment;

        public DepartmentUI()
        {
            InitializeComponent();
            departmentDataGridView.AutoGenerateColumns = false;
            ShowData();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                aDepartment = new Department();
                aDepartment.Name = nameTextBox.Text;
                aDepartment.Code = codeTextBox.Text;

                if (new DepartmentGateway().Insert(aDepartment))
                {
                    MessageBox.Show("Inserted");
                }
                else
                {
                    MessageBox.Show("Fail");
                }

                ShowData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ShowData()
        {
            try
            {
                List<Department> listDepartment = new DepartmentGateway().GetAll();
                departmentDataGridView.DataSource = listDepartment;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void departmentDataGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow r in departmentDataGridView.Rows)
            {
                departmentDataGridView.Rows[r.Index].HeaderCell.Value = (r.Index + 1).ToString();
            }
        }
    }
}
