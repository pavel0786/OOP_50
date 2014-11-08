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

namespace OOP_50.Practice
{
    public partial class CircleUI : Form
    {
        public CircleUI()
        {
            InitializeComponent();
        }

        private void diameterButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckEntry())
                {
                    decimal diameter = 0;
                    Circle aCircle = new Circle();
                    aCircle.radius = Convert.ToDecimal( radiusTextBox.Text);
                   // aCircle.GetDiameter();
                    diameter= aCircle.GetDiameter();

                    MessageBox.Show("Diameter of the Circle is " + diameter.ToString());
                }
            }
            catch(Exception ex )
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void perimeterButton_Click(object sender, EventArgs e)
        {
            try
            {
                if(CheckEntry())
                {
                    decimal perimeter = 0;
                    Circle aCircle = new Circle();
                    aCircle.radius = Convert.ToDecimal(radiusTextBox.Text);
                    perimeter = aCircle.GetPerimeter();
                    MessageBox.Show("Perimeter of the Circle is " + perimeter.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void areaButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckEntry())
                {
                    decimal area = 0;
                    Circle aCircle = new Circle();
                    aCircle.radius = Convert.ToDecimal(radiusTextBox.Text);
                    area = aCircle.GetArea();
                    MessageBox.Show("Area of the Circle is " + area.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public Boolean CheckEntry()
        {
            decimal decimalValue;
            if (!decimal.TryParse(radiusTextBox.Text, out decimalValue))
            {
                MessageBox.Show("Please enter radius correctly");
                return false;
            }
            else
                return true;
        }
    }
}
