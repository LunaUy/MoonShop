using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MoonShop.Models
{
    public class ShippingDetail
    {

        [Required]
        public string Name { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        [MinLength(6, ErrorMessage = "El número de teléfono no parece ser válido")]
        public string Phone { get; set; }

    }
}
