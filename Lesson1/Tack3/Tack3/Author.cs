using System;

namespace Tack3
{
    public class Author
    {
        public string BookAuthor { get; set; }

        public void Show()
        {
            Console.ForegroundColor=ConsoleColor.Blue;
            Console.WriteLine("Автор :{0}",BookAuthor);
            Console.ForegroundColor=ConsoleColor.Gray;
        }
    }
}