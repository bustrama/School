using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace כרטיסי_ברכה
{
    class YouthBirthday:BirthdayCard
    {
        public YouthBirthday(string r, string s, int a)
            : base(r, s, a)
        {
        }

        //protected new string GreetingMsg()
        //{
        //    return base.GreetingMsg()+"\nHow you have grown!";
        //}
        protected override string GreetingMsg()
        {
            return base.GreetingMsg() + "\nHow you have grown!";
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
