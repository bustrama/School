using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ספר_טלפונים
{
    class Program
    {
        static void Main(string[] args)
        {
            //Entry en = new Entry("yuval", "geva", "0544472887");
            //Console.WriteLine(en.toString());
            //Entry en2 = new Entry();
            //en2.SetFirstName("yuval");
            //en2.SetLastName("geva");
            //en2.SetPhoneNumber("kjlg");
            //Console.WriteLine(en2.toString());
            //Console.WriteLine(en.Equals(en2));
            
            string firstname, lastname, phonenumber;
            bool quit = false;
            PhoneBook pb = new PhoneBook(3);
            pb.Add(new Entry("yuval", "geva", "0123456789"));
            pb.Add(new Entry("Noga", "Klein", "1234567890"));
            pb.Add(new Entry("Dan", "Lapid", "2345678901"));
            while (!quit)
            {
                Console.WriteLine("Your Electronic Phone Book");
                Console.WriteLine("Please choose an operation code from menu:\n");
                Console.WriteLine("______________________________________________");
                Console.WriteLine(" Press 1 : Add an entry  ");
                Console.WriteLine(" Press 2 : Delete an entry");
                Console.WriteLine(" Press 3 : Find an entry");
                Console.WriteLine(" Press 4 : Print Phone Book");
                Console.WriteLine(" Press 5 : Quit");
                Console.WriteLine("_______________________________________________\n");
                Console.WriteLine("Please select the operation code:");
                int operation = int.Parse(Console.ReadLine());
                Console.WriteLine("_______________________________________________\n");
                switch (operation)
                {
                    case 1:
                        Console.Write("enter first name: ");
                        firstname = Console.ReadLine();
                        Console.Write("\nenter last name: ");
                        lastname = Console.ReadLine();
                        Console.Write("\nenter phone number: ");
                        phonenumber = Console.ReadLine();
                        if (pb.Add(new Entry(firstname, lastname, phonenumber)))
                        {
                            Console.WriteLine("Enter Succeed");
                        }
                        else
                        {
                            Console.WriteLine("Enter Failed");
                        }
                        Console.WriteLine();
                        break;
                    case 2:
                        Console.Write("enter first name: ");
                        firstname = Console.ReadLine();
                        Console.Write("\nenter last name: ");
                        lastname = Console.ReadLine();
                        if (pb.Delete(new Entry(firstname, lastname, "0")))
                        {
                            Console.WriteLine("Delete Succeed");
                        }
                        else
                        {
                            Console.WriteLine("Delete Failed");
                        }
                        Console.WriteLine();
                        break;
                    case 3:
                        Console.Write("enter first name: ");
                        firstname = Console.ReadLine();
                        Console.Write("\nenter last name: ");
                        lastname = Console.ReadLine();
                        string phone=pb.SearchPhone(firstname, lastname);
                        if (phone != null)
                        {
                            Console.WriteLine("The phone number is: " + phone);
                        }
                        else
                        {
                            Console.WriteLine("Search Failed. Maybe you spelled in wrongly");
                        }
                        Console.WriteLine();
                        break;
                    case 4:
                        Console.WriteLine(pb.toString());
                        break;
                    case 5: quit = true; break;
                    default: Console.WriteLine("Illegal operation code"); break;
                }
                Console.WriteLine("_______________________________________________\n\n");
            }





        }
    }
}
