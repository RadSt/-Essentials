using System;

namespace Task3
{
    class Book
    {
        public class Notes
        {
            public void SaveNotes(string str)
            {
                Console.WriteLine("Сохранить строку: " + str);
            }
        }
        public void FindNext(string str)
        {
            Console.WriteLine("Поиск строки: " + str);
        }
    }

    static class FindAndReplaceManager
    {
        public static void FindNext(string str)
        {
            Book a = new Book();
            a.FindNext(str);
            Book.Notes notes = new Book.Notes();
            notes.SaveNotes(str);
        }
    }

    class Program
    {
        private static void Main()
        {
            FindAndReplaceManager.FindNext("Hello world");

            // Delay.
            Console.ReadKey();
        }
    }
}