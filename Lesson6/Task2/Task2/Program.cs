﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Book
    {
        public void FindNext(string str)
        {
            Console.WriteLine("Поиск строки: "+str);
        }
    }

    static class FindAndReplaceManager
    {
        public static void FindNext(string str)
        {
           Book a=new Book();
           a.FindNext(str);
        }
    }

    class Program
    {
        static void Main()
        {
           FindAndReplaceManager.FindNext("Hello world");

            // Delay.
            Console.ReadKey();
        }
    }
}
