using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ספר_טלפונים
{
    class Entry
    {
        //datamembers
        private string firstname;
        private string lastname;
        private string phonenumber;

        //בנאים
        public Entry()
        {
            this.firstname = null;
            this.lastname = null;
            this.phonenumber = null;
        }
        public Entry(string Firstname, string Lastname, string Phonenumber)
        {
            this.firstname = Firstname;
            this.lastname = Lastname;
            this.phonenumber = Phonenumber;
        }
        public Entry(Entry otherEntry)
        {
            this.firstname = otherEntry.firstname;
            this.lastname = otherEntry.lastname;
            this.phonenumber = otherEntry.phonenumber;
        }        

        //Gets&Sets
        public string GetFirstName()
        {
            return this.firstname;
        }
        public void SetFirstName(string value)
        {
            this.firstname = value;
        }
        public string GetLastName()
        {
            return this.lastname;
        }
        public void SetLastName(string value)
        {
            this.lastname = value;
        }
        public string GetPhoneNumber()
        {
            return this.phonenumber;
        }
        public void SetPhoneNumber(string value)
        {
            this.phonenumber = value;
        }

        //עבור שני אובייקטים בעלי אותו שם פרטי ומשפחה מחדיר אמת
        public bool Equals(Entry otherEntry)
        {
            if (otherEntry!=null)
                return this.firstname.Equals(otherEntry.firstname) && this.lastname.Equals(otherEntry.lastname);
            return false;

            //if (this.firstname == otherEntry.firstname && this.lastname == otherEntry.lastname)
            //{
            //    return true;
            //}
            //return false;
        }

        //מדפיס
        public string toString()
        {
            string st = "";
            if (this.firstname == null)
            {
                st += "first name: < - >";
            }
            else
            {
                st += "first name: <"+this.firstname+">";
            }
            if (this.lastname == null)
            {
                st += "\nlast name: < - >";
            }
            else
            {
                st += "\nlast name: <" + this.lastname + ">";
            }
            if (this.phonenumber == null)
            {
                st += "\nphone number: < - >";
            }
            else
            {
                st += "\nphone number: <" + this.phonenumber + ">";
            }
            return st;
        }
    }
}
