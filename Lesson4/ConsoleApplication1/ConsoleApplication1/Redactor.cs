using System;
using System.Security.Cryptography.X509Certificates;

namespace ConsoleApplication1
{
    public class Redactor
    {
        private AbstractHandler handler;

        public void ChooseDocument(string fileName)
        {
            string format = fileName.Substring(fileName.Length-4);
            switch (format.ToLower())
            {
                case ".doc":
                    handler = new DOCHandler(fileName);
                    break;
                case ".txt":
                    handler=new TXTHandler(fileName);
                    break;
                case ".xml":
                    handler=new XMLHandler(fileName);
                    break;
                default:
                    Console.WriteLine("Неизвестный формат");
                    break;
            } 
        }

        public void Open()
        {
            handler.Open();
        }

        public void Create()
        {
            handler.Create();
        }

        public void Change()
        {
            handler.Change();
        }

        public void Save()
        {
            handler.Save();
        }
    }
}