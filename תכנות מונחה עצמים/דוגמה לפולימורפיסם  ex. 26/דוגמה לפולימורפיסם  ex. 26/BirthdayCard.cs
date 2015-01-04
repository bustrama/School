using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace דוגמה_לפולימורפיסם__ex._26
{
    class BirthdayCard:GreetingCard
    {
        protected int age;
        public BirthdayCard(string s, string r, int a)
            : base(s, r)
        {
            this.age = a;
        }

        protected new string GreetingMsg()
        {
            return "Happy "+this.age+"th Birthday!! :)";
        }

        public new string toString()
        {
            return "Dear " + this.recipient + "\n" + this.GreetingMsg() + "\n" + this.sender;
        }
    }
}
