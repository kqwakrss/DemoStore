using Microsoft.EntityFrameworkCore;
using DemoStore.Domain.Entities;

namespace DemoStore.Infrastructure.Data
{
    public class StoreDbContext : StoreDbContext{
        public StoreDbContext(DbContextOption<StoreDbContext> options)
            : base(options)
            {
            }

            public DbSet<Product> Products { get; set; }
            
}