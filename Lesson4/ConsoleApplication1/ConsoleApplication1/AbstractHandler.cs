using System;

namespace ConsoleApplication1
{
    public abstract class AbstractHandler
    {
        protected string fileName;

        public AbstractHandler(string fileName)
        {
            this.fileName = fileName;
        }
        public void Open()
        {
            Console.WriteLine(fileName+" открыт");
        }

        public void Create()
        {
            Console.WriteLine(fileName + " создан");
        }

        public void Change()
        {
            Console.WriteLine(fileName + " изменен");
        }
        public abstract void Save();
    }
}