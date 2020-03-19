using MoonShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoonShop.Services
{
    public class PurchaseService
    {
        List<Product> Products { get; set; } = new List<Product>();


        public async Task Purchase()
        {
            await Task.CompletedTask;
        }
    }
}
