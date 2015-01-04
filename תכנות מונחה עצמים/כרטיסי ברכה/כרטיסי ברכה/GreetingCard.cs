using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace כרטיסי_ברכה
{
    class GreetingCard
    {
        protected string recipient;
        protected string sender;

        public GreetingCard(string r, string s)
        {
            this.recipient = r;
            this.sender = s;
        }

        public void SetRecipient(string r)
        {
            this.recipient = r;
        }

        //protected string GreetingMsg()
        //{
        //    return "Best Greetings!!";
        //}
        protected virtual string GreetingMsg()
        {
            return "Best Greetings!!";
        }

        //public string toString()
        //{
        //    return "Dear " + this.recipient + "\n" + this.GreetingMsg() + "\n" + this.sender;
        //}
        public virtual string toString()
        {
            return "Dear " + this.recipient + "\n" + this.GreetingMsg() + "\n" + this.sender;
        }
    }
}
