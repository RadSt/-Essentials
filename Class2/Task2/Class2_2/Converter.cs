using System;

namespace Class2_2
{
    public class Converter
    {
        private double usdCource;
        private double euroCource;
        private double grivnaCource;

        public Converter(double usdCource, double euroCource, double grivnaCource)
        {
            this.usdCource = usdCource;
            this.euroCource = euroCource;
            this.grivnaCource = grivnaCource;
        }

        public void RubToUsd(double rubSum)
        {
            Console.WriteLine("From RubToUSD: {0}", rubSum/usdCource);
        }
        public void UsdToRub(double usdSum)
        {
            Console.WriteLine("From UsdToRub: {0}", usdSum*usdCource);
        }
        public void RubToEuro(double rubSum)
        {
            Console.WriteLine("From RubToEuro: {0}", rubSum/euroCource);
        }
        public void EuroToRub(double euroSum)
        {
            Console.WriteLine("From EuroToRub: {0}",euroSum*euroCource);
        }
        public void RubToGrivna(double rubSum)
        {
            Console.WriteLine("From RubToGrivna: {0}",rubSum/grivnaCource);
        }
        public void GrivnaToRub(double grivnaSum)
        {
            Console.WriteLine("From GrivnaToRub: {0}", grivnaSum*grivnaCource);
        }
    }
}