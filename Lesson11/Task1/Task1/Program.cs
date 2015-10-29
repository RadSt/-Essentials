using System;
using System.Collections;
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
            ArrayList list=new ArrayList();
            list.Add(0);
            list.Add(0.25);
            list.Add('а');
            list.Add("Hello");
            list.Add(new MyClass());


            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }

            Console.ReadKey();
        }
    }
}
