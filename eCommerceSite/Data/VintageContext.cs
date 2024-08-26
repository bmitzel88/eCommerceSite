using Microsoft.EntityFrameworkCore;
using eCommerceSite.Models;

namespace eCommerceSite.Data
{
    public class VintageContext : DbContext 
    {
        public VintageContext(DbContextOptions<VintageContext>options) : base(options) 
        {
            
        }

        public DbSet<Product> Products { get; set; }

        public DbSet<Member> Members { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<RegisterViewModel>().HasNoKey();

            base.OnModelCreating(modelBuilder);
        }
        public DbSet<eCommerceSite.Models.RegisterViewModel> RegisterViewModel { get; set; } = default!;

    }
}
