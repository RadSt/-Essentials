using System;

namespace Task2
{
    public class TxtHandler:AbstractHandler
    {
        public override void Open()
        {
            Console.WriteLine("TxtHandler Open");
        }

        public override void Create()
        {
            Console.WriteLine("TxtHandler Create");
        }

        public override void Change()
        {
            Console.WriteLine("TxtHandler Change");
        }

        public override void Save()
        {
            Console.WriteLine("TxtHandler Save");
        }
    }
}