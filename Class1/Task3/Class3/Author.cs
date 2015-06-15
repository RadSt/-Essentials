using System;

namespace Class3
{
    public class Author
    {
        private readonly string author;

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(author);
        }

        public Author(string author)
        {
            this.author = author;
        }

    }
}