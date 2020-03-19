namespace MoonShop.Models
{
    public class Product
    {
        public Product(int id, string name, string image, decimal price)
        {
            Id = id;
            Name = name;
            Image = image;
            Price = price;
        }
        public int Id { get; }

        public string Name { get; }

        public decimal Price { get; }

        public string Description { get; set; }

        public string Image { get; }
    }
}