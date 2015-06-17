using System;

namespace ConsoleApplication1
{
    public class XMLHandler:AbstractHandler
    {
        public XMLHandler(string fileName)
            :base(fileName)
        {
            
        }
        public override void Save()
        {
            Console.WriteLine("XMLHandler Save()");
        }
    }
}