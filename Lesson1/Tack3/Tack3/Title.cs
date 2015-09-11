using System;
using System.Runtime.InteropServices;


namespace Tack3
{
    public class Title
    {
        public string BookTitle { get; set; }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Название книги: {0}", BookTitle);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}