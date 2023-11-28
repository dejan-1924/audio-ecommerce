using audio_ecommerce.Models;
using Microsoft.EntityFrameworkCore;

namespace audio_ecommerce.Data
{
    public class DB_Context : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Artist> Artists { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }



        public DB_Context(DbContextOptions options) : base(options) { }

        public DB_Context()
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


            #region DUMMY PRODUCTS
            modelBuilder.Entity<Artist>();
            modelBuilder.Entity<Artist>(artist =>
            {
                artist.HasData(
                    new
                    {
                        Id = 1,
                        Name = "Alice In Chains",

                    });

                artist.HasData(
                    new
                    {
                        Id = 2,
                        Name = "Nirvana",

                    });

            });
            #endregion



        }
    }
}
