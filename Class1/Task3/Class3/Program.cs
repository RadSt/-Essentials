using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите название книги ");
            var title = Console.ReadLine();
            Console.Write("Введите автора книги ");
            var author = Console.ReadLine();
            Console.Write("Введите содержание книги ");
            var content = Console.ReadLine();
            Book bookInstance = new Book(title, author, content);
            Console.ReadLine();

        }
    }
}
