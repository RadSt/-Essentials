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
            Random rand=new Random();
            int[] arrint=new int[10];

            for (int i = 0; i < arrint.Length; i++)
            {
                arrint[i] = rand.Next(50);
            }
            foreach (var elem in Nechet(arrint))
            {
                Console.WriteLine(elem);
            }
            Console.ReadLine();
        }

        static IEnumerable Nechet(int[] arrInt)
        {
            for (int i = 0; i < arrInt.Length; i++)
            {
                if (arrInt[i]%2==0)
                {
                    yield return arrInt[i];
                }
                
            }
            
        }
    }
}
