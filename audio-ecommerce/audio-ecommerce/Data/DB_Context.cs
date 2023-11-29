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


            #region DUMMY ARTISTS
            modelBuilder.Entity<Artist>();
            modelBuilder.Entity<Artist>(artist =>
            {
                artist.HasData(
                    new
                    {
                        Id = 1,
                        Name = "Alice In Chains",
                        CreatedDate = DateTime.Now,
                        ModifiedDate = DateTime.Now,
                        IsDeleted = false

                    });

                artist.HasData(
                    new
                    {
                        Id = 2,
                        Name = "Nirvana",
                        CreatedDate = DateTime.Now,
                        ModifiedDate = DateTime.Now,
                        IsDeleted = false

                    });

            });
            #endregion

            #region DUMMY PRODUCTS
            modelBuilder.Entity<Product>();
            modelBuilder.Entity<Product>(product =>
            {
                product.HasData(
                    new
                    {
                        Id = 1,
                        Name = "Dirt",
                        Description = "Proba",
                        Price = 30.00,
                        Amount = 20,
                        ArtistId = 1,
                        CreatedDate = DateTime.Now,
                        ModifiedDate = DateTime.Now,
                        IsDeleted = false

                    });
                product.HasData(
                    new
                    {
                        Id = 2,
                        Name = "Jar Of Flies",
                        Description = "Proba",
                        Price = 35.00,
                        Amount = 15,
                        ArtistId = 1,
                        CreatedDate = DateTime.Now,
                        ModifiedDate = DateTime.Now,
                        IsDeleted = false

                    });
                product.HasData(
                    new
                    {
                        Id = 3,
                        Name = "Sap",
                        Description = "Proba",
                        Price = 20.00,
                        Amount = 20,
                        ArtistId = 1,
                        CreatedDate = DateTime.Now,
                        ModifiedDate = DateTime.Now,
                        IsDeleted = false

                    });
                product.HasData(
                    new
                    {
                        Id = 4,
                        Name = "MTV Unplugged",
                        Description = "Proba",
                        Price = 40.00,
                        Amount = 10,
                        ArtistId = 1,
                        CreatedDate = DateTime.Now,
                        ModifiedDate = DateTime.Now,
                        IsDeleted = false

                    });
                product.HasData(
                    new
                    {
                        Id = 5,
                        Name = "Alice In Chains",
                        Description = "Proba",
                        Price = 50.00,
                        Amount = 20,
                        ArtistId = 1,
                        CreatedDate = DateTime.Now,
                        ModifiedDate = DateTime.Now,
                        IsDeleted = false

                    });
                product.HasData(
                    new
                    {
                        Id = 6,
                        Name = "Bleach",
                        Description = "Proba",
                        Price = 20.00,
                        Amount = 20,
                        ArtistId = 2,
                        CreatedDate = DateTime.Now,
                        ModifiedDate = DateTime.Now,
                        IsDeleted = false

                    });
                product.HasData(
                    new
                    {
                        Id = 7,
                        Name = "Nevermind",
                        Description = "Proba",
                        Price = 30.00,
                        Amount = 20,
                        ArtistId = 2,
                        CreatedDate = DateTime.Now,
                        ModifiedDate = DateTime.Now,
                        IsDeleted = false

                    });
                product.HasData(
                    new
                    {
                        Id = 8,
                        Name = "In Utero",
                        Description = "Proba",
                        Price = 45.00,
                        Amount = 10,
                        ArtistId = 2,
                        CreatedDate = DateTime.Now,
                        ModifiedDate = DateTime.Now,
                        IsDeleted = false

                    });
                product.HasData(
                    new
                    {
                        Id = 9,
                        Name = "Nirvana",
                        Description = "Proba",
                        Price = 15.00,
                        Amount = 20,
                        ArtistId = 2,
                        CreatedDate = DateTime.Now,
                        ModifiedDate = DateTime.Now,
                        IsDeleted = false

                    });
                product.HasData(
                    new
                    {
                        Id = 10,
                        Name = "Incesticide",
                        Description = "Proba",
                        Price = 20.00,
                        Amount = 20,
                        ArtistId = 2,
                        CreatedDate = DateTime.Now,
                        ModifiedDate = DateTime.Now,
                        IsDeleted = false

                    });
                product.HasData(
                    new
                    {
                        Id = 11,
                        Name = "MTV Unplugged In New York",
                        Description = "Proba",
                        Price = 45.00,
                        Amount = 20,
                        ArtistId = 2,
                        CreatedDate = DateTime.Now,
                        ModifiedDate = DateTime.Now,
                        IsDeleted = false

                    });
            });
            #endregion

        }
    }
}
