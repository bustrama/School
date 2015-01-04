using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace כרטיסי_ברכה
{
    class WeddingCard:GreetingCard
    {  

        public WeddingCard(string b, string g, string s)
            : base(b + "&" + g, s)
        {
        }

        public void SetResipient(string b, string g)
        {
            SetRecipient(b + "&" + g);
        }

        //protected new string GreetingMsg()
        //{
        //    return "May you live happily ever after";
        //}
        protected override string GreetingMsg()
        {
            return "May you live happily ever after";
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
