using System;

namespace Task4
{
    public class Store
    {
        private Article[] article;

        Store()
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
                for (int i = 0; i < article.Length; i++)
                    if (article[i]==index)
                    Console.WriteLine(article[i].ItemName);
            }
        }


    }
}