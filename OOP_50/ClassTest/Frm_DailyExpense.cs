using CSVLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OOP_50.ClassTest
{
    public partial class Frm_DailyExpense : Form
    {
        string fileLocation = "DailyExpense.csv";
        public Frm_DailyExpense()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if(CheckEntry())
                {
                    FileStream aStreamForWriting = new FileStream(fileLocation, FileMode.Append);
                    CsvFileWriter aWriter = new CsvFileWriter(aStreamForWriting);
                    List<string> aRecord = new List<string>();
                    aRecord.Add(txtAmount.Text);
                    aRecord.Add(cmbCategoryEntry.Text);
                    aRecord.Add(txtParticular.Text);
                    aWriter.WriteRow(aRecord);
                    aStreamForWriting.Close();

                    MessageBox.Show("Write Successfully..");
                }
                ClearAfterSave();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ClearAfterSave()
        {
            txtAmount.Text = "";
            txtParticular.Text = "";
        }

        private bool CheckEntry()
        {
            decimal decimalVaue = 0;
            if (!Decimal.TryParse(txtAmount.Text, out decimalVaue))
            {
                MessageBox.Show("Wrong amount entry. Please enter a valid amount");
                return false;
            }
            else if(decimalVaue<=0)
            {
                MessageBox.Show("Please provide some +ve Amount.");
                return false;
            }
            else
                return true;
        }

        private void btnShowSummery_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream aStream = new FileStream(fileLocation, FileMode.Open);
                CsvFileReader aReader = new CsvFileReader(aStream);

                List<string> aRecord = new List<string>();

                decimal totalEpense = 0;
                decimal maximumExpense = -1;

                while (aReader.ReadRow(aRecord))
                {
                    if(aRecord.Count>0)
                    {
                        if(aRecord[0]!=null)
                        {
                            decimal amount = decimal.Parse(aRecord[0]);
                            totalEpense+=amount;
                            if(amount>maximumExpense)
                            {
                                maximumExpense = amount;
                            }
                        }
                    }                    
                }
                aStream.Close();

                txtMaximumExpense.Text = maximumExpense.ToString();
                txtTotalExpense.Text = totalEpense.ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnShowByCategory_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbCategorySearch.SelectedIndex >= 0)
                {   

                    decimal totalExpance = 0;
                    lvDailyExpense.Items.Clear();
                    List<string> aRecord = new List<string>();

                    FileStream aStream = new FileStream(fileLocation, FileMode.Open);
                    CsvFileReader aReader = new CsvFileReader(aStream);

                    while (aReader.ReadRow(aRecord))
                    {
                        if (aRecord.Count > 1)
                        {
                            if (aRecord[1] != null)
                            {
                                string acategory = aRecord[1];
                                if (acategory == cmbCategorySearch.Text)
                                {
                                    ListViewItem oneListViewItem = new ListViewItem(aRecord[2]);
                                    oneListViewItem.SubItems.Add(aRecord[0]);
                                    lvDailyExpense.Items.Add(oneListViewItem);

                                    totalExpance += decimal.Parse(aRecord[0]);
                                }
                            }
                        }
                    }


                    aStream.Close();
                    txtTotalByCategory.Text = totalExpance.ToString();
                }
                else
                {
                    MessageBox.Show("Please select a category");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            txtAmount.Text = "";
            txtMaximumExpense.Text = "";
            txtParticular.Text = "";
            txtTotalByCategory.Text = "";
            txtTotalExpense.Text = "";
            cmbCategoryEntry.SelectedIndex = -1;
            cmbCategorySearch.SelectedIndex = -1;
            lvDailyExpense.Items.Clear();
        }

    }
}
