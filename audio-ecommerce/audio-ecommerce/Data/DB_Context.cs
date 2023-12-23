using audio_ecommerce.Models;
using FBSApp.SupportClasses.PasswordHasher;
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

            byte[] salt;

            #region DUMMY USERS
            modelBuilder.Entity<User>();
            modelBuilder.Entity<User>(user =>
            {
                user.HasData(
                    new
                    {
                        Id = 1,
                        Name = "Admin",
                        Surname = "Admin",
                        Email = "admin@gmail.com",
                        Password = PasswordHasher.HashPassword("123", out salt),
                        Role = "ADMIN",
                        Salt = salt,
                        BirthDate = DateTime.Now,
                        CreatedDate = DateTime.Now,
                        ModifiedDate = DateTime.Now,
                        IsDeleted = false

                    });
                user.HasData(
                    new
                    {
                        Id = 100,
                        Name = "Dejan",
                        Surname = "Barcal",
                        Email = "barcaldejan@gmail.com",
                        Password = PasswordHasher.HashPassword("123", out salt),
                        Role = "ADMIN",
                        Salt = salt,
                        BirthDate = DateTime.Now,
                        CreatedDate = DateTime.Now,
                        ModifiedDate = DateTime.Now,
                        IsDeleted = false

                    });

            });
            #endregion
            #region DUMMY ADDRESS
            modelBuilder.Entity<Address>();
            modelBuilder.Entity<Address>(address =>
            {
                address.HasData(
                    new
                    {
                        Id = 1,
                        Street = "Petra Petrovica 1",
                        Country = "Serbia",
                        ZipCode = "21000",
                        City = "Novi Sad",
                        PhoneNumber = "+387625463456",
                        UserId = 1,
                        IsShipping = true,
                        IsBilling = true,
                        CreatedDate = DateTime.Now,
                        ModifiedDate = DateTime.Now,
                        IsDeleted = false

                    });
            });
            #endregion
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
            #region DUMMY FORMATS
            modelBuilder.Entity<Format>();
            modelBuilder.Entity<Format>(format =>
            {
                format.HasData(
                    new
                    {
                        Id = 1,
                        Name = "Vinyl",
                        CreatedDate = DateTime.Now,
                        ModifiedDate = DateTime.Now,
                        IsDeleted = false

                    });

                format.HasData(
                    new
                    {
                        Id = 2,
                        Name = "CD",
                        CreatedDate = DateTime.Now,
                        ModifiedDate = DateTime.Now,
                        IsDeleted = false

                    });

            });
            #endregion
            #region DUMMY LABELS
            modelBuilder.Entity<Label>();
            modelBuilder.Entity<Label>(label =>
            {
                label.HasData(
                    new
                    {
                        Id = 1,
                        Name = "Sony",
                        CreatedDate = DateTime.Now,
                        ModifiedDate = DateTime.Now,
                        IsDeleted = false

                    });

                label.HasData(
                    new
                    {
                        Id = 2,
                        Name = "Music On Vinyl",
                        CreatedDate = DateTime.Now,
                        ModifiedDate = DateTime.Now,
                        IsDeleted = false

                    });
                label.HasData(
                    new
                    {
                        Id = 3,
                        Name = "Roadrunner Records",
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
                        LabelId = 1,
                        FormatId = 1,
                        ImageUrl = "https://www.revolvermag.com/sites/default/files/styles/original_image__844px_x_473px_/public/media/section-media/dirt_cover.jpg?itok=p8cv17Bi&timestamp=1506099877",
                        CreatedDate = DateTime.Now,
                        ModifiedDate = DateTime.Now,
                        IsDeleted = false

                    });
                product.HasData(
                    new
                    {
                        Id = 12,
                        Name = "Facelift",
                        Description = "Proba",
                        Price = 30.00,
                        Amount = 20,
                        ArtistId = 1,
                        LabelId = 1,
                        FormatId = 1,
                        ImageUrl = "https://m.media-amazon.com/images/I/81EAuKlg2rS.jpg",
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
                        LabelId = 2,
                        FormatId = 1,
                        ImageUrl = "https://i.ebayimg.com/images/g/97YAAOSw96JgV8VP/s-l1200.webp",
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
                        LabelId = 1,
                        FormatId = 1,
                        ImageUrl = "https://lostposters.com/wp-content/uploads/2022/12/Album-AliceInChainsSapEP.jpg\r\n",
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
                        LabelId = 2,
                        FormatId = 1,
                        ImageUrl = "https://m.media-amazon.com/images/I/71rt-HQ-uzL._UF1000,1000_QL80_.jpg",
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
                        LabelId = 1,
                        FormatId = 1,
                        ImageUrl = "https://external-preview.redd.it/VWC_u7czD3dOxHqy8JoIpR5453ecP1J5UU6NR6H9fVo.jpg?auto=webp&s=fc23b13ac83473ee1d22794fb16d877ae029755e",
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
                        LabelId = 3,
                        FormatId = 1,
                        ImageUrl = "https://static1.squarespace.com/static/565c1ab5e4b05079e4bfa169/565c268fe4b04e8771155c8c/594622b92994cac22764a55b/1688621277686/Nirvana+Bleach+Album+Cover.jpg?format=1500w",
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
                        LabelId = 3,
                        FormatId = 1,
                        ImageUrl = "https://images.theconversation.com/files/421858/original/file-20210917-31825-dmecrb.jpg?ixlib=rb-1.1.0&rect=36%2C26%2C3458%2C3468&q=45&auto=format&w=926&fit=clip",
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
                        LabelId = 3,
                        FormatId = 1,
                        ImageUrl = "https://impact89fm.org/wp-content/uploads/2023/04/in-utero.jpg",
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
                        LabelId = 1,
                        FormatId = 1,
                        ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/e/e4/Nirvana_album_cover.svg/1200px-Nirvana_album_cover.svg.png",
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
                        LabelId = 2,
                        FormatId = 1,
                        ImageUrl = "https://media.pitchfork.com/photos/5b3244c8f96f675aaf0b6f69/master/pass/Nirvana%20-%20Incesticide.jpg",
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
                        LabelId = 2,
                        FormatId = 1,
                        ImageUrl = "https://i.discogs.com/4xa_lkoBOHO_GtskzDYK7y-DloQ01VbEhOVfsRyKZWA/rs:fit/g:sm/q:90/h:545/w:600/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTU2ODg0/MDktMTM5OTk3NzA0/MC05NDc1LmpwZWc.jpeg",
                        CreatedDate = DateTime.Now,
                        ModifiedDate = DateTime.Now,
                        IsDeleted = false

                    });
            });
            #endregion
            #region DUMMY CART
            modelBuilder.Entity<Cart>();
            modelBuilder.Entity<Cart>(cart =>
            {
                cart.HasData(
                    new
                    {
                        Id = 1,
                        UserId = 1,
                        Total = 0.00,
                        CreatedDate = DateTime.Now,
                        ModifiedDate = DateTime.Now,
                        IsDeleted = false

                    });
                cart.HasData(
                new
                {
                    Id = 2,
                    UserId = 100,
                    Total = 0.00,
                    CreatedDate = DateTime.Now,
                    ModifiedDate = DateTime.Now,
                    IsDeleted = false

                });

            });
            #endregion

        }
    }
}
