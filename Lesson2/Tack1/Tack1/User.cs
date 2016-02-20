using System;
using System.Collections.Specialized;

namespace Tack1
{
    public class User
    {
        private readonly string login, name, sername;
        private readonly int age;
        private readonly DateTime dateWriting;
        public User(string login, string name, string sername,int age, DateTime dateWriting)
        {
            this.login = login;
            this.name = name;
            this.sername = sername;
            this.age = age;
            this.dateWriting = dateWriting;
        }
        public string Login { get { return login; } }
        public string Name { get { return name; } }
        public string Sername { get { return sername; } }
        public int Age { get { return age; } }
        public DateTime DateWriting{get { return dateWriting; } }

    }
}