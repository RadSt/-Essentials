using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Tack3
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book=new Book("100 и 1 ночь","Прифытмгоыцщутамщцтуащштцуштац","Араб");
            book.Show();
            Console.ReadKey();
        }
    }
}
