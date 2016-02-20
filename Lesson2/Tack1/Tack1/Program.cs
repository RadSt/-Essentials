using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tack1
{
    class Program
    {
        static void Main(string[] args)
        {
            User user=new User("Desan","Radik","Stepanov",22,DateTime.Now);
            Console.WriteLine("Login: {0} Name: {1} Sername: {2} Age: {3} Date: {4}",user.Login,user.Name,user.Sername,user.Age,user.DateWriting);
            Console.ReadKey();
        }
    }
}
