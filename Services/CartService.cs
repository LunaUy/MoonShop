using MoonShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoonShop.Services
{
    public class CartService
    {
        List<Product> Products { get; set; } = new List<Product>();


        public async Task<List<Product>> GetProducts()
        {
            await Task.CompletedTask;
            return Products;
        }

        public Task AddToCart(Product product)
        {
            if (!Products.Contains(product))
            {
                Products.Add(product);
            }
            return Task.CompletedTask;
        }

    }
}
