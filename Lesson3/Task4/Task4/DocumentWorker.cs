using System;

namespace Task4
{
    public class DocumentWorker
    {
        public void OpenDocument()
        {
            Console.WriteLine("Документ открыт");
        }

        public void EditDocument()
        {
            Console.WriteLine("Редактирование документа доступно в версии Про");
        }

        public void SaveDocument()
        {
            Console.WriteLine("Документ сохранен в старом формате, сохранение в остальных форматах доступно в версии Эксперт");
        }
    }
}