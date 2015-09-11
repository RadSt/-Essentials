using System;

namespace Tack3
{
    public class Content
    {
        public string BookContent { get; set; }

        public void Show()
        {
            Console.ForegroundColor=ConsoleColor.Cyan;
            Console.WriteLine("Содержание: {0}",BookContent);
            Console.ForegroundColor=ConsoleColor.Gray;
        }
    }
}