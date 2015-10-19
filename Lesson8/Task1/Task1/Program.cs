using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{

    class Program
    {
        static void CountDaysForNextBirthday(DateTime dateOfBirthday)
        {
            DateTime timeNow=DateTime.Now;
            DateTime nextBirthday = dateOfBirthday.AddYears(timeNow.Year - dateOfBirthday.Year);

            if (nextBirthday < timeNow)
                nextBirthday = nextBirthday.AddYears(1);
            Console.WriteLine((nextBirthday-timeNow).Days);

        }
        static void Main(string[] args)
        {
            DateTime dateOfBirthday=new DateTime();
            Console.WriteLine("Введите дату своего рождения");
            dateOfBirthday=Convert.ToDateTime(Console.ReadLine());
            CountDaysForNextBirthday(dateOfBirthday);
 
            Console.ReadKey();


        }
    }
}
