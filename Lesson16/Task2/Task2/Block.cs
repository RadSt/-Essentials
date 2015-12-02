using System;
using System.Runtime.CompilerServices;

namespace Task2
{
    public class Block
    {
        private int side1,side2,side3,side4;

        public Block(int side1, int side2, int side3, int side4)
        {
            this.side1 = side1;
            this.side2 = side2;
            this.side3 = side3;
            this.side4 = side4;
        }

        public override string ToString()
        {
            return String.Format("Координаты блока X {0} Y {1} Z {2} W {3}", side1, side2, side3, side4);
        }

        public override bool Equals(object obj)
        {
            if (obj==null ||this.GetType() !=obj.GetType())
                return false;
            Block p = (Block) obj;

            return (side1 == p.side1) && (side2 == p.side2) && (side3 == p.side3) && (side4 == p.side4);

        }

        public override int GetHashCode()
        {
            return side1 ^ side2 ^ side3 ^ side4;
        }
    }
}