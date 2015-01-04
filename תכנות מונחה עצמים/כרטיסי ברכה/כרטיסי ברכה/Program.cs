using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace כרטיסי_ברכה
{
    class Program
    {
        static void Main(string[] args)
        {
            GreetingCard g = new GreetingCard("re", "se");
            //Console.WriteLine(g.toString());
            //g.SetRecipient("rec");
            //Console.WriteLine(g.toString());

            BirthdayCard b = new BirthdayCard("rer", "se", 8);
            //Console.WriteLine(b.toString());

            WeddingCard w = new WeddingCard("r", "e", "se");
            //Console.WriteLine(w.toString());
            //w.SetRecipient(
            //Console.WriteLine(g.toString());

            YouthBirthday yb = new YouthBirthday("rer", "se", 8);
            //Console.WriteLine(yb.toString());
            //Console.WriteLine("\n\n");
            AdultBirthday ab = new AdultBirthday("moshe", "se", 121);
            //Console.WriteLine(ab.toString());

            GreetingCard[] arr = new GreetingCard[5];
            arr[0] = g;
            arr[1] = w;
            arr[2] = b;
            arr[3] = yb;
            arr[4] = ab;

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i].toString());
                Console.WriteLine("-----------------------------\n");
            }

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i] is AdultBirthday)
            //    {
            //        AdultBirthday a = (AdultBirthday)arr[i];
            //        Console.WriteLine(a.toString());
            //        Console.WriteLine("----------------------");
            //    }
            //    else
            //    {
            //        if (arr[i] is YouthBirthday)
            //        {
            //            YouthBirthday a = (YouthBirthday)arr[i];
            //            Console.WriteLine(a.toString());
            //            Console.WriteLine("----------------------");
            //        }
            //        else
            //        {
            //            if (arr[i] is BirthdayCard)
            //            {
            //                BirthdayCard a = (BirthdayCard)arr[i];
            //                Console.WriteLine(a.toString());
            //                Console.WriteLine("----------------------");
            //            }
            //            else
            //            {
            //                if (arr[i] is WeddingCard)
            //                {
            //                    WeddingCard a = (WeddingCard)arr[i];
            //                    Console.WriteLine(a.toString());
            //                    Console.WriteLine("----------------------");
            //                }
            //                else
            //                {
            //                    Console.WriteLine(arr[i].toString());
            //                    Console.WriteLine("----------------------");
            //                }
            //            }
            //        }
            //    }
            //}

        }
    }
}
