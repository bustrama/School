using System;
using System.Collections.Generic;
using System.Text;

namespace student__p13_ex12_1
{
    class Date
    {
        private int year;
        private int month;
        private int day;
        
        //брайн
        public Date()
        {
            this.year = 0;
            this.month = 0;
            this.day = 0;
        }
        
        public Date(Date someday)
        {
            this.year = someday.year;
            this.month = someday.month;
            this.day = someday.day;
        }
        
        public Date(int newyear,int newmonth, int newday )
        {
            this.year = newyear;
            this.month = newmonth;
            this.day = newday;
        }
        
        //Gets&&Sets
        public void Set_year(int year)
        {
            if (year < 2013)
                this.year = year;
            else
                this.year = -1;            
                
        }
        public void Set_month(int month)
        {
            if (month > 0 && month < 13)
                this.month = month;
            else
                this.month = -1;
        
        }
        public void Set_day(int day)
        {
            if (day > 0 && day < 32)
                this.day = day;
            else
                this.day = -1;
        }
        public int Get_year()
        {
            return this.year;
        }
        public int Get_month()
        {
            return this.month;
        }
        public int Get_day()
        {
            return this.day;
        }
        public void Print()
        {
            Console.WriteLine(this.day + "." + this.month + "." + this.year);  
        }
        
        public bool Before(Date newday)
        {
            if (this.year < newday.Get_year())
            {
                return true;
            }
            else
            {
                if (this.month < newday.Get_month())
                {
                    return true;
                }
                else
                {
                    if (this.day < newday.Get_day())
                    {
                        return true;
                    }
                }
            }
            return false;

        }

    }
}
