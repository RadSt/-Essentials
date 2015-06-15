using System;

namespace Class3
{
    public class Title
    {
        private readonly string title;

        public void Show()
        {
            Console.ForegroundColor=ConsoleColor.DarkYellow;
            Console.WriteLine(title);
        }

        public Title(string title)
        {
            this.title = title;
        }
    }
}