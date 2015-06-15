using System;
using System.Collections;

namespace Tack3
{
    public class Employee
    {
        readonly string firstName, secondName;
        int expirience;
        string post;

        public string FirstName
        {
            get { return firstName; }
        }

        public string SecondName
        {
            get { return secondName; }
        }

        public int Expirience
        {
            get { return expirience; }
            set
            {
                if(value>=0)
                expirience = value;
            }
        }

        public string Post
        {
            get
            {
                if (post == null) 
                    return "Должность неизвестна";
                return post;
            }
            set
            {
                if (value!=null)
                post = value;
            }
        }
        public Employee (string firstName,string secondName)
        {
            this.firstName = firstName;
            this.secondName = secondName;
        }

        private double CountSallary()
        {
            double sallaryKoef;
            switch (post.ToLower())
            {
                case "direktor": sallaryKoef=200;
                    break;
                case "manager": sallaryKoef = 150;
                    break;
                case "developer": sallaryKoef = 100;
                    break;
                case "cleaner": sallaryKoef = 50;
                    break;
                default:
                    sallaryKoef = 100;
                    break;
            }

            switch (expirience)
            {
                case 0:
                    sallaryKoef*=0.5;
                    break;
                case 1:
                    sallaryKoef *= 1.5;
                    break;
                case 2:
                    sallaryKoef *= 2.5;
                    break;
            }
            return sallaryKoef;
        }

        public void ShowSallary()
        {
            Console.WriteLine("Фамилия: {0}, Имя: {1}, Должность: {2}",FirstName,SecondName,Post);
            Console.WriteLine("Зарплата: {0}, подоходний налог: {1}",CountSallary(),CountSallary()*0.13);
        }
    }
}