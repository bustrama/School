using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ספר_טלפונים
{
    class PhoneBook
    {
        private Entry[] entries;
        private int count;

        //בנאי הבונה ספר טלפונים בגודל נתון
        public PhoneBook(int size)
        {
            entries = new Entry[size];
            count = 0;
        }

        //Gets&Sets
        //public Entry[] GetEntries()
        //{
        //    return this.entries;
        //}
        //public void SetEntries(Entry[] value)
        //{
        //    this.entries = value;
        //}
        public int GetCount()
        {
            return this.count;
        }

        //מכניסה רשומה לספר הטלפונים ומכניס אמת אם הוכנסה 
        public bool Add(Entry en)
        {
            for (int i = 0; i < this.entries.Length; i++)
            {
                if (this.entries[i] == null)
                {
                    this.entries[i] = en;
                    count++;
                    return true;
                }
                else
                {
                    if (en.Equals(this.entries[i]))
                    {
                        this.entries[i] = new Entry(en);
                        count++;
                        return true;
                    }
                }

            }
            return false; 
        }        

        //מוחק רשומה ומחזיר אמת אם נמחקה
        public bool Delete(Entry en)
        {
            bool check = false;
            for (int i = 0; i < this.entries.Length; i++)
            {
                if (en.Equals(this.entries[i])&&this.entries[i]!=null)
                {
                    this.entries[i] = null;
                    check = true;
                    count--;
                    for (int j = i; j < this.entries.Length - 1; j++)
                    {
                        this.entries[j] = this.entries[j + 1];
                    }
                    this.entries[this.entries.Length-1] = null;
                    //this.entries[i - 1].SetFirstName(" ");
                    //this.entries[i - 1].SetLastName(" ");
                    //this.entries[i - 1].SetPhoneNumber(" ");
                }
            }
            return check;
        }

        //מוצאת מספר טלפון לפי שם פרטי ומשפחה
        public string SearchPhone(string firstName, string lastName)
        {
            for (int i = 0; i < this.entries.Length; i++)
            {
                if ((this.entries[i].GetFirstName() == firstName) && (this.entries[i].GetLastName() == lastName))
                {
                    return this.entries[i].GetPhoneNumber();
                }
            }
            return null;
        }

        //מדפיסה את ספר הטלפונים
        public string toString()
        {
            string st = "";
            for (int i = 0; i < this.entries.Length; i++)
            {
                if (this.entries[i] == null)
                {
                    st += "Entry" + i + ":\nfirst name: <empty>\nlast name: <empty>\nphone number: <empty>";
                }
                else
                {
                    st += "Entry" + i + ":\n" + this.entries[i].toString() + "\n";
                }
            }
            return st;
        }

        
    }
}
