using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Database;

namespace OOP_50.Practice
{
    public partial class StudentUI : Form
    {
        public StudentUI()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
            ShowValue();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = new Connection().ConnectionString;
            SqlConnection aConnection = new SqlConnection();
            aConnection.ConnectionString = connectionString;
            aConnection.Open();

            string query = String.Format(@"INSERT INTO Student VALUES('{0}','{1}','{2}')", StudentNameTextBox.Text, emailTextBox.Text,addressTextBox.Text);
            SqlCommand aCommand = new SqlCommand(query,aConnection);

            int total = aCommand.ExecuteNonQuery();
            if (total > 0)
            {
                MessageBox.Show("Inserted");
            }
            else
            {
                MessageBox.Show("Not Inserted");
            }
            aConnection.Close();
            ShowValue();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ShowValue();
        }

        private void ShowValue()
        {
            string connectionString = new Connection().ConnectionString;
            SqlConnection aConnection = new SqlConnection(connectionString);
            aConnection.Open();

            string query = String.Format(@"select *,ROW_NUMBER() OVER(ORDER BY StudentID ASC) AS Row from Student");
            SqlCommand aCommand = new SqlCommand(query, aConnection);

            SqlDataReader aReader = aCommand.ExecuteReader();
            List<Student> listStudent = new List<Student>();

            if (aReader.HasRows)
            {
                while (aReader.Read())
                {
                    Student oneStudent = new Student();
                    oneStudent.StudentID = int.Parse(aReader[0].ToString());
                    oneStudent.StudentName = aReader[1].ToString();
                    oneStudent.Email = aReader[2].ToString();
                    oneStudent.Address = aReader[3].ToString();
                    listStudent.Add(oneStudent);
                }
            }
            aConnection.Close();
            dataGridView1.DataSource = listStudent;
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow r in dataGridView1.Rows)
            {
                dataGridView1.Rows[r.Index].HeaderCell.Value = (r.Index + 1).ToString();
            }
        }
    }
}
