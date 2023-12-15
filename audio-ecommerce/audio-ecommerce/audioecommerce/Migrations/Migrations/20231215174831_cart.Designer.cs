﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using audio_ecommerce.Data;

#nullable disable

namespace audioecommerce.Migrations
{
    [DbContext(typeof(DB_Context))]
    [Migration("20231215174831_cart")]
    partial class cart
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("GenreProduct", b =>
                {
                    b.Property<int>("GenresId")
                        .HasColumnType("int");

                    b.Property<int>("ProductsId")
                        .HasColumnType("int");

                    b.HasKey("GenresId", "ProductsId");

                    b.HasIndex("ProductsId");

                    b.ToTable("GenreProduct");
                });

            modelBuilder.Entity("audio_ecommerce.Models.Address", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsBilling")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<bool>("IsShipping")
                        .HasColumnType("bit");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("ZipCode")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Addresses");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            City = "Novi Sad",
                            Country = "Serbia",
                            CreatedDate = new DateTime(2023, 12, 15, 18, 48, 31, 308, DateTimeKind.Local).AddTicks(8942),
                            IsBilling = true,
                            IsDeleted = false,
                            IsShipping = true,
                            ModifiedDate = new DateTime(2023, 12, 15, 18, 48, 31, 308, DateTimeKind.Local).AddTicks(8944),
                            PhoneNumber = "+387625463456",
                            Street = "Petra Petrovica 1",
                            UserId = 1,
                            ZipCode = "21000"
                        });
                });

            modelBuilder.Entity("audio_ecommerce.Models.Artist", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Artists");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2023, 12, 15, 18, 48, 31, 308, DateTimeKind.Local).AddTicks(8971),
                            IsDeleted = false,
                            ModifiedDate = new DateTime(2023, 12, 15, 18, 48, 31, 308, DateTimeKind.Local).AddTicks(8979),
                            Name = "Alice In Chains"
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2023, 12, 15, 18, 48, 31, 308, DateTimeKind.Local).AddTicks(8989),
                            IsDeleted = false,
                            ModifiedDate = new DateTime(2023, 12, 15, 18, 48, 31, 308, DateTimeKind.Local).AddTicks(8995),
                            Name = "Nirvana"
                        });
                });

            modelBuilder.Entity("audio_ecommerce.Models.Cart", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<double>("Total")
                        .HasColumnType("float");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Cart");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2023, 12, 15, 18, 48, 31, 308, DateTimeKind.Local).AddTicks(9217),
                            IsDeleted = false,
                            ModifiedDate = new DateTime(2023, 12, 15, 18, 48, 31, 308, DateTimeKind.Local).AddTicks(9218),
                            Total = 0.0,
                            UserId = 1
                        });
                });

            modelBuilder.Entity("audio_ecommerce.Models.CartItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CartId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CartId");

                    b.HasIndex("ProductId");

                    b.ToTable("CartItem");
                });

            modelBuilder.Entity("audio_ecommerce.Models.Format", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Format");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2023, 12, 15, 18, 48, 31, 308, DateTimeKind.Local).AddTicks(9016),
                            IsDeleted = false,
                            ModifiedDate = new DateTime(2023, 12, 15, 18, 48, 31, 308, DateTimeKind.Local).AddTicks(9021),
                            Name = "Vinyl"
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2023, 12, 15, 18, 48, 31, 308, DateTimeKind.Local).AddTicks(9026),
                            IsDeleted = false,
                            ModifiedDate = new DateTime(2023, 12, 15, 18, 48, 31, 308, DateTimeKind.Local).AddTicks(9027),
                            Name = "CD"
                        });
                });

            modelBuilder.Entity("audio_ecommerce.Models.Genre", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Genre");
                });

            modelBuilder.Entity("audio_ecommerce.Models.Label", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Label");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2023, 12, 15, 18, 48, 31, 308, DateTimeKind.Local).AddTicks(9049),
                            IsDeleted = false,
                            ModifiedDate = new DateTime(2023, 12, 15, 18, 48, 31, 308, DateTimeKind.Local).AddTicks(9051),
                            Name = "Sony"
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2023, 12, 15, 18, 48, 31, 308, DateTimeKind.Local).AddTicks(9073),
                            IsDeleted = false,
                            ModifiedDate = new DateTime(2023, 12, 15, 18, 48, 31, 308, DateTimeKind.Local).AddTicks(9075),
                            Name = "Music On Vinyl"
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTime(2023, 12, 15, 18, 48, 31, 308, DateTimeKind.Local).AddTicks(9078),
                            IsDeleted = false,
                            ModifiedDate = new DateTime(2023, 12, 15, 18, 48, 31, 308, DateTimeKind.Local).AddTicks(9079),
                            Name = "Roadrunner Records"
                        });
                });

            modelBuilder.Entity("audio_ecommerce.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("audio_ecommerce.Models.OrderItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId");

                    b.ToTable("OrderItems");
                });

            modelBuilder.Entity("audio_ecommerce.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<int>("ArtistId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("FormatId")
                        .HasColumnType("int");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int>("LabelId")
                        .HasColumnType("int");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("ArtistId");

                    b.HasIndex("FormatId");

                    b.HasIndex("LabelId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Amount = 20,
                            ArtistId = 1,
                            CreatedDate = new DateTime(2023, 12, 15, 18, 48, 31, 308, DateTimeKind.Local).AddTicks(9100),
                            Description = "Proba",
                            FormatId = 1,
                            ImageUrl = "https://www.revolvermag.com/sites/default/files/styles/original_image__844px_x_473px_/public/media/section-media/dirt_cover.jpg?itok=p8cv17Bi&timestamp=1506099877",
                            IsDeleted = false,
                            LabelId = 1,
                            ModifiedDate = new DateTime(2023, 12, 15, 18, 48, 31, 308, DateTimeKind.Local).AddTicks(9102),
                            Name = "Dirt",
                            Price = 30.0
                        },
                        new
                        {
                            Id = 12,
                            Amount = 20,
                            ArtistId = 1,
                            CreatedDate = new DateTime(2023, 12, 15, 18, 48, 31, 308, DateTimeKind.Local).AddTicks(9110),
                            Description = "Proba",
                            FormatId = 1,
                            ImageUrl = "https://m.media-amazon.com/images/I/81EAuKlg2rS.jpg",
                            IsDeleted = false,
                            LabelId = 1,
                            ModifiedDate = new DateTime(2023, 12, 15, 18, 48, 31, 308, DateTimeKind.Local).AddTicks(9111),
                            Name = "Facelift",
                            Price = 30.0
                        },
                        new
                        {
                            Id = 2,
                            Amount = 15,
                            ArtistId = 1,
                            CreatedDate = new DateTime(2023, 12, 15, 18, 48, 31, 308, DateTimeKind.Local).AddTicks(9114),
                            Description = "Proba",
                            FormatId = 1,
                            ImageUrl = "https://i.ebayimg.com/images/g/97YAAOSw96JgV8VP/s-l1200.webp",
                            IsDeleted = false,
                            LabelId = 2,
                            ModifiedDate = new DateTime(2023, 12, 15, 18, 48, 31, 308, DateTimeKind.Local).AddTicks(9115),
                            Name = "Jar Of Flies",
                            Price = 35.0
                        },
                        new
                        {
                            Id = 3,
                            Amount = 20,
                            ArtistId = 1,
                            CreatedDate = new DateTime(2023, 12, 15, 18, 48, 31, 308, DateTimeKind.Local).AddTicks(9118),
                            Description = "Proba",
                            FormatId = 1,
                            ImageUrl = "https://lostposters.com/wp-content/uploads/2022/12/Album-AliceInChainsSapEP.jpg\r\n",
                            IsDeleted = false,
                            LabelId = 1,
                            ModifiedDate = new DateTime(2023, 12, 15, 18, 48, 31, 308, DateTimeKind.Local).AddTicks(9119),
                            Name = "Sap",
                            Price = 20.0
                        },
                        new
                        {
                            Id = 4,
                            Amount = 10,
                            ArtistId = 1,
                            CreatedDate = new DateTime(2023, 12, 15, 18, 48, 31, 308, DateTimeKind.Local).AddTicks(9122),
                            Description = "Proba",
                            FormatId = 1,
                            ImageUrl = "https://m.media-amazon.com/images/I/71rt-HQ-uzL._UF1000,1000_QL80_.jpg",
                            IsDeleted = false,
                            LabelId = 2,
                            ModifiedDate = new DateTime(2023, 12, 15, 18, 48, 31, 308, DateTimeKind.Local).AddTicks(9123),
                            Name = "MTV Unplugged",
                            Price = 40.0
                        },
                        new
                        {
                            Id = 5,
                            Amount = 20,
                            ArtistId = 1,
                            CreatedDate = new DateTime(2023, 12, 15, 18, 48, 31, 308, DateTimeKind.Local).AddTicks(9134),
                            Description = "Proba",
                            FormatId = 1,
                            ImageUrl = "https://external-preview.redd.it/VWC_u7czD3dOxHqy8JoIpR5453ecP1J5UU6NR6H9fVo.jpg?auto=webp&s=fc23b13ac83473ee1d22794fb16d877ae029755e",
                            IsDeleted = false,
                            LabelId = 1,
                            ModifiedDate = new DateTime(2023, 12, 15, 18, 48, 31, 308, DateTimeKind.Local).AddTicks(9167),
                            Name = "Alice In Chains",
                            Price = 50.0
                        },
                        new
                        {
                            Id = 6,
                            Amount = 20,
                            ArtistId = 2,
                            CreatedDate = new DateTime(2023, 12, 15, 18, 48, 31, 308, DateTimeKind.Local).AddTicks(9176),
                            Description = "Proba",
                            FormatId = 1,
                            ImageUrl = "https://static1.squarespace.com/static/565c1ab5e4b05079e4bfa169/565c268fe4b04e8771155c8c/594622b92994cac22764a55b/1688621277686/Nirvana+Bleach+Album+Cover.jpg?format=1500w",
                            IsDeleted = false,
                            LabelId = 3,
                            ModifiedDate = new DateTime(2023, 12, 15, 18, 48, 31, 308, DateTimeKind.Local).AddTicks(9177),
                            Name = "Bleach",
                            Price = 20.0
                        },
                        new
                        {
                            Id = 7,
                            Amount = 20,
                            ArtistId = 2,
                            CreatedDate = new DateTime(2023, 12, 15, 18, 48, 31, 308, DateTimeKind.Local).AddTicks(9180),
                            Description = "Proba",
                            FormatId = 1,
                            ImageUrl = "https://images.theconversation.com/files/421858/original/file-20210917-31825-dmecrb.jpg?ixlib=rb-1.1.0&rect=36%2C26%2C3458%2C3468&q=45&auto=format&w=926&fit=clip",
                            IsDeleted = false,
                            LabelId = 3,
                            ModifiedDate = new DateTime(2023, 12, 15, 18, 48, 31, 308, DateTimeKind.Local).AddTicks(9181),
                            Name = "Nevermind",
                            Price = 30.0
                        },
                        new
                        {
                            Id = 8,
                            Amount = 10,
                            ArtistId = 2,
                            CreatedDate = new DateTime(2023, 12, 15, 18, 48, 31, 308, DateTimeKind.Local).AddTicks(9184),
                            Description = "Proba",
                            FormatId = 1,
                            ImageUrl = "https://impact89fm.org/wp-content/uploads/2023/04/in-utero.jpg",
                            IsDeleted = false,
                            LabelId = 3,
                            ModifiedDate = new DateTime(2023, 12, 15, 18, 48, 31, 308, DateTimeKind.Local).AddTicks(9186),
                            Name = "In Utero",
                            Price = 45.0
                        },
                        new
                        {
                            Id = 9,
                            Amount = 20,
                            ArtistId = 2,
                            CreatedDate = new DateTime(2023, 12, 15, 18, 48, 31, 308, DateTimeKind.Local).AddTicks(9189),
                            Description = "Proba",
                            FormatId = 1,
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/e/e4/Nirvana_album_cover.svg/1200px-Nirvana_album_cover.svg.png",
                            IsDeleted = false,
                            LabelId = 1,
                            ModifiedDate = new DateTime(2023, 12, 15, 18, 48, 31, 308, DateTimeKind.Local).AddTicks(9190),
                            Name = "Nirvana",
                            Price = 15.0
                        },
                        new
                        {
                            Id = 10,
                            Amount = 20,
                            ArtistId = 2,
                            CreatedDate = new DateTime(2023, 12, 15, 18, 48, 31, 308, DateTimeKind.Local).AddTicks(9193),
                            Description = "Proba",
                            FormatId = 1,
                            ImageUrl = "https://media.pitchfork.com/photos/5b3244c8f96f675aaf0b6f69/master/pass/Nirvana%20-%20Incesticide.jpg",
                            IsDeleted = false,
                            LabelId = 2,
                            ModifiedDate = new DateTime(2023, 12, 15, 18, 48, 31, 308, DateTimeKind.Local).AddTicks(9195),
                            Name = "Incesticide",
                            Price = 20.0
                        },
                        new
                        {
                            Id = 11,
                            Amount = 20,
                            ArtistId = 2,
                            CreatedDate = new DateTime(2023, 12, 15, 18, 48, 31, 308, DateTimeKind.Local).AddTicks(9198),
                            Description = "Proba",
                            FormatId = 1,
                            ImageUrl = "https://i.discogs.com/4xa_lkoBOHO_GtskzDYK7y-DloQ01VbEhOVfsRyKZWA/rs:fit/g:sm/q:90/h:545/w:600/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTU2ODg0/MDktMTM5OTk3NzA0/MC05NDc1LmpwZWc.jpeg",
                            IsDeleted = false,
                            LabelId = 2,
                            ModifiedDate = new DateTime(2023, 12, 15, 18, 48, 31, 308, DateTimeKind.Local).AddTicks(9199),
                            Name = "MTV Unplugged In New York",
                            Price = 45.0
                        });
                });

            modelBuilder.Entity("audio_ecommerce.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("Salt")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BirthDate = new DateTime(2023, 12, 15, 18, 48, 31, 308, DateTimeKind.Local).AddTicks(8518),
                            CreatedDate = new DateTime(2023, 12, 15, 18, 48, 31, 308, DateTimeKind.Local).AddTicks(8607),
                            Email = "admin@gmail.com",
                            IsDeleted = false,
                            ModifiedDate = new DateTime(2023, 12, 15, 18, 48, 31, 308, DateTimeKind.Local).AddTicks(8608),
                            Name = "Admin",
                            Password = "FB3FFAF8C8141C36770E2BA30C12DAF9FCB0482096F0B6627311A688437BFE0DA19ED5487EE6B6D64E007F1F6DB879F137050350EB8D6B477C6A73BD145481CA",
                            Role = "ADMIN",
                            Salt = new byte[] { 91, 166, 3, 168, 46, 48, 39, 215, 41, 237, 71, 226, 196, 162, 40, 97, 89, 244, 110, 129, 100, 92, 158, 40, 42, 29, 53, 154, 177, 34, 136, 117, 45, 101, 236, 68, 21, 147, 195, 105, 198, 194, 247, 200, 145, 226, 157, 57, 199, 197, 183, 195, 22, 107, 45, 132, 221, 66, 128, 137, 195, 153, 179, 209 },
                            Surname = "Admin"
                        });
                });

            modelBuilder.Entity("GenreProduct", b =>
                {
                    b.HasOne("audio_ecommerce.Models.Genre", null)
                        .WithMany()
                        .HasForeignKey("GenresId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("audio_ecommerce.Models.Product", null)
                        .WithMany()
                        .HasForeignKey("ProductsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("audio_ecommerce.Models.Address", b =>
                {
                    b.HasOne("audio_ecommerce.Models.User", "User")
                        .WithMany("Addresses")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("audio_ecommerce.Models.Cart", b =>
                {
                    b.HasOne("audio_ecommerce.Models.User", "User")
                        .WithMany("ShoppingCarts")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("audio_ecommerce.Models.CartItem", b =>
                {
                    b.HasOne("audio_ecommerce.Models.Cart", "Cart")
                        .WithMany("CartItems")
                        .HasForeignKey("CartId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("audio_ecommerce.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cart");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("audio_ecommerce.Models.Order", b =>
                {
                    b.HasOne("audio_ecommerce.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("audio_ecommerce.Models.OrderItem", b =>
                {
                    b.HasOne("audio_ecommerce.Models.Order", "Order")
                        .WithMany("OrderItems")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("audio_ecommerce.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("audio_ecommerce.Models.Product", b =>
                {
                    b.HasOne("audio_ecommerce.Models.Artist", "Artist")
                        .WithMany("Products")
                        .HasForeignKey("ArtistId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("audio_ecommerce.Models.Format", "Format")
                        .WithMany("Products")
                        .HasForeignKey("FormatId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("audio_ecommerce.Models.Label", "Label")
                        .WithMany("Products")
                        .HasForeignKey("LabelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Artist");

                    b.Navigation("Format");

                    b.Navigation("Label");
                });

            modelBuilder.Entity("audio_ecommerce.Models.Artist", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("audio_ecommerce.Models.Cart", b =>
                {
                    b.Navigation("CartItems");
                });

            modelBuilder.Entity("audio_ecommerce.Models.Format", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("audio_ecommerce.Models.Label", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("audio_ecommerce.Models.Order", b =>
                {
                    b.Navigation("OrderItems");
                });

            modelBuilder.Entity("audio_ecommerce.Models.User", b =>
                {
                    b.Navigation("Addresses");

                    b.Navigation("ShoppingCarts");
                });
#pragma warning restore 612, 618
        }
    }
}
