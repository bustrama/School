using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Traveler
{
    class Traveler
    {
        Passport travelerPassport;
        bool _isPayed;

        public Traveler(Passport passport, bool isPayed)
        {
            this.travelerPassport = passport;
            this._isPayed = isPayed;
        }

        public void pay()
        {
            this._isPayed = true;
        }

        public bool isPayed()
        {
            if (this._isPayed == true)
                return true;
            else
                return false;
        }

        public bool checkTravel(Date travelDate)
        {
            if (travelerPassport.isValid(travelDate) == true)
            {
                if (isPayed() == true)
                    return true;
                else
                    return false;
            }
            else
                return false;
        }

        public string toString()
        {
            return this.travelerPassport.toString();
        }
    }
}
