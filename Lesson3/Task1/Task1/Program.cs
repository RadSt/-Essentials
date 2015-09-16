using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Printer blue = new Colour(ConsoleColor.Blue);
            blue.Print("Hello");
            Printer yellow =new Colour(ConsoleColor.Yellow);
            yellow.Print("MyFriend");
            Console.ReadKey();
        }
    }
}
