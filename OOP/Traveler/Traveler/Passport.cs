using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Traveler
{
    class Passport
    {
        private string name;
        private int passportNumber;
        private Date expiryDate;

        public Passport(string name, int number, Date expiryDate)
        {
            this.name = name;
            this.passportNumber = number;
            this.expiryDate = expiryDate;
        }

        public Passport(Passport passport)
        {
            this.name = passport.name;
            this.passportNumber = passport.passportNumber;
            this.expiryDate = passport.expiryDate;
        }

        public string toString()
        {
            return "\n Name: " + this.name + "\n Pass. num: " + this.passportNumber + "\n Exp date: " + this.expiryDate;
        }

        public bool isValid(Date dateChecked)
        {
            if (this.expiryDate.getYear() > dateChecked.getYear() || this.expiryDate.getYear() == dateChecked.getYear())
            {
                if (this.expiryDate.getMonth() > dateChecked.getMonth() || this.expiryDate.getMonth() == dateChecked.getMonth())
                {
                    if (this.expiryDate.getDay() > dateChecked.getDay())
                        return true;
                    else
                        return false;
                }
                else
                    return false;
            }
            else
                return false;
        }

        public void setExpiryDate(Date newExpiryDate)
        {
            this.expiryDate = newExpiryDate;
        }

    }
}
