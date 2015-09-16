using System;

namespace Task1
{
    public class Printer
    {
        private ConsoleColor consoleColor;

        public Printer(ConsoleColor consoleColor)
        {
            this.consoleColor = consoleColor;
        }
        public void Print(string value)
        {
            Console.ForegroundColor = consoleColor;
            Console.WriteLine(value);
            Console.ForegroundColor=ConsoleColor.Gray;
        }
    }
}