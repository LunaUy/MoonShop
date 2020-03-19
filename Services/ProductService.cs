using MoonShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoonShop.Services
{
    public class ProductService
    {
        readonly List<Product> Products = new List<Product>() {
            new Product(1, "Peluche osito love", "https://i.pinimg.com/originals/34/d8/6e/34d86e78afc427276d930df7df7ad4ee.jpg", 205) { Description = "" },
            new Product(2, "Peluche osito te amo", "https://www.novodistribuciones.com/109053-large_default/oso-de-peluche-te-amo.jpg",230),
            new Product(3, "Nuby Ice Gel Teether Keys", "https://images-na.ssl-images-amazon.com/images/I/61Ehw9y8J0L._SL1000_.jpg", 120),
            new Product(4, "Peluche osito te amo", "https://www.novodistribuciones.com/109053-large_default/oso-de-peluche-te-amo.jpg",230),
            new Product(5, "Peluche osito love", "https://i.pinimg.com/originals/34/d8/6e/34d86e78afc427276d930df7df7ad4ee.jpg", 205),
            new Product(6, "Peluche osito te amo", "https://www.novodistribuciones.com/109053-large_default/oso-de-peluche-te-amo.jpg",230),
            new Product(7, "Nuby Ice Gel Teether Keys", "https://images-na.ssl-images-amazon.com/images/I/61Ehw9y8J0L._SL1000_.jpg", 120),
            new Product(8, "Peluche osito te amo", "https://www.novodistribuciones.com/109053-large_default/oso-de-peluche-te-amo.jpg",230),
            new Product(9, "Peluche osito love", "https://i.pinimg.com/originals/34/d8/6e/34d86e78afc427276d930df7df7ad4ee.jpg", 205),
            new Product(10, "Peluche osito te amo", "https://www.novodistribuciones.com/109053-large_default/oso-de-peluche-te-amo.jpg",230),
            new Product(11, "Peluche osito te amo", "https://www.novodistribuciones.com/109053-large_default/oso-de-peluche-te-amo.jpg",230),
            new Product(12, "Nuby Ice Gel Teether Keys", "https://images-na.ssl-images-amazon.com/images/I/61Ehw9y8J0L._SL1000_.jpg", 120),
            new Product(13, "Peluche osito te amo", "https://www.novodistribuciones.com/109053-large_default/oso-de-peluche-te-amo.jpg",230),
            new Product(14, "Peluche osito love", "https://i.pinimg.com/originals/34/d8/6e/34d86e78afc427276d930df7df7ad4ee.jpg", 205),
            new Product(15, "Peluche osito te amo", "https://www.novodistribuciones.com/109053-large_default/oso-de-peluche-te-amo.jpg",230),
            new Product(16, "Nuby Ice Gel Teether Keys", "https://images-na.ssl-images-amazon.com/images/I/61Ehw9y8J0L._SL1000_.jpg", 120),
            new Product(17, "Peluche osito te amo", "https://www.novodistribuciones.com/109053-large_default/oso-de-peluche-te-amo.jpg",230),
            new Product(18, "Peluche osito love", "https://i.pinimg.com/originals/34/d8/6e/34d86e78afc427276d930df7df7ad4ee.jpg", 205),
            new Product(19, "Peluche osito te amo", "https://www.novodistribuciones.com/109053-large_default/oso-de-peluche-te-amo.jpg",230),
            new Product(20, "Nuby Ice Gel Teether Keys", "https://images-na.ssl-images-amazon.com/images/I/61Ehw9y8J0L._SL1000_.jpg", 120),
            new Product(21, "Peluche osito love", "https://i.pinimg.com/originals/34/d8/6e/34d86e78afc427276d930df7df7ad4ee.jpg", 205)
        };

        public Task<Product[]> GetProducts()
        {
            return Task.FromResult(Products.ToArray());
        }

        public Task<Product> GetProduct(int id)
        {
            return Task.FromResult(Products.SingleOrDefault(x => x.Id == id));
        }

    }
}
