using System;

namespace ConsoleApplication1
{
    public class DOCHandler:AbstractHandler
    {
        public DOCHandler(string fileName)
            :base(fileName)
        {
            
        }

        public override void Save()
        {
            Console.WriteLine(fileName+" Save()");
        }
    }
}