using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace כרטיסי_ברכה
{
    class AdultBirthday:BirthdayCard
    {
        public AdultBirthday(string r, string s, int a)
            : base(r, s, a)
        {
        }

        //protected new string GreetingMsg()
        //{
        //    return base.GreetingMsg()+"\nYou haven't changes at all!";
        //}
        protected override string GreetingMsg()
        {
            return base.GreetingMsg() + "\nYou haven't changes at all!";
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
