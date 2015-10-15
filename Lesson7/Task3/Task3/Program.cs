using System;

namespace Task3
{
    internal class Program
    {
        static void ClassTaker(MyClass myclass )
        {
            myclass.Change = "Изменено";
        }

        static void StructTaker(MyStruct myStruct)
        {
            myStruct.Change = "Изменено";
        }

        private static void Main()
        {
            MyClass myClass=new MyClass();
            MyStruct myStruct = new MyStruct();


            myClass.Change = "Не изменено";
            myStruct.Change = "Не изменено";


            StructTaker(myStruct);
            ClassTaker(myClass);


            Console.WriteLine(myClass.Change);
            Console.WriteLine(myStruct.Change);

            Console.ReadKey();
        }
    }
}