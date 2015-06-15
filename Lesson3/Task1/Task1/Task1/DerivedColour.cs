using System;

namespace Task1
{
    public class DerivedColour:BasePrinter
    {

        public DerivedColour (ConsoleColor color)
            :base(color)
        {
        }
    }
}