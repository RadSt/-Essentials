using System;
using System.Security.Cryptography.X509Certificates;

namespace Tack4
{
    public class DocumentWorker
    {
        public void OpenDocument()
        {
            Console.WriteLine("Документ открыт");
        }
        public virtual void EditDocument()
        {
            Console.WriteLine("Редактирование документа доступно в версии Pro");
        }

        public virtual void SaveDocument()
        {
            Console.WriteLine("Сохраннение документа доступнов в версии Pro");
        }
    }
}