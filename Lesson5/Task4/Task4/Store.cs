using System;

namespace Task4
{
    public class Store
    {
        private Article[] article=new Article[4];

        public Store()
        {
            article[0]=new Article("Яблоко","Магнит",10);
            article[1] = new Article("Гречка", "Эссен", 20);
            article[2] = new Article("Макароны", "Камилла", 30);
            article[3] = new Article("Лапша", "Челны Хлеб", 40);
        }

        public string this[int index]
        {
            get
            {
                if (index > 0 && index <= article.Length)
                    return article[index].Info();
                return "Попытка обращения за пределы массива";
            }
        }

        public string this[string itemName]
        {
            get
            {
                for (int i = 0; i < article.Length; i++)
                    if (article[i].ItemName == itemName)
                        return article[i].Info();
                    return "Искомый элемент не найден.";
            }
        }


    }
}