using Microsoft.EntityFrameworkCore;
using crud_aspnet_core_webapi.Models;

namespace crud_aspnet_core_webapi.Data
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }

        public DbSet<Product> Products { get; set; }

        public DbSet<User> Users { get; set; }
    }
}