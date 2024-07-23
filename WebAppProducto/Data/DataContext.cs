using Microsoft.EntityFrameworkCore;
using WebAppProducto.Models;

namespace WebAppProducto.Data
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
        public DbSet<Product> Products { get; set; } 
    }
}