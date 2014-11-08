namespace OOP_50.Practice
{
    partial class CircleUI
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
            this.perimeterButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.diameterButton = new System.Windows.Forms.Button();
            this.areaButton = new System.Windows.Forms.Button();
            this.radiusTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // perimeterButton
            // 
            this.perimeterButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.perimeterButton.Location = new System.Drawing.Point(191, 69);
            this.perimeterButton.Name = "perimeterButton";
            this.perimeterButton.Size = new System.Drawing.Size(75, 23);
            this.perimeterButton.TabIndex = 0;
            this.perimeterButton.Text = "Perimeter";
            this.perimeterButton.UseVisualStyleBackColor = true;
            this.perimeterButton.Click += new System.EventHandler(this.perimeterButton_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(105, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Radius";
            // 
            // diameterButton
            // 
            this.diameterButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.diameterButton.Location = new System.Drawing.Point(79, 69);
            this.diameterButton.Name = "diameterButton";
            this.diameterButton.Size = new System.Drawing.Size(75, 23);
            this.diameterButton.TabIndex = 2;
            this.diameterButton.Text = "Diameter";
            this.diameterButton.UseVisualStyleBackColor = true;
            this.diameterButton.Click += new System.EventHandler(this.diameterButton_Click);
            // 
            // areaButton
            // 
            this.areaButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.areaButton.Location = new System.Drawing.Point(321, 69);
            this.areaButton.Name = "areaButton";
            this.areaButton.Size = new System.Drawing.Size(75, 23);
            this.areaButton.TabIndex = 3;
            this.areaButton.Text = "Area";
            this.areaButton.UseVisualStyleBackColor = true;
            this.areaButton.Click += new System.EventHandler(this.areaButton_Click);
            // 
            // radiusTextBox
            // 
            this.radiusTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radiusTextBox.Location = new System.Drawing.Point(181, 24);
            this.radiusTextBox.Name = "radiusTextBox";
            this.radiusTextBox.Size = new System.Drawing.Size(149, 20);
            this.radiusTextBox.TabIndex = 4;
            // 
            // CircleUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 121);
            this.Controls.Add(this.radiusTextBox);
            this.Controls.Add(this.areaButton);
            this.Controls.Add(this.diameterButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.perimeterButton);
            this.Name = "CircleUI";
            this.Text = "Circle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button perimeterButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button diameterButton;
        private System.Windows.Forms.Button areaButton;
        private System.Windows.Forms.TextBox radiusTextBox;
    }
}