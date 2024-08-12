using Microsoft.EntityFrameworkCore;
using ProductsMvc.Models;
using System.Collections.Generic;

namespace ProductsMvc.BAl
{
    public class ProductContext : DbContext
    {

        public ProductContext(DbContextOptions<ProductContext> options) : base(options)
        {

        }
        public DbSet<Product> Product { get; set; }
        public DbSet<Customer> Customer { get; set; }

    }
}
