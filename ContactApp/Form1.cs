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
    public enum Operation
    {
        modify = 0,
        add = 1
    }
    public partial class Form1 : Form
    {
        private Form2 form2; 
        private CBook cbook;
        private HashTable HTable;
        public Form1()
        {
            InitializeComponent();
            this.form2 = new Form2(this);
            this.cbook = new CBook();
            this.HTable = new HashTable();

            this.cbook.GetContactsFromFile("contacts.dat");

            this.textBox1.Text = "";
            
            this.ResetGUI(this.textBox1.Text);
        }

        public void ResetGUI(string strFilter)
        {
            this.listBox1.Items.Clear();
            this.HTable.Clear();
            this.HTable.Get(strFilter, ref this.cbook);
            if (this.HTable.Count() == 0)
                return;
            for (int i = 0; i < this.HTable.Count(); i++)
            {
                Contact temp = this.HTable.GetContact(i, ref this.cbook);
                this.listBox1.Items.Add(temp.SName + " " + temp.Name);
            }
            this.listBox1.SetSelected(0, true);
            this.SetScreenFields(this.HTable.GetContact(0, ref this.cbook));
        }

        public void SetScreenFields(Contact info)
        {
            this.TBName.Text = info.Name;
            this.TBSName.Text = info.SName;
            this.TBDay.Text = info.birthday.ToString("dd.MM.yyyy");
            this.TBEMail.Text = info.Mail;
            this.TBWebSite.Text = info.WebS;
            this.TBPhoneNum.Text = info.Number;
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = this.listBox1.SelectedIndex;
            if(index >= 0)
                this.SetScreenFields(this.HTable.GetContact(index, ref this.cbook));
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.cbook.WriteContactsToFile("contacts.dat");
        }

        public void ModifyEnd(Contact contact, Operation operation, bool result, int index)
        {
            this.Enabled = true;
            switch(operation)
            {
                case Operation.add:
                    if (result)
                    {
                        this.cbook.AddContact(contact);
                    }
                    break;
                case Operation.modify:
                    if(result)
                    {
                        this.cbook[this.HTable[index].iIndex] = contact;
                    }
                    break;
            }
            this.ResetGUI(this.textBox1.Text);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int index = this.listBox1.SelectedIndex;
            if (index < 0)
                if (this.HTable.Count() == 0)
                    index = 0;
                else
                    return;
            Contact contact = new Contact();
            this.form2.Modify(contact, Operation.add, index, "Add contact");
            this.Enabled = false;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            int index = this.listBox1.SelectedIndex;
            if (index < 0)
                return;
            Contact contact = new Contact(this.HTable.GetContact(index, ref this.cbook));
            this.form2.Modify(contact, Operation.modify, index, "Modify contact");
            this.Enabled = false;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            int index = this.listBox1.SelectedIndex;
            if (index < 0)
                return;
            this.cbook.DeleteContact(this.HTable[index].iIndex);
            this.ResetGUI(this.textBox1.Text);
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            this.ResetGUI(this.textBox1.Text);
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Программа была созданна в рамках курсовой работы по предмету \"НТВП\" студентом группы 585-2 Александром Швалевым.\nТомск 2019г. ТУСУР.", "About");
        }
    }
}
