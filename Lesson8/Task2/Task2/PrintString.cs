using System;

namespace Task2
{
    public static class PrintString
    {
        public static void Print(int color, string text)
        {
            switch (color)
            {
                case (int)ColorsEnum.Blue:
                    Console.ForegroundColor=ConsoleColor.Blue;
                    break;
                case (int)ColorsEnum.Green:
                    Console.ForegroundColor=ConsoleColor.Green;
                    break;
                case (int)ColorsEnum.Red:
                    Console.ForegroundColor=ConsoleColor.Red;
                    break;
                case (int)ColorsEnum.Cyan:
                    Console.ForegroundColor=ConsoleColor.Cyan;
                    break;
                case (int)ColorsEnum.Yellow:
                    Console.ForegroundColor=ConsoleColor.Yellow;
                    break;
                default:
                    Console.ForegroundColor=ConsoleColor.Gray;
                    break;
            }
            Console.WriteLine(text);
        }
    }
}