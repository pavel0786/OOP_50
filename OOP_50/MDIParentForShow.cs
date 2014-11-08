using OOP_50.Practice;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OOP_50.HomeWork;
using OOP_50.ClassTest;

namespace OOP_50
{
    public partial class MDIParentForShow : Form
    {
        public MDIParentForShow()
        {
            InitializeComponent();
            //LoadForm(new Frm_CustomerComplainQuiue());
            //LoadForm(new DepartmentUI());
        }
        
        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void dayOfAWeekToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadForm(new Frm_InterestCalculation());
        }

        private void personalInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadForm(new Frm_PersonalInfo());
        }

        private void LoadForm( Form objForm)
        {
            objForm.MdiParent = this;
            objForm.Show();
            objForm.WindowState = FormWindowState.Maximized;            
        }

        private void seriesPrintToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadForm(new Frm_GenerateSeries());
        }

        private void arrayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadForm(new Frm_Array());
        }

        private void simpleCalculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadForm(new Frm_SimpleCalculator());
        }

        private void bonusCalculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadForm(new Frm_BonusCalculator());
        }

        private void dynamicArrayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadForm(new Frm_ArrayDynamic());
        }

        private void callByValueAndReferenceToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadForm(new FileReadWrite());
        }

        private void directoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadForm(new Frm_Directory());
        }

        private void listViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadForm(new Frm_ListView());
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void zxczxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadForm(new Frm_DailyExpense());
        }

        private void cutomerComplainQuiueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadForm(new Frm_CustomerComplainQuiue());
        }

        private void calculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadForm(new CalculatorUI());
        }

        private void salaryCalculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadForm(new SalaryCalulatorUI());
        }

        private void circleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadForm(new CircleUI());
        }

        private void bankAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadForm(new BankAccountUI());
        }

        private void studentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadForm(new StudentUI());
        }

        private void departmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadForm(new DepartmentUI());
        }

        private void MDIParentForShow_Load(object sender, EventArgs e)
        {

        }
    }
}
