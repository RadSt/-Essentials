using System;
using System.Net.Sockets;

namespace Task2
{
    public class CarCollection<T> : MyList<T> 
    {
        readonly MyList<string> carName;
        readonly MyList<DateTime> carYear;

        public CarCollection()
        {
            carName=new MyList<string>();
            carYear=new MyList<DateTime>();
        }

        public void AddCar(string name, DateTime year)
        {
            carName.Add(name);
            carYear.Add(year);
        }

        public new string this[int index]
        {
            get { return carName[index] + " " + carYear[index].Year; }
        }

        public int Length { get { return carName.Count; } }

        public void Remove()
        {
            carName.Clear();
            carYear.Clear();
        }

        public override string ToString()
        {
            string stroka = null;
            for (int i = 0; i < carName.Count; i++)
            {
                 stroka += "№" + (i + 1) + " " + carName[i] + " " + carYear[i].Year + " г \n";
            }
            return stroka ?? "В парке нет машин";
        }
    }
}