using System;
using System.Xml.Schema;

namespace Task2
{
    public class Redactor
    {
        private AbstractHandler handler;

        public void ChooseDocument(string docName)
        {
            string docExt = docName.Substring(docName.Length-3, 3);
            switch (docExt)
            {
                 case "txt":  handler=new TxtHandler();
                    break;
                case "xml": handler=new XmlHandler();
                    break;
                case "doc": handler=new DocHandler();
                    break;
                default:
                    Console.WriteLine("Неверный тип документа");
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