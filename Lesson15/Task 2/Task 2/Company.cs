using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    public class Company
    {
        private Worker[] worker;

        public Company()
        {
            worker = new Worker[2];
            string fio;
            string post;
            int employmentYear;

            for (int i = 0; i < worker.Length; i++)
            {
                Console.WriteLine("Введите ФИО");
                fio = Console.ReadLine();
                Console.WriteLine("Введите Должность");
                post = Console.ReadLine();
                Console.WriteLine("Введите год принятия");
                try
                {
                    employmentYear = DateTime.Parse(Console.ReadLine()).Year;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Вы ввели недопустимое значение года");
                    Console.WriteLine(ex.Message);
                    employmentYear = DateTime.Now.Year;
                }
                
                worker[i] = new Worker(fio, post, employmentYear);
            }

            worker = worker.OrderBy(staff => staff.Fio).ToArray();
            Console.Clear();
        }

        public string this[int stage]
        {
            get
            {
                string answer = "";
                for (int i = 0; i < worker.Length; i++)
                {
                    if (DateTime.Now.Year - worker[i].EmploymentYear>stage)
                    {
                        answer= "Имя работника "+worker[i].Fio;
                    }
                }

                if (answer.Length>=0)
                {
                    return answer;
                }
                return "Нет работников с таким стажем";
            }
        }

    }
}