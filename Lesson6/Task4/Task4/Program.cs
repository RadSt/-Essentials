using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    static class Arraysort
    {
        public static void Sorting(this int[] intArray)
        {
            for (int i = 0; i < intArray.Length; i++)
            {
                for (int j = intArray.Length - 1; j > i; j--)
                {
                    if (intArray[i] > intArray[j])
                    {
                        int x = intArray[j];
                        intArray[j] = intArray[i];
                        intArray[i] = x;
                    }

                }
            }
        }
    }
    internal class Program
    {

        private static void Main(string[] args)
        {
            int[] intArray = {1, 4, 2, 5, 6, 10, 8, 9, 3, 7};
            Arraysort.Sorting(intArray);
            intArray.Sorting();

            for (int i = 0; i < intArray.Length; i++)
            {
                Console.Write(intArray[i] + " ");
            }

            Console.ReadKey();
        }
    }
}
