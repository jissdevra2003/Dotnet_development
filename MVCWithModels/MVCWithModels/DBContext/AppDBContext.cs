using Microsoft.EntityFrameworkCore;
using MVCWithModels.Models;
namespace MVCWithModels.DBContext
{
    public class AppDBContext:DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }


    }
}
