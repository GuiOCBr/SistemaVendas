using Microsoft.EntityFrameworkCore;
using SistemaVenda.Entities;

namespace SistemaVenda.DAL
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Category> Category { get; set; }

        public DbSet<Client> Client{ get; set; }

        public DbSet<Product> Product { get; set; }

        public DbSet<User> User { get; set; }

        public DbSet<Sale> Sale { get; set; }

        public DbSet<SaleProduct> SaleProduct { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<SaleProduct>().HasKey(x => new { x.CodeSale, x.CodeProduct });

            modelBuilder.Entity<SaleProduct>()
                .HasOne(x => x.Sale)
                .WithMany(x => x.Products)
                .HasForeignKey(x => x.CodeSale);

            modelBuilder.Entity<SaleProduct>()
               .HasOne(x => x.Product)
               .WithMany(x => x.Sales)
               .HasForeignKey(x => x.CodeProduct);

        }
    }
}
