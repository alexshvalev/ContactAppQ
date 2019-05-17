using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ContactApp
{
    public class Contact
    {
        public String Name, SName, Number, Mail, WebS;
        public DateTime birthday;
        public Contact(String Name, String SName, String Number, int Day, int Month, int Year, String Mail, String WebS)
        {
            this.Name = Name;
            this.SName = SName;
            this.Number = Number;
            this.birthday = new DateTime(Year, Month, Day);
            this.Mail = Mail;
            this.WebS = WebS;
        }
        public Contact(Contact contact)
        {
            this.Name = contact.Name;
            this.SName = contact.SName;
            this.birthday = contact.birthday;
            this.Mail = contact.Mail;
            this.WebS = contact.WebS;
            this.Number = contact.Number;
        }
        public Contact()
        {
            this.Name = "";
            this.SName = "";
            this.Number = "";
            this.birthday = new DateTime(1970, 1, 1);
            this.Mail = "";
            this.WebS = "";
        }
    }
    public class CBook
    {
        private List<Contact> contacts = new List<Contact>();

        public void AddContact(String Name, String SName, String Number, int Day, int Month, int Year, String Mail, String WebS)
        {
            Contact temp = new Contact(Name, SName, Number, Day, Month, Year, Mail, WebS);
            this.contacts.Add(temp);
        }
        public void AddContact()
        {
            Contact Temp = new Contact();
            this.contacts.Add(Temp);
        }

        public void AddContact(Contact contact)
        {
            Contact newCont = new Contact(contact);
            this.contacts.Add(newCont);
        }

        public Contact this[int index]
        {
            get
            {
                return this.contacts[index];
            }

            set
            {
                this.contacts[index] = value;
            }
        }

        public int Count()
        {
            return this.contacts.Count;
        }

        public void DeleteContact(int index)
        {
            this.contacts.RemoveAt(index);
        }
        public void WriteContactsToFile(String Filename)
        {
            StreamWriter fOut = File.CreateText(Filename);
            foreach (Contact contact in this.contacts)
            {
                fOut.WriteLine(contact.Name);
                fOut.WriteLine(contact.SName);
                fOut.WriteLine(contact.Mail);
                fOut.WriteLine(contact.WebS);
                fOut.WriteLine(contact.birthday.Day);
                fOut.WriteLine(contact.birthday.Month);
                fOut.WriteLine(contact.birthday.Year);
                fOut.WriteLine(contact.Number);
            }
            fOut.Close();
        }
        public void GetContactsFromFile(String Filename)
        {
            StreamReader fIn = File.OpenText(Filename);
            while (!fIn.EndOfStream)
            {
                Contact temp = new Contact();
                temp.Name = fIn.ReadLine();
                temp.SName = fIn.ReadLine();
                temp.Mail = fIn.ReadLine();
                temp.WebS = fIn.ReadLine();
                int day, month, year;
                day = Convert.ToInt32(fIn.ReadLine());
                month = Convert.ToInt32(fIn.ReadLine());
                year = Convert.ToInt32(fIn.ReadLine());
                temp.birthday = new DateTime(year, month, day);
                temp.Number = fIn.ReadLine();
                this.contacts.Add(temp);
            }
            fIn.Close();
        }
    }
}
