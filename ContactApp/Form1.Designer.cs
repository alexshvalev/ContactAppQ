namespace ContactApp
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.LName = new System.Windows.Forms.Label();
            this.LSName = new System.Windows.Forms.Label();
            this.LBirthday = new System.Windows.Forms.Label();
            this.LEmail = new System.Windows.Forms.Label();
            this.LWeb = new System.Windows.Forms.Label();
            this.LPNumber = new System.Windows.Forms.Label();
            this.TBName = new System.Windows.Forms.TextBox();
            this.TBSName = new System.Windows.Forms.TextBox();
            this.TBEMail = new System.Windows.Forms.TextBox();
            this.TBWebSite = new System.Windows.Forms.TextBox();
            this.TBPhoneNum = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TBDay = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(57, 21);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(209, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Find";
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(12, 47);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(254, 344);
            this.listBox1.TabIndex = 3;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.ListBox1_SelectedIndexChanged);
            // 
            // LName
            // 
            this.LName.Location = new System.Drawing.Point(318, 46);
            this.LName.Name = "LName";
            this.LName.Size = new System.Drawing.Size(62, 25);
            this.LName.TabIndex = 4;
            this.LName.Text = "Name:";
            // 
            // LSName
            // 
            this.LSName.Location = new System.Drawing.Point(318, 83);
            this.LSName.Name = "LSName";
            this.LSName.Size = new System.Drawing.Size(102, 25);
            this.LSName.TabIndex = 6;
            this.LSName.Text = "Second name:";
            // 
            // LBirthday
            // 
            this.LBirthday.Location = new System.Drawing.Point(318, 127);
            this.LBirthday.Name = "LBirthday";
            this.LBirthday.Size = new System.Drawing.Size(62, 25);
            this.LBirthday.TabIndex = 8;
            this.LBirthday.Text = "Birthday:";
            // 
            // LEmail
            // 
            this.LEmail.Location = new System.Drawing.Point(318, 168);
            this.LEmail.Name = "LEmail";
            this.LEmail.Size = new System.Drawing.Size(62, 25);
            this.LEmail.TabIndex = 10;
            this.LEmail.Text = "EMail:";
            // 
            // LWeb
            // 
            this.LWeb.Location = new System.Drawing.Point(318, 210);
            this.LWeb.Name = "LWeb";
            this.LWeb.Size = new System.Drawing.Size(62, 25);
            this.LWeb.TabIndex = 12;
            this.LWeb.Text = "Web site:";
            // 
            // LPNumber
            // 
            this.LPNumber.Location = new System.Drawing.Point(318, 249);
            this.LPNumber.Name = "LPNumber";
            this.LPNumber.Size = new System.Drawing.Size(86, 25);
            this.LPNumber.TabIndex = 14;
            this.LPNumber.Text = "Phone number:";
            // 
            // TBName
            // 
            this.TBName.Location = new System.Drawing.Point(410, 47);
            this.TBName.Name = "TBName";
            this.TBName.ReadOnly = true;
            this.TBName.Size = new System.Drawing.Size(378, 20);
            this.TBName.TabIndex = 17;
            // 
            // TBSName
            // 
            this.TBSName.Location = new System.Drawing.Point(410, 83);
            this.TBSName.Name = "TBSName";
            this.TBSName.ReadOnly = true;
            this.TBSName.Size = new System.Drawing.Size(378, 20);
            this.TBSName.TabIndex = 18;
            // 
            // TBEMail
            // 
            this.TBEMail.Location = new System.Drawing.Point(410, 165);
            this.TBEMail.Name = "TBEMail";
            this.TBEMail.ReadOnly = true;
            this.TBEMail.Size = new System.Drawing.Size(378, 20);
            this.TBEMail.TabIndex = 19;
            // 
            // TBWebSite
            // 
            this.TBWebSite.Location = new System.Drawing.Point(410, 207);
            this.TBWebSite.Name = "TBWebSite";
            this.TBWebSite.ReadOnly = true;
            this.TBWebSite.Size = new System.Drawing.Size(378, 20);
            this.TBWebSite.TabIndex = 20;
            // 
            // TBPhoneNum
            // 
            this.TBPhoneNum.Location = new System.Drawing.Point(410, 246);
            this.TBPhoneNum.Name = "TBPhoneNum";
            this.TBPhoneNum.ReadOnly = true;
            this.TBPhoneNum.Size = new System.Drawing.Size(378, 20);
            this.TBPhoneNum.TabIndex = 21;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(48, 393);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(54, 45);
            this.button1.TabIndex = 22;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(108, 393);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(54, 45);
            this.button2.TabIndex = 23;
            this.button2.Text = "Modify";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(168, 393);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(54, 45);
            this.button3.TabIndex = 24;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // TBDay
            // 
            this.TBDay.Location = new System.Drawing.Point(410, 124);
            this.TBDay.Name = "TBDay";
            this.TBDay.ReadOnly = true;
            this.TBDay.Size = new System.Drawing.Size(113, 20);
            this.TBDay.TabIndex = 25;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TBDay);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TBPhoneNum);
            this.Controls.Add(this.TBWebSite);
            this.Controls.Add(this.TBEMail);
            this.Controls.Add(this.TBSName);
            this.Controls.Add(this.TBName);
            this.Controls.Add(this.LPNumber);
            this.Controls.Add(this.LWeb);
            this.Controls.Add(this.LEmail);
            this.Controls.Add(this.LBirthday);
            this.Controls.Add(this.LSName);
            this.Controls.Add(this.LName);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Contact App";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label LName;
        private System.Windows.Forms.Label LSName;
        private System.Windows.Forms.Label LBirthday;
        private System.Windows.Forms.Label LEmail;
        private System.Windows.Forms.Label LWeb;
        private System.Windows.Forms.Label LPNumber;
        private System.Windows.Forms.TextBox TBName;
        private System.Windows.Forms.TextBox TBSName;
        private System.Windows.Forms.TextBox TBEMail;
        private System.Windows.Forms.TextBox TBWebSite;
        private System.Windows.Forms.TextBox TBPhoneNum;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.TextBox TBDay;
    }
}

