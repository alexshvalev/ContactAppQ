using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactApp
{
    public partial class Form2 : Form
    {
        private Contact curCont;
        private Operation operation;
        private Form1 form1;
        private int curIndex;
        public Form2(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.form1.Enabled = true;
            this.Hide();
        }

        public void Modify(Contact cont, Operation operation, int index, String title)
        {
            if (operation == Operation.modify)
            {
                this.TBName.Text = cont.Name;
                this.TBSName.Text = cont.SName;
                this.DBirthday.Value = cont.birthday;
                this.TBEMail.Text = cont.Mail;
                this.TBWebS.Text = cont.WebS;
                this.TBPhoneNum.Text = cont.Number;
            }
            else
            {
                this.TBName.Text = "";
                this.TBSName.Text = "";
                this.DBirthday.Value = new DateTime(1970,1,1);
                this.TBEMail.Text = "";
                this.TBWebS.Text = "";
                this.TBPhoneNum.Text = "";
            }

            this.curIndex = index;
            this.Text = title;
            this.curCont = cont;
            this.operation = operation;
            this.Show();
        }

        private void Button2_Click(object sender, EventArgs e)
        {   
            this.form1.ModifyEnd(this.curCont, this.operation, false, this.curIndex);
            this.Hide();
        }

        public bool Checkinput()
        {
            return true;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (!this.Checkinput())
                return;
            this.curCont.Name = this.TBName.Text;
            this.curCont.SName = this.TBSName.Text;
            this.curCont.birthday = this.DBirthday.Value;
            this.curCont.Mail = this.TBEMail.Text;
            this.curCont.Number = this.TBPhoneNum.Text;
            this.curCont.WebS = this.TBWebS.Text;
            this.form1.ModifyEnd(this.curCont, this.operation, true, this.curIndex);
            this.Hide();
        }
    }
}
