using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppProducto.Models
{
    public class Product
    {
        public int Id { get; set; }
        public required string Name { get; set; } 
        public required string Description { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public DateTime CreatedDate { get; set; }=DateTime.Now;

    }
}