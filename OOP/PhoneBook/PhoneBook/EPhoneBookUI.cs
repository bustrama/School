using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PhoneBook
{
    class EPhoneBookUI
    {
        private static PhoneBook book = new PhoneBook(5);

        public static void Main(string[] args)
        {
            bool quit = false;
            string firstName, lastName, phoneNumber;
            book.addEntry(new Entry("AA", "BB", "11"));
            book.addEntry(new Entry("BB", "CC", "22"));
            book.addEntry(new Entry("CC", "DD", "33"));

            while(!quit)
            {
                Console.WriteLine("\n Your Electronic Phone Book");
                Console.WriteLine("\n Please choose an operation code from menu: ");
                Console.WriteLine("\n 1.\t Add an Entry \n 2.\t Delete an Entry \n 3.\t Find an Entry \n 4.\t Print PhoneBook \n 5.\t Quit \n");
                Console.Write("Please select an operation code: ");
                int operation = int.Parse(Console.ReadLine());

                switch(operation)
                {
                    case 1: 
                        Console.Write("First Name: ");
                        firstName = Console.ReadLine();
                        Console.Write("Last Name: ");
                        lastName = Console.ReadLine();
                        Console.Write("Phone Number: ");
                        phoneNumber = Console.ReadLine();
                        Console.WriteLine(book.addEntry(new Entry(firstName, lastName, phoneNumber)));
                        break;
                    case 2:
                        Console.Write("First Name: ");
                        firstName = Console.ReadLine();
                        Console.Write("Last Name: ");
                        lastName = Console.ReadLine();
                        Console.Write("Phone Number: ");
                        phoneNumber = Console.ReadLine();
                        Console.WriteLine(book.deleteEntry(new Entry(firstName, lastName, phoneNumber)));
                        break;
                    case 3:
                        Console.Write("First Name: ");
                        firstName = Console.ReadLine();
                        Console.Write("Last Name: ");
                        lastName = Console.ReadLine();
                        Console.WriteLine(book.searchPhone(firstName, lastName));
                        break;
                    case 4:
                        Console.WriteLine(book.ToString());
                        break;
                    case 5:
                        quit = true;
                        break;
                    default:
                        Console.WriteLine("Illegal operation code (Error=ex404).");
                        break;
                }
            }
        }
    }
}
