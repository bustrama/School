using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyPerson2
{
    class Manager:Worker
    {
        private string level;

        public Manager()
        {

        }
        public Manager(string firstname, string lastname, Date age, int id, Job j, Degree d, State s, Date day, string sub)
            : base(firstname, lastname, age, id, j, d, s, day)
        {
            this.level = sub;
        }

        public new string toString()
        {
            return base.toString() + " level is " + this.level;
        }
    }
}
