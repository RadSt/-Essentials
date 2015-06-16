using System;
using System.Runtime.CompilerServices;

namespace Task3
{
    public class Vehicle
    {
        readonly uint cost;
        readonly uint speed;
        readonly uint year;
        readonly int x;
        readonly int y;

        public uint Cost { get { return cost; } }
        public uint Speed { get{return speed;} }
        public uint Year { get{return year;} }
        public int X { get{return x;} }
        public int Y { get{return y;} }

        public Vehicle(uint cost,uint speed,uint year,int x, int y)
        {
            this.cost = cost;
            this.speed = speed;
            this.year = year;
            this.x = x;
            this.y = y;
        }

        public Vehicle(uint cost, uint speed, uint year)
            :this(cost,speed,year,0,0)
        {
            
        }
    }
}