using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car=new Car();
            car.Name = "Mersedes";
            car.Year = "1985";
            int razm = 10;

            CarCollection<Car> carCollection=new CarCollection<Car>(razm);

            for (int i = 0; i < razm; i++)
            {
                carCollection.Add(car);
            }

            for (int i = 0; i < carCollection.Count; i++)
            {
                Console.WriteLine(carCollection[i].Name+" "+carCollection[i].Year+" ");
            }

            Console.ReadKey();
        }
    }
}
