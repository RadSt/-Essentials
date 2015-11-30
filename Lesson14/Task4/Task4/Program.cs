using System;
using System.Collections.Generic;
using System.Linq;

namespace Task4
{
    static class MyListExt
    {
        public static T[] GetArray<T> (this IEnumerable<T> myListCollection)
        {
            T[] array=new T[myListCollection.Count()];
            int i = 0;

            foreach (var elem in myListCollection)
            {
                array[i] = elem;
                i++;
            }
            return array;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var collection = new MyListCollection<string>();
            for (int i = 0; i < 8; i++)
                 collection.Add("Привет");


            string [] arr = collection.GetArray();

            foreach (var elem in arr)
                Console.WriteLine(" {0} ",elem);


            Console.ReadKey();
        }
    }
}
