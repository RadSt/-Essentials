using System;

namespace Task1
{
    public class Calculator
    {
        public string Add(int num1, int num2)
        {
            return (num1 + num2).ToString();
        }

        public string Sub(int num1, int num2)
        {
            return (num1 - num2).ToString();
        }

        public string Mul(int num1, int num2)
        {
            return (num1*num2).ToString();
        }

        public string Div(int num1, int num2)
        {
            try
            {
                return (num1/num2).ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine("При выполнении произошла ошибка {0} ",ex.Message);
                return null;
            }
            
        }
    }
}