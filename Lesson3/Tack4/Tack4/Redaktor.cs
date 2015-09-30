using System.Collections;

namespace Tack4
{
    public class Redaktor
    {
        private string key;
        private DocumentWorker documentWorker;

        public string Key
        {
            set { key = value; }
        }

        public void ChooseLisense()
        {
            switch (key)
            {
                case "pro":
                    documentWorker = new ProDocumentWorker();
                    break;
                case "exp":
                    documentWorker = new ExpertDocumentWorker();
                    break;
                default:
                    documentWorker = new DocumentWorker();
                    break;
            }
        }

        public void Open()
        {
            documentWorker.OpenDocument();
        }

        public void Save()
        {
            documentWorker.SaveDocument();
        }

        public void Edit()
        {
            documentWorker.EditDocument();
        }

    }
}