using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace school
{
    class Person
    {
        protected string firstName { get; set; }
        protected string lastName { get; set; }
        protected int age { get; set; }
        protected string id { get; set; }

        public Person(string first, string last, int age, string id)
        {
            this.firstName = first;
            this.lastName = last;
            this.age = age;
            this.id = id;
        }

        public void SetPerson(string first, string last, int age, string id)
        {
            this.firstName = first;
            this.lastName = last;
            this.age = age;
            this.id = id;
        }

        public override string ToString()
        {
            return "\n First Name: " + this.firstName + "\n Last Name: " + this.lastName + "\n Age: " + this.age + "\n ID: " + this.id;
        }
    }
}
