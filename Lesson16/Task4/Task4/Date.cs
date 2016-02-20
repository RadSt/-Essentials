using System;
using System.CodeDom;
using System.Runtime.Remoting.Metadata.W3cXsd2001;

namespace Task4
{
    public class Date
    {
        private int day, month,year;

        public Date(DateTime dat)
        {
            this.day = dat.Day;
            this.month = dat.Month;
            this.year = dat.Year;
        }

        public int Day { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }

        public static int operator -(DateTime dat1, DateTime dat2)
        {
            
        }
    }
}