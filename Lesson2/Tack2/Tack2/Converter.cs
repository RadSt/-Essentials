using System;
using System.Security.Cryptography;

namespace Tack2
{
    public class Converter
    {
        private double usd, euro, ruble;
        public Converter(double usd,double euro,double ruble)
        {
            this.usd = usd;
            this.euro = euro;
            this.ruble = ruble;
        }
        public void ToUsd(double uahSum)
        {
            Console.WriteLine(uahSum * usd);
        }

        public void FromUsd(double usdSum)
        {
            Console.WriteLine(usdSum / usd);
        }
        public void ToEuro(double uahSum)
        {
            Console.WriteLine(uahSum*euro);
        }
        public void FromEuro(double euroSum)
        {
            Console.WriteLine(euroSum/euro);
        }
        public void ToRuble(double uahSum)
        {
            Console.WriteLine(uahSum*ruble);
        }
        public void FromRuble(double rubleSum)
        {
            Console.WriteLine(rubleSum/ruble);   
        }    
    }
}