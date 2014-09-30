using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OOP_50.Practice
{
    public partial class Frm_Array : Form
    {
        int []array = new Int32[5];
        int index = 0;
        public Frm_Array()
        {
            InitializeComponent();
        }

        bool Clear = false;
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (index < 5)
                {
                    array[index] = int.Parse(txtNumber.Text);
                    txtCounter.Text = (index + 1).ToString();
                    index++;

                    textBox1.Text = textBox1.Text + txtNumber.Text + ",";

                    if (index == array.Length && Clear == false)
                    {
                        textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
                        Clear = true;
                    }
                }
                else
                {
                    MessageBox.Show("Array Full");
                }
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
                int startIndex = 0;
                int location = -1;

                string s1 = "";
                if (array.Count() > 0)
                {
                    for (; true; )
                    {
                        location = Array.IndexOf(array, 100, startIndex);

                        if (location >= 0)
                        {
                            s1 = s1 + "[" + location.ToString() + "],";
                            startIndex = location + 1;
                        }
                        else
                        {
                            break;
                        }
                    }
                    if (s1 == "")
                        s1 = "-1";
                    else
                        txtIndexOf100.Text = s1.Substring(0, s1.Length - 1);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
