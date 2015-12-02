using System;

namespace Task3
{
    public class House
    {
        private int flatNumber;
        private Street street;

        public House(Street street, int flatNumber)
        {
            this.street = street;
            this.flatNumber = flatNumber;
        }
        public int FlatNumber { get { return flatNumber; } set { flatNumber = value; }}
        public Street Street { get { return Street; } set { street = value; }}


        public House Clone()
        {
            return this;
        }

        public House DeepClone()
        {
            return new House(this.street.Clone() as Street, this.flatNumber);

        }

        public override string ToString()
        {
            return flatNumber + " " + street;
        }

    }

    public class Street:ICloneable
    {
        private string str;
        public Street(string str)
        {
            this.str = str;
        }
        public string Str { get { return str; }}

        public object Clone()
        {
            return new Street(this.str);
        }
    }
}