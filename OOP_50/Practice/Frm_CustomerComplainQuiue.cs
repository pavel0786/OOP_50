using OOP_50.Class;
using System;
using System.Collections;
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
    public partial class Frm_CustomerComplainQuiue : Form
    {
        public Frm_CustomerComplainQuiue()
        {
            InitializeComponent();
        }

        Queue<Customer> QuiueCustomer = new Queue<Customer>();
        private int Sequence = 0;

        private void enqueueButton_Click(object sender, EventArgs e)
        {
            Customer aCustomer = new Customer();
            Sequence++;

            aCustomer.serial = Sequence;
            aCustomer.name = NameTextBox.Text ;
            aCustomer.complain = complainTextBox.Text;

            QuiueCustomer.Enqueue(aCustomer);

            LoadCustomer();
            
        }
        private void LoadCustomer()
        {
            listView.Items.Clear();

            foreach (Customer aCustomer in QuiueCustomer)
            {
                ListViewItem oneItem = new ListViewItem(aCustomer.serial.ToString());
                oneItem.SubItems.Add(aCustomer.name);
                oneItem.SubItems.Add(aCustomer.complain);

                listView.Items.Add(oneItem);
            }
        }

        private void dequeueButton_Click(object sender, EventArgs e)
        {
            if (QuiueCustomer.Count == 0)
            {
                MessageBox.Show("Queue Empty");
                return;
            }
            Customer aCustomer = QuiueCustomer.Dequeue();

            serialNoTextBox.Text = aCustomer.serial.ToString();
            dequeueNameTextBox.Text = aCustomer.name;
            dequeueComplainTextBox.Text = aCustomer.complain;

            LoadCustomer();

            //listView.Items.RemoveAt(0);

        }

    }
}
