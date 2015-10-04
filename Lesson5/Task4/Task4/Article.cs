namespace Task4
{
    public class Article
    {
        public string ItemName { get; set; }
        public string ShopName { get; set; }
        public decimal Price { get; set; }

        public Article(string itemName, string shopName, int price)
        {
            ItemName = itemName;
            ShopName = shopName;
            Price = price;
        }
    }
}