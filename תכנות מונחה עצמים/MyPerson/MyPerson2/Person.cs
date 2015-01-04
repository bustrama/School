using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyPerson2
{
    class Person
    {
        protected string firstname;
        protected string lastname;
        protected Date birthday;
        //private int age;
        protected int id;

        public Person()
        {
            this.birthday = new Date();
        }
        public Person(string firstname, string lastname, Date date, int id)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.birthday = new Date(date);
            this.id = id;
        }

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
        public Date GetDate()
        {
            return this.birthday;
        }
        public void SetAge(Date value)
        {
            this.birthday = value;
        }
        public int GetID()
        {
            return this.id;
        }
        public void SetID(int value)
        {
            this.id = value;
        }

        public void SetPerson(string firstname, string lastname, Date b, int id)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.birthday = b;
            this.id = id;
        }

        //public string PrintPerson()
        //{
        //    return "firstname is " + this.firstname + ", lastname is " + this.lastname + ", age is " + this.age + ", id is " + id;
        //}

        public string toString()
        {
            return "firstname is " + this.firstname + ", lastname is " + this.lastname + ", birthday is " + this.birthday + ", id is " + id;
        }

    }
}
