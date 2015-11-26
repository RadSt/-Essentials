using System;
using System.Threading;

namespace Task3
{
    public class Matrix
    {
        static readonly object locker = new Object();
        Random rand;
        const string letters = "ABCDEFGHIJKLMNOPQRSTYWXYZ0123456789";
        public int Column { get; set; }

        public Matrix(int col)
        {
            Column = col;
            rand = new Random((int)DateTime.Now.Ticks);
        }

        private char GetChar()
        {
            return letters.ToCharArray()[rand.Next(0, 35)];
        }

        public void Move()
        {
            int length = 0;
            int count = rand.Next(3, 6);
            Thread.Sleep(rand.Next(20, 5000));
            for (int i = 0; i < 40; i++)
            {
                lock (locker)
                {
                    Console.CursorTop = 0;
                    Console.ForegroundColor = ConsoleColor.Black;
                    for (int j = 0; j < i; j++)
                    {
                        Console.CursorLeft = Column;
                        Console.WriteLine("█");
                    }
                    if (length < count)
                        length++;
                    else if (length == count)
                        count = 0;
                    if (39 - i < length)
                        length--;
                    Console.CursorTop = i - length + 1;
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    for (int j = 0; j < length - 2; j++)
                    {
                        Console.CursorLeft = Column;
                        Console.WriteLine(GetChar());
                    }
                    if (length >= 2)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.CursorLeft = Column;
                        Console.WriteLine(GetChar());
                    }
                    if (length >= 1)
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.CursorLeft = Column;
                        Console.Write(GetChar());
                    }
                    Thread.Sleep(20);
                }
            }
        }
    }
}