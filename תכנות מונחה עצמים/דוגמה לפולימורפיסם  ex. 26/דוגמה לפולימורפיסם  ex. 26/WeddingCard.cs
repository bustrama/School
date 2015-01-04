using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace דוגמה_לפולימורפיסם__ex._26
{
    class WeddingCard:GreetingCard
    {
        private string bride;
        private string groom;

        public WeddingCard(string s, string b, string g)
            : base(s, b + "&" + g)
        {
            this.bride = b;
            this.groom = g;
            //SetRecipient(this.bride, this.groom);

        }

        //מקבלת שם לנמען
        //מעדכנת אותו
        public void SetRecipient(string b, string g)
        {   

            //this.recipient = this.bride + "&" + this.groom; 
            //SetRecipient(this.bride + "&" + this.groom);
        }

        //
        private new string GreetingMsg()
        {
            return "May you live happily ever after";
        }

        public new string toString()
        {
            return "Dear " + this.recipient + "\n" + this.GreetingMsg() + "\n" + this.sender;
        }
    }
}
