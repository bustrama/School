using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace studets
{
    class student
    {
        private string fn;
        private string ln;
        private string id;
        private string classroom;

        public void setFN(string value)
        {
            this.fn = value;
        }
        public string GetFN()
        {
            return this.fn; 
        }

        public void setLN(string value)
        {
            this.ln = value;
        }
        public string GetLN()
        {
            return this.ln;
        }

        public void setID(string value)
        {
            this.id = value;
        }
        public string GetID()
        {
            return this.id;
        }

        public void setCR(string value)
        {
            this.classroom = value;
        }
        public string GetCR()
        {
            return this.classroom;
        }
    }
}
