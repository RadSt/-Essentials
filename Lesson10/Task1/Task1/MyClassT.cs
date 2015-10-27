namespace Task1
{
    public class MyClassT <T> where T:new()
    {
        public static T FactoryMethod()
        {
            return new T ();
        }
    }
}