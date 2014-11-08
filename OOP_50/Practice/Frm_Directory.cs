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
    public partial class Frm_Directory : Form
    {
        string RoorDirectory;
        public Frm_Directory()
        {
            InitializeComponent();
        }

        Stack<string> dirs = new Stack<string>(20000);
        Stack<string> AllFiles = new Stack<string>(200000);
        private void button1_Click(object sender, EventArgs e)
        {
            dirs.Clear();
            AllFiles.Clear();
            if (textBox1.Text.Length == 0)
            {
                MessageBox.Show("Please enter a Directory");
                return;
            }
            else
            {
                RoorDirectory = textBox1.Text;

                if (!System.IO.Directory.Exists(RoorDirectory))
                {
                    MessageBox.Show("Wrong Root.");
                    return;
                }
            }
            Traverse(RoorDirectory);

            FileStream objFileStream = new FileStream(RoorDirectory+@"\Directory.txt", FileMode.Append);
            StreamWriter objStreamWriter = new StreamWriter(objFileStream);
            
            foreach(string s in dirs)
            {
                objStreamWriter.WriteLine(s);
            }
            objStreamWriter.Close();

            FileStream objFileStream1 = new FileStream(RoorDirectory + @"\FIlesctory.txt", FileMode.Append);
            StreamWriter objStreamWriter1 = new StreamWriter(objFileStream1);
            foreach (string s in AllFiles)
            {
                objStreamWriter1.WriteLine(s);
            }
            objStreamWriter1.Close();

            MessageBox.Show("Write Successfully");
        }

        public void Traverse(string root)
        {
            try
            {
                string[] subDirs = System.IO.Directory.GetDirectories(root);

                string[] Files = System.IO.Directory.GetFiles(root);

                foreach(string file in Files)
                {
                    AllFiles.Push(file);
                }
                foreach(string s in subDirs)
                {
                    dirs.Push(s);                    
                    Traverse(s);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
