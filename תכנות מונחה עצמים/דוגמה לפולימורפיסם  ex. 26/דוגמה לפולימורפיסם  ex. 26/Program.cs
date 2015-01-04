using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace דוגמה_לפולימורפיסם__ex._26
{
    class Program
    {
        static void Main(string[] args)
        {
            //GreetingCard g = new GreetingCard("yuval", "yoav");
            //Console.WriteLine(g.toString());
            //g.SetRecipient("yael");
            //Console.WriteLine(g.toString());

            //BirthdayCard b = new BirthdayCard("yuval", "moses rabenu", 120);
            //Console.WriteLine(b.toString());
            //b.SetRecipient("holly moses");
            //Console.WriteLine(b.toString());

            WeddingCard w = new WeddingCard("yuval", "ima", "aba");
            Console.WriteLine(w.toString());

            w.SetRecipient("s", "d");
            Console.WriteLine(w.toString());
        }
    }
}
