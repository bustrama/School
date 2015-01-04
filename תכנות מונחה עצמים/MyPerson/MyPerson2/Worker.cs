using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyPerson2
{
    protected enum Degree { MA, BA, DR };
    protected enum State { temporary, permanantly };
    protected enum Job { teacher, manager };

    class Worker : Person
    {
        protected Job job;
        protected State state;
        protected Degree degree;
        protected Date startDate;

        public Worker()
        {
            this.job = Job.teacher;
            this.state = State.permanantly;
            this.degree = Degree.MA;
            this.startDate = new Date();
        }
        public Worker(string firstname, string lastname, Date age, int id, Job j, Degree d, State s, Date day)
            : base(firstname, lastname, age, id)
        {
            this.job = j;
            this.state = s;
            this.degree = d;
            this.startDate = new Date(day);
        }


        public new string toString()
        {
            return base.toString() + "job is " + this.job + ", degree is " + this.degree + ", state is " + this.state + ", starting date is " + this.startDate;
        }
    }
}
