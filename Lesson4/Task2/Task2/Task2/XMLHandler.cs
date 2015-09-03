using System;
using System.Runtime.InteropServices;

namespace Task2
{
    public class XmlHandler:AbstractHandler
    {
        public override void Open()
        {
            Console.WriteLine("XmlHandler Open");
        }

        public override void Create()
        {
            Console.WriteLine("XmlHandler Create");
        }

        public override void Change()
        {
            Console.WriteLine("XmlHandler Change");
        }

        public override void Save()
        {
            Console.WriteLine("XmlHandler Save");
        }
    }
}