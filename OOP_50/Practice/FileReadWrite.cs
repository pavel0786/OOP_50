using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OOP_50.Practice
{
    public partial class FileReadWrite : Form
    {
        string fileLocation = @"..\\Debug\FILE\NameFile.txt";
        public FileReadWrite()
        {
            InitializeComponent();

            
            string s1 = "sjdhfjds&flk$sjfod&sAB&CDe8r0tye&ruoturAB&CDsugio&ufdsf&ough";
            string[] s2 = { "&" };
            string[] StringArray = s1.Split(s2, StringSplitOptions.None);
            MessageBox.Show(StringArray.Length.ToString());

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream aFileStream = new FileStream(fileLocation, FileMode.Append);
                StreamWriter aStreamWriter = new StreamWriter(aFileStream);
                aStreamWriter.WriteLine(txtValue.Text);
                aStreamWriter.Close();
                MessageBox.Show("Write Successfully");
                txtValue.Text = "";

            }
            catch(Exception ex)
            { 
                MessageBox.Show(ex.Message);
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream aFileStream = new FileStream(fileLocation, FileMode.Open);
                StreamReader aStreamReader = new StreamReader(aFileStream);
                lbxName.Items.Clear();
                while(!aStreamReader.EndOfStream)
                {
                    string oneline = aStreamReader.ReadLine();
                    lbxName.Items.Add(oneline);
                }
                aStreamReader.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDirectory_Click(object sender, EventArgs e)
        {
            try
            {
                string[] filePaths = Directory.GetFiles(@"E:\Images\", "*.bmp", SearchOption.AllDirectories);
                lbxName.Items.Add(filePaths);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
