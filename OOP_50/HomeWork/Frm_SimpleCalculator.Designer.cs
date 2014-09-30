namespace OOP_50.HomeWork
{
    partial class Frm_SimpleCalculator
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
            this.txtFirstNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSecondNumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSubtruct = new System.Windows.Forms.Button();
            this.btnDevide = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtFirstNumber
            // 
            this.txtFirstNumber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtFirstNumber.Location = new System.Drawing.Point(135, 26);
            this.txtFirstNumber.Name = "txtFirstNumber";
            this.txtFirstNumber.Size = new System.Drawing.Size(179, 20);
            this.txtFirstNumber.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "First Number:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Second Number:";
            // 
            // txtSecondNumber
            // 
            this.txtSecondNumber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSecondNumber.Location = new System.Drawing.Point(135, 52);
            this.txtSecondNumber.Name = "txtSecondNumber";
            this.txtSecondNumber.Size = new System.Drawing.Size(179, 20);
            this.txtSecondNumber.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(77, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Result:";
            // 
            // txtResult
            // 
            this.txtResult.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtResult.Location = new System.Drawing.Point(135, 78);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(179, 20);
            this.txtResult.TabIndex = 4;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAdd.Location = new System.Drawing.Point(31, 121);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSubtruct
            // 
            this.btnSubtruct.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSubtruct.Location = new System.Drawing.Point(112, 121);
            this.btnSubtruct.Name = "btnSubtruct";
            this.btnSubtruct.Size = new System.Drawing.Size(75, 23);
            this.btnSubtruct.TabIndex = 7;
            this.btnSubtruct.Text = "Subtruct";
            this.btnSubtruct.UseVisualStyleBackColor = true;
            this.btnSubtruct.Click += new System.EventHandler(this.btnSubtruct_Click);
            // 
            // btnDevide
            // 
            this.btnDevide.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDevide.Location = new System.Drawing.Point(193, 121);
            this.btnDevide.Name = "btnDevide";
            this.btnDevide.Size = new System.Drawing.Size(75, 23);
            this.btnDevide.TabIndex = 8;
            this.btnDevide.Text = "Devide";
            this.btnDevide.UseVisualStyleBackColor = true;
            this.btnDevide.Click += new System.EventHandler(this.btnDevide_Click);
            // 
            // btnMultiply
            // 
            this.btnMultiply.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnMultiply.Location = new System.Drawing.Point(274, 121);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(75, 23);
            this.btnMultiply.TabIndex = 9;
            this.btnMultiply.Text = "Multiply";
            this.btnMultiply.UseVisualStyleBackColor = true;
            this.btnMultiply.Click += new System.EventHandler(this.btnMultiply_Click);
            // 
            // Frm_SimpleCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 179);
            this.Controls.Add(this.btnMultiply);
            this.Controls.Add(this.btnDevide);
            this.Controls.Add(this.btnSubtruct);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSecondNumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFirstNumber);
            this.Name = "Frm_SimpleCalculator";
            this.Text = "Simple Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFirstNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSecondNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSubtruct;
        private System.Windows.Forms.Button btnDevide;
        private System.Windows.Forms.Button btnMultiply;
    }
}