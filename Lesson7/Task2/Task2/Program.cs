using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Train[] trains=new Train[3];
            TrainInfo.AddTrains(trains);
            TrainInfo.SortTrains(trains);
            TrainInfo.SearchTrainByNumber(trains,1);
            TrainInfo.ShowTrainsArray(trains);

            Console.ReadKey();
        }
    }
}
