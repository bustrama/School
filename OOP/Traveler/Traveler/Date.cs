using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Traveler
{
    class Date
    {
        private int day, month, year; //שנה, חודש, יום

        public Date()
        { }//בנאי ריק

        public Date(Date date)
        {
            this.day = date.getDay();
            this.month = date.getMonth();
            this.year = date.getYear();
        }//שיטה בונה מעתיקה

        public Date(int dateDay, int dateMonth, int dateYear)
        {
            this.day = dateDay;
            this.month = dateMonth;
            this.year = dateYear;
        }// בנאי עם פרמטרים
        
        //day
        public void setDay(int dateDay)
        {
            if (dateDay < 1 || dateDay > 31)
            {
                this.day = 0;
            }
            else
                this.day = dateDay;
        }

        public int getDay()
        {
            return this.day;
        }

        //month
        public void setMonth(int dateMonth)
        {
            if (dateMonth < 1 || dateMonth > 12)
            {
                this.month = 0;
            }
            else
                this.month = dateMonth;
        }

        public int getMonth()
        {
            return this.month;
        }

        //year
        public void setYear(int dateYear)
        {
            if (dateYear < 1 || dateYear > 2014)
            {
                this.year = 0;
            }
            else
                this.year = dateYear;
        }

        public int getYear()
        {
            return this.year;
        }

        //Check if this date was before some other date
        public bool Before(Date other)
        {
            bool flag = false;
            if (this.year < other.getYear())
                flag = true;

            else if (this.month < other.getMonth() && this.year == other.getYear())
                flag = true;

            else if (this.day < other.getDay() && this.month == other.getMonth() && this.year == other.getYear())
                flag = true;


            return flag;
        }

        //Writes to user the date
        public string toString()
        {
            return this.day + "." + this.month + "." + this.year;
        }
    }
}
