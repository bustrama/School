using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        public static Date BiggerDate(Date D1, Date D2)
        {
            if (D1.Get_year() < D2.Get_year())
            {
                return D1;
            }
            else
                if (D1.Get_year() > D2.Get_year())
                {
                    return D2;
                }
                else
                    if (D1.Get_month() < D2.Get_month())
                    {
                        return D1;
                    }
                    else
                        if (D1.Get_month() > D2.Get_month())
                        {
                            return D2;
                        }
                        else
                            if (D1.Get_day() < D2.Get_day())
                            {
                                return D1;
                            }
                            else

                                    return D2;
                                
                   
        }
        static void Main(string[] args)
        {
            Date now = new Date(2013, 10, 16);
            Date notnow = new Date(now);
            notnow.Set_day(6);
            now.print();
            notnow.print();


            //Date D1;
            //D1 = new Date();
            //D1.Set_year(2111);
            //D1.Set_month(0);
            //D1.Set_day(133);
            //Date D2;
            //D2 = new Date();
            //D2.Set_year(100);
            //D2.Set_month(5);
            //D2.Set_day(20);
            //Date bigeer = BiggerDate(D1, D2);
            //bigeer.print();
            //D1.print();
            //D2.print();
            //bool bigy = D1.boolbig(D2);
            //Console.WriteLine(bigy);

           


            
            
            
           

                

            
        }
    }
} 
