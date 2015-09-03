using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            string key;
            Console.WriteLine("Введите ключь");
            key = Console.ReadLine();
            DocumentWorker doc = null;

            switch (key.ToLower())
            {
                case "exp":
                    doc = new ExpertDocumentWorker();
                    break;
                case "pro":
                    doc = new ProDocumentWorker();
                    break;
                default:
                    Console.WriteLine("Ключь не верен");
                    doc=new DocumentWorker();
                    break;
            }

            doc.OpenDocument();
            doc.EditDocument();
            doc.SaveDocument();

            Console.ReadKey();
        }
    }
}
