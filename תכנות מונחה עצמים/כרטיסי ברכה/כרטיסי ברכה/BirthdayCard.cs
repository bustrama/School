using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace כרטיסי_ברכה
{
    class BirthdayCard:GreetingCard
    {
        protected int age;

        public BirthdayCard(string r, string s, int a)
            : base(r, s)
        {
            this.age = a;
        }

        //protected new string GreetingMsg()
        //{
        //    return "Happy " + this.age + "th birthday!!";
        //}
        protected override string GreetingMsg()
        {
            return "Happy " + this.age + "th birthday!!";
        }

        //public new string toString()
        //{
        //    return "Dear " + this.recipient + "\n" + this.GreetingMsg() + "\n" + this.sender;
        //}
        public override string toString()
        {
            return "Dear " + this.recipient + "\n" + this.GreetingMsg() + "\n" + this.sender;
        }
    }
}
