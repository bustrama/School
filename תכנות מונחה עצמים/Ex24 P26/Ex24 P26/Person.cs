using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex24_P26
{
    class Person
    {
        private string firstname;
        private string lastname;
        private int age;
        private int id;

        public Person()
        {
        }
        public Person(string firstname, string lastname, int age, int id)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.age = age;
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
        public int GetAge()
        {
            return this.age;
        }
        public void SetAge(int value)
        {
            this.age = value;
        }
        public int GetID()
        {
            return this.id;
        }
        public void SetID(int value)
        {
            this.id = value;
        }

        public void SetPerson(string firstname, string lastname, int age, int id)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.age = age;
            this.id = id;
        }       

        //public string PrintPerson()
        //{
        //    return "firstname is " + this.firstname + ", lastname is " + this.lastname + ", age is " + this.age + ", id is " + id;
        //}

        //public string toString()
        //{
        //    return "firstname is " + this.firstname + ", lastname is " + this.lastname + ", age is " + this.age + ", id is " + id;
        //}
        public virtual string toString()
        {
            return "firstname is " + this.firstname + ", lastname is " + this.lastname + ", age is " + this.age + ", id is " + id;
        }

    }
}
