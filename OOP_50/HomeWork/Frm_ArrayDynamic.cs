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
    public partial class Frm_ArrayDynamic : Form
    {
        int[] NumberArray;
        
        public Frm_ArrayDynamic()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            try
            {
                int numberOfSelection = int.Parse(txtNumberOfNumber.Text);
                NumberArray = new int[numberOfSelection];

                int min = int.Parse(txtMin.Text);
                int max = int.Parse(txtMax.Text);

                Random objRandom = new Random();
                for(int i = 0;i<numberOfSelection;i++)
                {
                    NumberArray[i] =objRandom.Next(min, max);
                }
                lbxGeneratedNumber.DataSource = NumberArray;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnFindIndex_Click(object sender, EventArgs e)
        {
            try
            {
                int serchingNumber = int.Parse(txtSearchingNumber.Text);
                int startIndex = 0;
                int foundedIndex = -1;
                NumberArray = lbxGeneratedNumber.DataSource as int[];

                List<int> indexList = new List<int>();
                while(true)
                {
                    foundedIndex = Array.IndexOf(NumberArray, serchingNumber, startIndex);
                    if(foundedIndex>=0)
                    {
                        indexList.Add(foundedIndex);
                        startIndex = foundedIndex + 1;
                    }
                    else
                    {
                        break;
                    }
                }
                lbxIndex.DataSource = indexList;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
