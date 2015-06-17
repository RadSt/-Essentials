using System;
using System.Runtime.InteropServices;

namespace ConsoleApplication1
{
    public class TXTHandler:AbstractHandler
    {
        public TXTHandler(string fileName)
            :base(fileName)
        {
            
        }

        public override void Save()
        {
            Console.WriteLine(fileName+ " Save()");
        }
    }
}