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

                for (int i = 0; i < 2; i++)
                {
                    Console.WriteLine("Введите ФИО");
                    worker[i].Fio = Console.ReadLine();
                    Console.WriteLine("Введите Должность");
                    worker[i].Post = Console.ReadLine();
                    Console.WriteLine("Введите год принятия");
                    worker[i].EmploymentYear = DateTime.Parse(Console.ReadLine());
                }
                Console.WriteLine("Введите стаж работника");
                int stag = Convert.ToInt32(Console.ReadLine());

                for (int i = 0; i < worker.Length; i++)
                {
                    if (Convert.ToInt32(DateTime.Now.Year-worker[i].EmploymentYear.Year)>stag)
                    {
                        Console.WriteLine("ФИО: {0} \n Должность: {1} \n Год принятия: {2} \n",
                            worker[i].Fio,worker[i].Post,worker[i].EmploymentYear);
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
