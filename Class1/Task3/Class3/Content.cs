using System;

namespace Class3
{
    public class Content
    {
        private readonly string content;

        public void Show()
        {
            Console.ForegroundColor=ConsoleColor.Magenta;

            Console.WriteLine(content);
        }

        public Content(string content)
        {
            this.content = content;
        }
    }
}