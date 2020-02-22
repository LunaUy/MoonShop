namespace MoonShop.Models
{
    public class Product
    {
        public Product(string name, string image, decimal price)
        {
            Name = name;
            Image = image;
            Price = price;
        }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }

        public string Image {get;set;}
    }
}