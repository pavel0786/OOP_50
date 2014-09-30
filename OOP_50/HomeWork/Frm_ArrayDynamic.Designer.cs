namespace OOP_50.HomeWork
{
    partial class Frm_ArrayDynamic
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
            this.btnGenerate = new System.Windows.Forms.Button();
            this.txtNumberOfNumber = new System.Windows.Forms.TextBox();
            this.lbxGeneratedNumber = new System.Windows.Forms.ListBox();
            this.lbxIndex = new System.Windows.Forms.ListBox();
            this.btnFindIndex = new System.Windows.Forms.Button();
            this.txtSearchingNumber = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(198, 26);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(75, 23);
            this.btnGenerate.TabIndex = 0;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // txtNumberOfNumber
            // 
            this.txtNumberOfNumber.Location = new System.Drawing.Point(73, 26);
            this.txtNumberOfNumber.Name = "txtNumberOfNumber";
            this.txtNumberOfNumber.Size = new System.Drawing.Size(100, 20);
            this.txtNumberOfNumber.TabIndex = 1;
            // 
            // lbxGeneratedNumber
            // 
            this.lbxGeneratedNumber.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbxGeneratedNumber.FormattingEnabled = true;
            this.lbxGeneratedNumber.Location = new System.Drawing.Point(39, 57);
            this.lbxGeneratedNumber.Name = "lbxGeneratedNumber";
            this.lbxGeneratedNumber.Size = new System.Drawing.Size(120, 186);
            this.lbxGeneratedNumber.TabIndex = 2;
            // 
            // lbxIndex
            // 
            this.lbxIndex.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbxIndex.FormattingEnabled = true;
            this.lbxIndex.Location = new System.Drawing.Point(223, 55);
            this.lbxIndex.Name = "lbxIndex";
            this.lbxIndex.Size = new System.Drawing.Size(120, 186);
            this.lbxIndex.TabIndex = 3;
            // 
            // btnFindIndex
            // 
            this.btnFindIndex.Location = new System.Drawing.Point(170, 145);
            this.btnFindIndex.Name = "btnFindIndex";
            this.btnFindIndex.Size = new System.Drawing.Size(40, 23);
            this.btnFindIndex.TabIndex = 4;
            this.btnFindIndex.Text = "=>";
            this.btnFindIndex.UseVisualStyleBackColor = true;
            // 
            // txtSearchingNumber
            // 
            this.txtSearchingNumber.Location = new System.Drawing.Point(164, 111);
            this.txtSearchingNumber.Name = "txtSearchingNumber";
            this.txtSearchingNumber.Size = new System.Drawing.Size(53, 20);
            this.txtSearchingNumber.TabIndex = 5;
            // 
            // Frm_ArrayDynamic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 255);
            this.Controls.Add(this.txtSearchingNumber);
            this.Controls.Add(this.btnFindIndex);
            this.Controls.Add(this.lbxIndex);
            this.Controls.Add(this.lbxGeneratedNumber);
            this.Controls.Add(this.txtNumberOfNumber);
            this.Controls.Add(this.btnGenerate);
            this.Name = "Frm_ArrayDynamic";
            this.Text = "Dynamic Array";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.TextBox txtNumberOfNumber;
        private System.Windows.Forms.ListBox lbxGeneratedNumber;
        private System.Windows.Forms.ListBox lbxIndex;
        private System.Windows.Forms.Button btnFindIndex;
        private System.Windows.Forms.TextBox txtSearchingNumber;
    }
}