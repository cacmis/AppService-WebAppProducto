using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppProducto.Models;

namespace WebAppProducto.ViewModels
{
    public class ProductoViewModel
    {
        public List<Product> Products { get; set; } = new List<Product>();
        public string SearchText { get; set; } = string.Empty;
    }
}