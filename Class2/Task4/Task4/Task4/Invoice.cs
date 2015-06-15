using System;

namespace Task4
{
    public class Invoice
    {
        protected int account;
        protected string customer, provider;
        private string article;
        private int quantity;

        public int Account { get { return account; }}
        public string Customer { get { return customer; } }
        public string Provider { get { return provider; }}

        public string Article
        {
            get
            {
                if (article == null)
                    return "Неизвестный товар";
                return article;
            } 
            set
            {
                if (value != null)
                    article = value;
            }
        }

        public int Quantity
        {
            get { return quantity; }
            set
            {
                if (value >= 0)
                    quantity = value;
            }
        }

        public Invoice (int account, string customer,string provider)
        {
            this.account = account;
            this.customer = customer;
            this.provider = provider;
        }

        public void CountCost(bool need)
        {
            double cost;
            switch (article.ToLower())
            {
                case "яблоко": cost = 20;
                    break;
                case "апельсин": cost = 30;
                    break;
                case "ананас": cost = 40;
                    break;
                case "мандарин": cost = 50;
                    break;
                default: cost = 0;
                    break;
            }
            if (need)
            {
                cost = cost+cost * 0.13;
            }
            Console.WriteLine("Сумма к оплате {0}",cost*quantity);
        }

    }
}