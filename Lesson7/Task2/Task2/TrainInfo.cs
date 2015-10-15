using System;
using System.Net.Http.Headers;
using System.Reflection.Emit;

namespace Task2
{

    public static class TrainInfo
    {
        public static void AddTrains(Train[] trains)
        {
            for (int i = 0; i < trains.Length; i++)
            {
                Console.WriteLine("Введите номер поезда");
                string num = Console.ReadLine();
                int number=string.IsNullOrEmpty(num) ? 0:Convert.ToInt32(num);

                Console.WriteLine("Введите место назначения");
                string place = Console.ReadLine();
                place = string.IsNullOrEmpty(place) ? "Место назначения не заданно" : place;

                Console.WriteLine("Введите дату отправления");
                string d = Console.ReadLine();
                DateTime date= string.IsNullOrEmpty(d) ? DateTime.Now: Convert.ToDateTime(d);

                trains[i]=new Train(place,number,date);
            }
        }

        public static void SearchTrainByNumber(Train[] trains, int number)
        {
            bool ok=false;
            for (int i = 0; i < trains.Length; i++)
            {
                if (trains[i].TrainNumber==number)
                    Console.WriteLine("Номер поезда: {0} Место назначения: {1} Дата отправления: {2}",
                        trains[i].TrainNumber,trains[i].DestinationPlace,trains[i].DepartureTime);
                ok = true;
            }
            if (!ok)
                Console.WriteLine("Поезд не найден");
        }

        public static void ShowTrainsArray(Train[] trains)
        {
            for (int i = 0; i < trains.Length; i++)
            {
                Console.WriteLine("Номер поезда: {0} Место назначения: {1} Дата отправления: {2}",
                        trains[i].TrainNumber, trains[i].DestinationPlace, trains[i].DepartureTime);
            }
        }

        public static void SortTrains(Train[] trains)
        {
            for (int i = 0; i < trains.Length; i++)
            {
                for (int j = 0; j < trains.Length; j++)
                {
                    if (trains[i].TrainNumber <= trains[j].TrainNumber)
                    {
                        Train g = trains[i];
                        trains[i] = trains[j];
                        trains[j] = g;
                    }
                }
            }
        }
    }
}