namespace Tack3
{
    public class Employee
    {
        readonly string firstName, secondName;
        private int expirience;
        private string post;

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



   
    }
}