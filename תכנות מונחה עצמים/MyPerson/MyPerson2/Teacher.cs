using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyPerson2
{
    class Teacher:Worker
    {
        private string subject;

        public Teacher()
        {
            this.subject = "";
        }

        public Teacher(string firstname, string lastname, Date age, int id, Job j, Degree d, State s, Date day, string sub)
            : base(firstname, lastname, age, id, j, d, s, day)
        {
            this.subject = sub;
        }

        public new string toString()
        {
            return base.toString() + " subject is " + this.subject;
        }







    }
}
