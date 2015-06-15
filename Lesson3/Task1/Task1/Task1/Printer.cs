using System;

namespace Task1
{
    public class BasePrinter
    {
        protected ConsoleColor color;
        public void Print(string value)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(value);
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        public BasePrinter(ConsoleColor color)
        {
            this.color = color;
        }
    }
}