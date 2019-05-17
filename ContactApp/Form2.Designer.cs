namespace ContactApp
{
    partial class Form2
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
            this.TBPhoneNum = new System.Windows.Forms.TextBox();
            this.TBWebS = new System.Windows.Forms.TextBox();
            this.TBEMail = new System.Windows.Forms.TextBox();
            this.TBSName = new System.Windows.Forms.TextBox();
            this.TBName = new System.Windows.Forms.TextBox();
            this.DBirthday = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TBPhoneNum
            // 
            this.TBPhoneNum.Location = new System.Drawing.Point(156, 214);
            this.TBPhoneNum.Name = "TBPhoneNum";
            this.TBPhoneNum.Size = new System.Drawing.Size(366, 20);
            this.TBPhoneNum.TabIndex = 33;
            // 
            // TBWebS
            // 
            this.TBWebS.Location = new System.Drawing.Point(156, 175);
            this.TBWebS.Name = "TBWebS";
            this.TBWebS.Size = new System.Drawing.Size(366, 20);
            this.TBWebS.TabIndex = 32;
            // 
            // TBEMail
            // 
            this.TBEMail.Location = new System.Drawing.Point(156, 133);
            this.TBEMail.Name = "TBEMail";
            this.TBEMail.Size = new System.Drawing.Size(366, 20);
            this.TBEMail.TabIndex = 31;
            // 
            // TBSName
            // 
            this.TBSName.Location = new System.Drawing.Point(156, 51);
            this.TBSName.Name = "TBSName";
            this.TBSName.Size = new System.Drawing.Size(366, 20);
            this.TBSName.TabIndex = 30;
            // 
            // TBName
            // 
            this.TBName.Location = new System.Drawing.Point(156, 15);
            this.TBName.Name = "TBName";
            this.TBName.Size = new System.Drawing.Size(366, 20);
            this.TBName.TabIndex = 29;
            // 
            // DBirthday
            // 
            this.DBirthday.Location = new System.Drawing.Point(156, 95);
            this.DBirthday.Name = "DBirthday";
            this.DBirthday.Size = new System.Drawing.Size(200, 20);
            this.DBirthday.TabIndex = 28;
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(52, 217);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(87, 25);
            this.label13.TabIndex = 27;
            this.label13.Text = "Phone number:";
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(52, 178);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 25);
            this.label11.TabIndex = 26;
            this.label11.Text = "Web site:";
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(52, 136);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 25);
            this.label9.TabIndex = 25;
            this.label9.Text = "EMail:";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(52, 95);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 25);
            this.label7.TabIndex = 24;
            this.label7.Text = "Birthday:";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(52, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 25);
            this.label5.TabIndex = 23;
            this.label5.Text = "Second Name:";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(52, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 25);
            this.label2.TabIndex = 22;
            this.label2.Text = "Name:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(196, 255);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 28);
            this.button1.TabIndex = 34;
            this.button1.Text = "Ok";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(323, 255);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(50, 28);
            this.button2.TabIndex = 35;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 288);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TBPhoneNum);
            this.Controls.Add(this.TBWebS);
            this.Controls.Add(this.TBEMail);
            this.Controls.Add(this.TBSName);
            this.Controls.Add(this.TBName);
            this.Controls.Add(this.DBirthday);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form2";
            this.Text = "Form2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TBPhoneNum;
        private System.Windows.Forms.TextBox TBWebS;
        private System.Windows.Forms.TextBox TBEMail;
        private System.Windows.Forms.TextBox TBSName;
        private System.Windows.Forms.TextBox TBName;
        private System.Windows.Forms.DateTimePicker DBirthday;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}