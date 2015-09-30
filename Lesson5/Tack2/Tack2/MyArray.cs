using System;

namespace Tack2
{
    public class MyArray
    {
        private readonly int[] intArray;


        public MyArray(int n)
        {
            var random = new Random();
            intArray = new int[n];
            for (var i = 0; i < intArray.Length; i++)
            {
                intArray[i] = random.Next(0, 50);
            }
        }

        public void MinMaxValue()
        {
            var max = 0;
            var min = 0;
            for (var i = 0; i < intArray.Length; i++)
            {
                max = Math.Max(max, intArray[i]);
                min = Math.Min(min, intArray[i]);
            }
            Console.WriteLine("Max:{0} Min:{1}", max, min);
        }

        public int Sum()
        {
            var sum = 0;
            for (var i = 0; i < intArray.Length; i++)
            {
                sum += intArray[i];
            }
            Console.WriteLine("summa: " + sum);
            return sum;
        }

        public void Average()
        {
            Console.WriteLine("srednee: {0} ", Sum()/intArray.Length);
        }

        public void Odd()
        {
            for (var i = 0; i < intArray.Length; i++)
            {
                if (intArray[i] %2 != 0)
                {
                    Console.Write(intArray[i]+" ");
                }
            }
        }
    }
}