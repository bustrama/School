using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex34_P48
{
    abstract class Person
    {
        private string firstName;
        private string lastName;
        private int id;

        public Person()
        {
        }

        public Person(string first, string last, int id)
        {
            this.firstName = first;
            this.lastName = last;
            this.id = id;
        }

        public override string ToString()
        {
            return "\nName= " + this.firstName + " " + this.lastName + "\nId= " + this.id + this.Details();
        }

        protected abstract string Details();

        public string FirstName
        {
            get { return this.firstName; }
            set { this.firstName = value; }
        }
        public string LastName
        {
            get { return this.lastName; }
            set { this.lastName = value; }
        }
        public int ID
        {
            get { return this.id; }
        }
    }
}
