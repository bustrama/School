using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PhoneBook
{
    class Entry
    {
        private string firstName, lastName, phoneNumber;

        public Entry()
        {

        }

        public Entry(Entry otherEntry)
        {
            this.firstName = otherEntry.getFirstName();
            this.lastName = otherEntry.getLastName();
            this.phoneNumber = otherEntry.getPhoneNumber();
        }

        public Entry(string firstName, string lastName, string phoneNumber)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.phoneNumber = phoneNumber;
        }

        public void setFirstName(string FirstName)
        {
            this.firstName = FirstName;
        }

        public string getFirstName()
        {
            return this.firstName;
        }

        public void setLastName(string LastName)
        {
            this.lastName = LastName;
        }

        public string getLastName()
        {
            return this.lastName;
        }

        public void setPhoneNumber(string PhoneNumber)
        {
            this.phoneNumber = PhoneNumber;
        }

        public string getPhoneNumber()
        {
            return this.phoneNumber;
        }

        public bool equals(Entry otherEntry)
        {
            if (this.firstName.Equals(otherEntry.getFirstName()) && this.lastName.Equals(otherEntry.getLastName()))
                return true;
            else
                return false;
        }

        public override string ToString()
        {
            return "\n First Name: " + this.firstName + "\n Last Name: " + this.lastName + "\n Phone Number: " + this.phoneNumber;
        }
    }
}
