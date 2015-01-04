using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace דוגמה_לפולימורפיסם__ex._26
{
    class GreetingCard
    {
        protected string sender;
        protected string recipient;

        public GreetingCard(string s)
        {
            this.sender = s;
        }
        public GreetingCard(string s, string r)
        {
            this.sender = s;
            this.recipient = r;
        }

        //מקבלת שם לנמען
        //מעדכנת אותו
        public void SetRecipient(string r)
        {
            this.recipient = r;
        }

        //מחזירה איחול ברכה
        protected string GreetingMsg()
        {
            return "Best Greeting!! :)";
        }

        //מחזירה ברכה כולל שמות האנשים
        public string toString()
        {
            return "Dear " + this.recipient + "\n" + this.GreetingMsg() + "\n" + this.sender;
        }

    }
}

