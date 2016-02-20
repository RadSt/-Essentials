using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        private static int count;
        static void NewThread()
        {
            Console.WriteLine("Say Hello {0}", Thread.CurrentThread.Name);
            Thread.Sleep(1000);
            Thread thread = new Thread(NewThread);
            count++;
            thread.Name = "Thread " + count;
            thread.Start();
            thread.IsBackground = true;
        }
        static void Main(string[] args)
        {
            Thread thread = new Thread(NewThread) {Name = "Thread "+count};
            thread.Start();
            thread.IsBackground = true;

            Console.ReadLine();
        }
    }
}
