using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    static class ArraysortAndShow
    {
        public static void Sorting(this int[] intArray)
        {
            Array.Sort(intArray);
        }

        public static void ShowArrayInConsole(this int[] intArray)
        {
            for (int i = 0; i < intArray.Length; i++)
            {
                Console.Write(intArray[i] + " ");
            }
        }
    }
    internal class Program
    {

        private static void Main(string[] args)
        {
            int[] intArray = {1, 4, 2, 5, 6, 10, 8, 9, 3, 7};
            ArraysortAndShow.Sorting(intArray);
            intArray.Sorting();
            intArray.ShowArrayInConsole();


            Console.ReadKey();
        }

    }
}
