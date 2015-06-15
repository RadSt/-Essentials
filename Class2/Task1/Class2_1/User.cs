using System;

namespace Class2_1
{
    public class User
    {
        public readonly DateTime Date;
        public string Login { get; set; }
        public string Name { get; set; }
        public string FamilyName { get; set; }
        public int Age { get; set; }

        public User()
        {
            Date = DateTime.Now;
        }

        
    }
}