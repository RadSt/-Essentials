using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Worker[] worker = new Worker[2];

                for (int i = 0; i < worker.Length; i++)
                {
                    Console.WriteLine("Введите ФИО");
                    worker[i].Fio = Console.ReadLine();
                    Console.WriteLine("Введите Должность");
                    worker[i].Post = Console.ReadLine();
                    Console.WriteLine("Введите год принятия");
                    worker[i].EmploymentYear = DateTime.Parse(Console.ReadLine());
                }
                var sortedWorker=worker.OrderBy(s => s.Fio).ToArray();

                Console.WriteLine("Введите стаж работника");
                int stag = Convert.ToInt32(Console.ReadLine());

                for (int i = 0; i < sortedWorker.Length; i++)
                {
                    if (Convert.ToInt32(DateTime.Now.Year - sortedWorker[i].EmploymentYear.Year) > stag)
                    {
                        Console.WriteLine("ФИО: {0} \n Должность: {1} \n Год принятия: {2} \n",
                            sortedWorker[i].Fio, sortedWorker[i].Post, sortedWorker[i].EmploymentYear);
                    }
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine("Ошибка {0} ",ex);
            }

            Console.ReadLine();
        }
    }
}
