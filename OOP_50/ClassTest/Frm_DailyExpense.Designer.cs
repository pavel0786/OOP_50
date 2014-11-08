namespace OOP_50.ClassTest
{
    partial class Frm_DailyExpense
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtParticular = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbCategoryEntry = new System.Windows.Forms.ComboBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtMaximumExpense = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTotalExpense = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnShowSummery = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtTotalByCategory = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnShowByCategory = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbCategorySearch = new System.Windows.Forms.ComboBox();
            this.lvDailyExpense = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnClearAll = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.txtParticular);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmbCategoryEntry);
            this.groupBox1.Controls.Add(this.txtAmount);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(24, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(427, 233);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Daily Expense Entry";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(299, 192);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Insert";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtParticular
            // 
            this.txtParticular.Location = new System.Drawing.Point(158, 89);
            this.txtParticular.Multiline = true;
            this.txtParticular.Name = "txtParticular";
            this.txtParticular.Size = new System.Drawing.Size(216, 88);
            this.txtParticular.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(100, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Particular";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(102, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Category";
            // 
            // cmbCategoryEntry
            // 
            this.cmbCategoryEntry.FormattingEnabled = true;
            this.cmbCategoryEntry.Items.AddRange(new object[] {
            "House Rent",
            "Utility Bill",
            "Conveyance",
            "Grocery",
            "Misc"});
            this.cmbCategoryEntry.Location = new System.Drawing.Point(158, 62);
            this.cmbCategoryEntry.Name = "cmbCategoryEntry";
            this.cmbCategoryEntry.Size = new System.Drawing.Size(216, 21);
            this.cmbCategoryEntry.TabIndex = 2;
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(158, 36);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(216, 20);
            this.txtAmount.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(108, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Amount";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.Controls.Add(this.txtMaximumExpense);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtTotalExpense);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.btnShowSummery);
            this.groupBox2.Location = new System.Drawing.Point(24, 256);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(427, 113);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "View Summery";
            // 
            // txtMaximumExpense
            // 
            this.txtMaximumExpense.Location = new System.Drawing.Point(158, 74);
            this.txtMaximumExpense.Name = "txtMaximumExpense";
            this.txtMaximumExpense.Size = new System.Drawing.Size(216, 20);
            this.txtMaximumExpense.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(55, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Maximum Expanse";
            // 
            // txtTotalExpense
            // 
            this.txtTotalExpense.Location = new System.Drawing.Point(158, 48);
            this.txtTotalExpense.Name = "txtTotalExpense";
            this.txtTotalExpense.Size = new System.Drawing.Size(216, 20);
            this.txtTotalExpense.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(75, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Total Expense";
            // 
            // btnShowSummery
            // 
            this.btnShowSummery.Location = new System.Drawing.Point(299, 19);
            this.btnShowSummery.Name = "btnShowSummery";
            this.btnShowSummery.Size = new System.Drawing.Size(75, 23);
            this.btnShowSummery.TabIndex = 7;
            this.btnShowSummery.Text = "Show";
            this.btnShowSummery.UseVisualStyleBackColor = true;
            this.btnShowSummery.Click += new System.EventHandler(this.btnShowSummery_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox3.Controls.Add(this.lvDailyExpense);
            this.groupBox3.Controls.Add(this.txtTotalByCategory);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.btnShowByCategory);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.cmbCategorySearch);
            this.groupBox3.Location = new System.Drawing.Point(457, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(420, 363);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "View Categorywise Expense";
            // 
            // txtTotalByCategory
            // 
            this.txtTotalByCategory.Location = new System.Drawing.Point(252, 301);
            this.txtTotalByCategory.Name = "txtTotalByCategory";
            this.txtTotalByCategory.Size = new System.Drawing.Size(129, 20);
            this.txtTotalByCategory.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(179, 304);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Total";
            // 
            // btnShowByCategory
            // 
            this.btnShowByCategory.Location = new System.Drawing.Point(306, 46);
            this.btnShowByCategory.Name = "btnShowByCategory";
            this.btnShowByCategory.Size = new System.Drawing.Size(75, 23);
            this.btnShowByCategory.TabIndex = 7;
            this.btnShowByCategory.Text = "Show";
            this.btnShowByCategory.UseVisualStyleBackColor = true;
            this.btnShowByCategory.Click += new System.EventHandler(this.btnShowByCategory_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(108, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Category";
            // 
            // cmbCategorySearch
            // 
            this.cmbCategorySearch.FormattingEnabled = true;
            this.cmbCategorySearch.Items.AddRange(new object[] {
            "House Rent",
            "Utility Bill",
            "Conveyance",
            "Grocery",
            "Misc"});
            this.cmbCategorySearch.Location = new System.Drawing.Point(165, 19);
            this.cmbCategorySearch.Name = "cmbCategorySearch";
            this.cmbCategorySearch.Size = new System.Drawing.Size(216, 21);
            this.cmbCategorySearch.TabIndex = 4;
            // 
            // lvDailyExpense
            // 
            this.lvDailyExpense.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5});
            this.lvDailyExpense.Location = new System.Drawing.Point(67, 89);
            this.lvDailyExpense.Name = "lvDailyExpense";
            this.lvDailyExpense.Size = new System.Drawing.Size(314, 203);
            this.lvDailyExpense.TabIndex = 14;
            this.lvDailyExpense.UseCompatibleStateImageBehavior = false;
            this.lvDailyExpense.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Particular";
            this.columnHeader4.Width = 250;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Amount";
            // 
            // btnClearAll
            // 
            this.btnClearAll.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnClearAll.Location = new System.Drawing.Point(24, 379);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(853, 23);
            this.btnClearAll.TabIndex = 3;
            this.btnClearAll.Text = "Clear All";
            this.btnClearAll.UseVisualStyleBackColor = true;
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // Frm_DailyExpense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 414);
            this.Controls.Add(this.btnClearAll);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Frm_DailyExpense";
            this.Text = "Daily Expense";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtParticular;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbCategoryEntry;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtMaximumExpense;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTotalExpense;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnShowSummery;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtTotalByCategory;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnShowByCategory;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbCategorySearch;
        private System.Windows.Forms.ListView lvDailyExpense;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button btnClearAll;
    }
}