namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.serviceController1 = new System.ServiceProcess.ServiceController();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.rRadioButtonList1 = new WindowsFormsApplication1.RRadioButtonList(this.components);
            this.SuspendLayout();
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.CheckOnClick = true;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Cow",
            "Hen",
            "Dog",
            "Cat",
            "Bee"});
            this.checkedListBox1.Location = new System.Drawing.Point(29, 12);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(120, 94);
            this.checkedListBox1.TabIndex = 0;
            this.checkedListBox1.ThreeDCheckBoxes = true;
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            this.checkedListBox1.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBox1_ItemCheck_1);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 362);
            this.splitter1.TabIndex = 7;
            this.splitter1.TabStop = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(3, 340);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(447, 22);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(85, 202);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 10;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // rRadioButtonList1
            // 
            this.rRadioButtonList1.CheckOnClick = true;
            this.rRadioButtonList1.FormattingEnabled = true;
            this.rRadioButtonList1.Items.AddRange(new object[] {
            "Cow",
            "Hen",
            "Dog",
            "Cat",
            "Bee"});
            this.rRadioButtonList1.Location = new System.Drawing.Point(239, 44);
            this.rRadioButtonList1.Name = "rRadioButtonList1";
            this.rRadioButtonList1.Size = new System.Drawing.Size(120, 94);
            this.rRadioButtonList1.TabIndex = 9;
            this.rRadioButtonList1.ThreeDCheckBoxes = true;
            this.rRadioButtonList1.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.rRadioButtonList1_ItemCheck);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 362);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.rRadioButtonList1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.checkedListBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.ServiceProcess.ServiceController serviceController1;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private RRadioButtonList rRadioButtonList1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

