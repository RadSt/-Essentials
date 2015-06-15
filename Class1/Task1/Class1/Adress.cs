using System.Linq.Expressions;

namespace Class1
{
    public class Adress
    {
        private string index;
        private string country;
        private string city;
        private string street;
        private string house;
        private string apartment;

        public string Index
        {
            get { return index;}

            set { index = value; }
        }

        public string Country
        {
            get { return index; }
            set { index = value; }
        }

        public string City
        {
            get { return city; }
            set { city = value; }
        }

        public string Street
        {
            get { return city; }
            set { city = value; }
        }

        public string House
        {
            get { return house; }
            set { house = value; }
        }

        public string Apartment
        {
            get { return apartment; }
            set { apartment = value; }
        }

    }
}