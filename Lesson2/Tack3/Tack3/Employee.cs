using System;

namespace Tack3
{
    public class Employee
    {
        private string name;
        private string sername;
        private string post;
        private int experience;
        public Employee(string name,string sername)
        {
            this.name = name;
            this.sername = sername;
        }
        public string Post { get { return post; } set { post = value; } }
        public int Experience { get { return experience; } set { experience = value; } }
        public double CountSalary()
        {
            double salarykoef;

            switch (post.ToLower())
            {
                case "manager":
                    salarykoef = 200;
                    break;
                case "developer":
                    salarykoef = 150;
                    break;
                case "secretary":
                    salarykoef = 80;
                    break;
                case "cleaner":
                    salarykoef = 65;
                    break;
                default:
                    salarykoef = 100;
                    break;
            }

            switch (experience)
            {
                case 0:
                    salarykoef *= 1.5;
                    break;
                case 1:
                    salarykoef *= 2;
                    break;
                case 2:
                    salarykoef *= 2.5;
                    break;
                default:
                    salarykoef *= 5;
                    break;
            }
            return salarykoef;
        }

        public void ShowSalary()
        {
            Console.WriteLine("Зарплата {0}, подоходный налог {1}", CountSalary(), CountSalary() * 0.13);
        }
    }
}