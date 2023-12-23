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
    [Migration("20231222164710_DUMMY_CART_2")]
    partial class DUMMYCART2
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
                            CreatedDate = new DateTime(2023, 12, 22, 17, 47, 10, 525, DateTimeKind.Local).AddTicks(3753),
                            IsBilling = true,
                            IsDeleted = false,
                            IsShipping = true,
                            ModifiedDate = new DateTime(2023, 12, 22, 17, 47, 10, 525, DateTimeKind.Local).AddTicks(3754),
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
                            CreatedDate = new DateTime(2023, 12, 22, 17, 47, 10, 525, DateTimeKind.Local).AddTicks(3779),
                            IsDeleted = false,
                            ModifiedDate = new DateTime(2023, 12, 22, 17, 47, 10, 525, DateTimeKind.Local).AddTicks(3780),
                            Name = "Alice In Chains"
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2023, 12, 22, 17, 47, 10, 525, DateTimeKind.Local).AddTicks(3785),
                            IsDeleted = false,
                            ModifiedDate = new DateTime(2023, 12, 22, 17, 47, 10, 525, DateTimeKind.Local).AddTicks(3786),
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
                            CreatedDate = new DateTime(2023, 12, 22, 17, 47, 10, 525, DateTimeKind.Local).AddTicks(4066),
                            IsDeleted = false,
                            ModifiedDate = new DateTime(2023, 12, 22, 17, 47, 10, 525, DateTimeKind.Local).AddTicks(4067),
                            Total = 0.0,
                            UserId = 1
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2023, 12, 22, 17, 47, 10, 525, DateTimeKind.Local).AddTicks(4072),
                            IsDeleted = false,
                            ModifiedDate = new DateTime(2023, 12, 22, 17, 47, 10, 525, DateTimeKind.Local).AddTicks(4073),
                            Total = 0.0,
                            UserId = 100
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
                            CreatedDate = new DateTime(2023, 12, 22, 17, 47, 10, 525, DateTimeKind.Local).AddTicks(3807),
                            IsDeleted = false,
                            ModifiedDate = new DateTime(2023, 12, 22, 17, 47, 10, 525, DateTimeKind.Local).AddTicks(3808),
                            Name = "Vinyl"
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2023, 12, 22, 17, 47, 10, 525, DateTimeKind.Local).AddTicks(3812),
                            IsDeleted = false,
                            ModifiedDate = new DateTime(2023, 12, 22, 17, 47, 10, 525, DateTimeKind.Local).AddTicks(3812),
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
                            CreatedDate = new DateTime(2023, 12, 22, 17, 47, 10, 525, DateTimeKind.Local).AddTicks(3870),
                            IsDeleted = false,
                            ModifiedDate = new DateTime(2023, 12, 22, 17, 47, 10, 525, DateTimeKind.Local).AddTicks(3871),
                            Name = "Sony"
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2023, 12, 22, 17, 47, 10, 525, DateTimeKind.Local).AddTicks(3961),
                            IsDeleted = false,
                            ModifiedDate = new DateTime(2023, 12, 22, 17, 47, 10, 525, DateTimeKind.Local).AddTicks(3962),
                            Name = "Music On Vinyl"
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTime(2023, 12, 22, 17, 47, 10, 525, DateTimeKind.Local).AddTicks(3964),
                            IsDeleted = false,
                            ModifiedDate = new DateTime(2023, 12, 22, 17, 47, 10, 525, DateTimeKind.Local).AddTicks(3965),
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
                            CreatedDate = new DateTime(2023, 12, 22, 17, 47, 10, 525, DateTimeKind.Local).AddTicks(3991),
                            Description = "Proba",
                            FormatId = 1,
                            ImageUrl = "https://www.revolvermag.com/sites/default/files/styles/original_image__844px_x_473px_/public/media/section-media/dirt_cover.jpg?itok=p8cv17Bi&timestamp=1506099877",
                            IsDeleted = false,
                            LabelId = 1,
                            ModifiedDate = new DateTime(2023, 12, 22, 17, 47, 10, 525, DateTimeKind.Local).AddTicks(3992),
                            Name = "Dirt",
                            Price = 30.0
                        },
                        new
                        {
                            Id = 12,
                            Amount = 20,
                            ArtistId = 1,
                            CreatedDate = new DateTime(2023, 12, 22, 17, 47, 10, 525, DateTimeKind.Local).AddTicks(3997),
                            Description = "Proba",
                            FormatId = 1,
                            ImageUrl = "https://m.media-amazon.com/images/I/81EAuKlg2rS.jpg",
                            IsDeleted = false,
                            LabelId = 1,
                            ModifiedDate = new DateTime(2023, 12, 22, 17, 47, 10, 525, DateTimeKind.Local).AddTicks(3998),
                            Name = "Facelift",
                            Price = 30.0
                        },
                        new
                        {
                            Id = 2,
                            Amount = 15,
                            ArtistId = 1,
                            CreatedDate = new DateTime(2023, 12, 22, 17, 47, 10, 525, DateTimeKind.Local).AddTicks(4000),
                            Description = "Proba",
                            FormatId = 1,
                            ImageUrl = "https://i.ebayimg.com/images/g/97YAAOSw96JgV8VP/s-l1200.webp",
                            IsDeleted = false,
                            LabelId = 2,
                            ModifiedDate = new DateTime(2023, 12, 22, 17, 47, 10, 525, DateTimeKind.Local).AddTicks(4001),
                            Name = "Jar Of Flies",
                            Price = 35.0
                        },
                        new
                        {
                            Id = 3,
                            Amount = 20,
                            ArtistId = 1,
                            CreatedDate = new DateTime(2023, 12, 22, 17, 47, 10, 525, DateTimeKind.Local).AddTicks(4003),
                            Description = "Proba",
                            FormatId = 1,
                            ImageUrl = "https://lostposters.com/wp-content/uploads/2022/12/Album-AliceInChainsSapEP.jpg\r\n",
                            IsDeleted = false,
                            LabelId = 1,
                            ModifiedDate = new DateTime(2023, 12, 22, 17, 47, 10, 525, DateTimeKind.Local).AddTicks(4004),
                            Name = "Sap",
                            Price = 20.0
                        },
                        new
                        {
                            Id = 4,
                            Amount = 10,
                            ArtistId = 1,
                            CreatedDate = new DateTime(2023, 12, 22, 17, 47, 10, 525, DateTimeKind.Local).AddTicks(4006),
                            Description = "Proba",
                            FormatId = 1,
                            ImageUrl = "https://m.media-amazon.com/images/I/71rt-HQ-uzL._UF1000,1000_QL80_.jpg",
                            IsDeleted = false,
                            LabelId = 2,
                            ModifiedDate = new DateTime(2023, 12, 22, 17, 47, 10, 525, DateTimeKind.Local).AddTicks(4007),
                            Name = "MTV Unplugged",
                            Price = 40.0
                        },
                        new
                        {
                            Id = 5,
                            Amount = 20,
                            ArtistId = 1,
                            CreatedDate = new DateTime(2023, 12, 22, 17, 47, 10, 525, DateTimeKind.Local).AddTicks(4015),
                            Description = "Proba",
                            FormatId = 1,
                            ImageUrl = "https://external-preview.redd.it/VWC_u7czD3dOxHqy8JoIpR5453ecP1J5UU6NR6H9fVo.jpg?auto=webp&s=fc23b13ac83473ee1d22794fb16d877ae029755e",
                            IsDeleted = false,
                            LabelId = 1,
                            ModifiedDate = new DateTime(2023, 12, 22, 17, 47, 10, 525, DateTimeKind.Local).AddTicks(4024),
                            Name = "Alice In Chains",
                            Price = 50.0
                        },
                        new
                        {
                            Id = 6,
                            Amount = 20,
                            ArtistId = 2,
                            CreatedDate = new DateTime(2023, 12, 22, 17, 47, 10, 525, DateTimeKind.Local).AddTicks(4027),
                            Description = "Proba",
                            FormatId = 1,
                            ImageUrl = "https://static1.squarespace.com/static/565c1ab5e4b05079e4bfa169/565c268fe4b04e8771155c8c/594622b92994cac22764a55b/1688621277686/Nirvana+Bleach+Album+Cover.jpg?format=1500w",
                            IsDeleted = false,
                            LabelId = 3,
                            ModifiedDate = new DateTime(2023, 12, 22, 17, 47, 10, 525, DateTimeKind.Local).AddTicks(4028),
                            Name = "Bleach",
                            Price = 20.0
                        },
                        new
                        {
                            Id = 7,
                            Amount = 20,
                            ArtistId = 2,
                            CreatedDate = new DateTime(2023, 12, 22, 17, 47, 10, 525, DateTimeKind.Local).AddTicks(4030),
                            Description = "Proba",
                            FormatId = 1,
                            ImageUrl = "https://images.theconversation.com/files/421858/original/file-20210917-31825-dmecrb.jpg?ixlib=rb-1.1.0&rect=36%2C26%2C3458%2C3468&q=45&auto=format&w=926&fit=clip",
                            IsDeleted = false,
                            LabelId = 3,
                            ModifiedDate = new DateTime(2023, 12, 22, 17, 47, 10, 525, DateTimeKind.Local).AddTicks(4031),
                            Name = "Nevermind",
                            Price = 30.0
                        },
                        new
                        {
                            Id = 8,
                            Amount = 10,
                            ArtistId = 2,
                            CreatedDate = new DateTime(2023, 12, 22, 17, 47, 10, 525, DateTimeKind.Local).AddTicks(4033),
                            Description = "Proba",
                            FormatId = 1,
                            ImageUrl = "https://impact89fm.org/wp-content/uploads/2023/04/in-utero.jpg",
                            IsDeleted = false,
                            LabelId = 3,
                            ModifiedDate = new DateTime(2023, 12, 22, 17, 47, 10, 525, DateTimeKind.Local).AddTicks(4034),
                            Name = "In Utero",
                            Price = 45.0
                        },
                        new
                        {
                            Id = 9,
                            Amount = 20,
                            ArtistId = 2,
                            CreatedDate = new DateTime(2023, 12, 22, 17, 47, 10, 525, DateTimeKind.Local).AddTicks(4037),
                            Description = "Proba",
                            FormatId = 1,
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/e/e4/Nirvana_album_cover.svg/1200px-Nirvana_album_cover.svg.png",
                            IsDeleted = false,
                            LabelId = 1,
                            ModifiedDate = new DateTime(2023, 12, 22, 17, 47, 10, 525, DateTimeKind.Local).AddTicks(4038),
                            Name = "Nirvana",
                            Price = 15.0
                        },
                        new
                        {
                            Id = 10,
                            Amount = 20,
                            ArtistId = 2,
                            CreatedDate = new DateTime(2023, 12, 22, 17, 47, 10, 525, DateTimeKind.Local).AddTicks(4040),
                            Description = "Proba",
                            FormatId = 1,
                            ImageUrl = "https://media.pitchfork.com/photos/5b3244c8f96f675aaf0b6f69/master/pass/Nirvana%20-%20Incesticide.jpg",
                            IsDeleted = false,
                            LabelId = 2,
                            ModifiedDate = new DateTime(2023, 12, 22, 17, 47, 10, 525, DateTimeKind.Local).AddTicks(4041),
                            Name = "Incesticide",
                            Price = 20.0
                        },
                        new
                        {
                            Id = 11,
                            Amount = 20,
                            ArtistId = 2,
                            CreatedDate = new DateTime(2023, 12, 22, 17, 47, 10, 525, DateTimeKind.Local).AddTicks(4043),
                            Description = "Proba",
                            FormatId = 1,
                            ImageUrl = "https://i.discogs.com/4xa_lkoBOHO_GtskzDYK7y-DloQ01VbEhOVfsRyKZWA/rs:fit/g:sm/q:90/h:545/w:600/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTU2ODg0/MDktMTM5OTk3NzA0/MC05NDc1LmpwZWc.jpeg",
                            IsDeleted = false,
                            LabelId = 2,
                            ModifiedDate = new DateTime(2023, 12, 22, 17, 47, 10, 525, DateTimeKind.Local).AddTicks(4044),
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
                            BirthDate = new DateTime(2023, 12, 22, 17, 47, 10, 247, DateTimeKind.Local).AddTicks(7633),
                            CreatedDate = new DateTime(2023, 12, 22, 17, 47, 10, 247, DateTimeKind.Local).AddTicks(7712),
                            Email = "admin@gmail.com",
                            IsDeleted = false,
                            ModifiedDate = new DateTime(2023, 12, 22, 17, 47, 10, 247, DateTimeKind.Local).AddTicks(7713),
                            Name = "Admin",
                            Password = "3B3DD5647D35489EB11FF15030FBF150264953946DB964CB53158B7C4E34645248D890ACAC7E174733CBF41E6BD1D65DA409ABE06A57493977FEBF5FAC52F4C6",
                            Role = "ADMIN",
                            Salt = new byte[] { 55, 222, 186, 135, 113, 40, 16, 80, 42, 109, 200, 32, 231, 36, 128, 118, 68, 9, 217, 131, 222, 117, 13, 159, 117, 76, 207, 2, 240, 28, 220, 31, 26, 250, 199, 213, 158, 175, 28, 17, 142, 94, 195, 157, 195, 168, 94, 210, 24, 153, 230, 159, 191, 108, 9, 39, 80, 97, 79, 239, 86, 153, 95, 24 },
                            Surname = "Admin"
                        },
                        new
                        {
                            Id = 100,
                            BirthDate = new DateTime(2023, 12, 22, 17, 47, 10, 525, DateTimeKind.Local).AddTicks(3262),
                            CreatedDate = new DateTime(2023, 12, 22, 17, 47, 10, 525, DateTimeKind.Local).AddTicks(3339),
                            Email = "barcaldejan@gmail.com",
                            IsDeleted = false,
                            ModifiedDate = new DateTime(2023, 12, 22, 17, 47, 10, 525, DateTimeKind.Local).AddTicks(3340),
                            Name = "Dejan",
                            Password = "873C77C90EF18A2712C43A10500F3E4C59002160EF0DC4E040EE72A5E0A7F7944EB6CB5344941DBF12735A0CC56203F5AD4F344C805CEDFAEC9F9F1B652922FB",
                            Role = "ADMIN",
                            Salt = new byte[] { 177, 34, 84, 205, 2, 190, 202, 20, 69, 91, 38, 172, 68, 213, 34, 232, 81, 182, 141, 78, 124, 157, 56, 3, 120, 127, 90, 27, 110, 21, 114, 13, 88, 85, 136, 247, 164, 169, 196, 251, 232, 254, 151, 253, 201, 112, 73, 220, 58, 82, 64, 73, 219, 220, 114, 161, 112, 43, 232, 187, 33, 120, 185, 43 },
                            Surname = "Barcal"
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