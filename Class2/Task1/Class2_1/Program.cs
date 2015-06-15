using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User{Login = "Desan", Name = "Radik", FamilyName = "Stepanov", Age = 28};
            Console.WriteLine("Login = {0}, Name = {1}, FamilyName = {2}, Age = {3},Date = {4}", 
                user.Login,user.Name,user.FamilyName,user.Age,user.Date);
            Console.ReadLine();

        }
    }
}
