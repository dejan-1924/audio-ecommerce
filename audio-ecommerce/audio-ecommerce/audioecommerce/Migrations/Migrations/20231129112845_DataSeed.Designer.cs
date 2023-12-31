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
    [Migration("20231129112845_DataSeed")]
    partial class DataSeed
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
                            CreatedDate = new DateTime(2023, 11, 29, 12, 28, 44, 956, DateTimeKind.Local).AddTicks(8785),
                            IsDeleted = false,
                            ModifiedDate = new DateTime(2023, 11, 29, 12, 28, 44, 956, DateTimeKind.Local).AddTicks(8836),
                            Name = "Alice In Chains"
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2023, 11, 29, 12, 28, 44, 956, DateTimeKind.Local).AddTicks(8857),
                            IsDeleted = false,
                            ModifiedDate = new DateTime(2023, 11, 29, 12, 28, 44, 956, DateTimeKind.Local).AddTicks(8858),
                            Name = "Nirvana"
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

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("ArtistId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Amount = 20,
                            ArtistId = 1,
                            CreatedDate = new DateTime(2023, 11, 29, 12, 28, 44, 956, DateTimeKind.Local).AddTicks(8879),
                            Description = "Proba",
                            IsDeleted = false,
                            ModifiedDate = new DateTime(2023, 11, 29, 12, 28, 44, 956, DateTimeKind.Local).AddTicks(8880),
                            Name = "Dirt",
                            Price = 30.0
                        },
                        new
                        {
                            Id = 2,
                            Amount = 15,
                            ArtistId = 1,
                            CreatedDate = new DateTime(2023, 11, 29, 12, 28, 44, 956, DateTimeKind.Local).AddTicks(8886),
                            Description = "Proba",
                            IsDeleted = false,
                            ModifiedDate = new DateTime(2023, 11, 29, 12, 28, 44, 956, DateTimeKind.Local).AddTicks(8887),
                            Name = "Jar Of Flies",
                            Price = 35.0
                        },
                        new
                        {
                            Id = 3,
                            Amount = 20,
                            ArtistId = 1,
                            CreatedDate = new DateTime(2023, 11, 29, 12, 28, 44, 956, DateTimeKind.Local).AddTicks(8889),
                            Description = "Proba",
                            IsDeleted = false,
                            ModifiedDate = new DateTime(2023, 11, 29, 12, 28, 44, 956, DateTimeKind.Local).AddTicks(8890),
                            Name = "Sap",
                            Price = 20.0
                        },
                        new
                        {
                            Id = 4,
                            Amount = 10,
                            ArtistId = 1,
                            CreatedDate = new DateTime(2023, 11, 29, 12, 28, 44, 956, DateTimeKind.Local).AddTicks(8893),
                            Description = "Proba",
                            IsDeleted = false,
                            ModifiedDate = new DateTime(2023, 11, 29, 12, 28, 44, 956, DateTimeKind.Local).AddTicks(8894),
                            Name = "MTV Unplugged",
                            Price = 40.0
                        },
                        new
                        {
                            Id = 5,
                            Amount = 20,
                            ArtistId = 1,
                            CreatedDate = new DateTime(2023, 11, 29, 12, 28, 44, 956, DateTimeKind.Local).AddTicks(8896),
                            Description = "Proba",
                            IsDeleted = false,
                            ModifiedDate = new DateTime(2023, 11, 29, 12, 28, 44, 956, DateTimeKind.Local).AddTicks(8897),
                            Name = "Alice In Chains",
                            Price = 50.0
                        },
                        new
                        {
                            Id = 6,
                            Amount = 20,
                            ArtistId = 2,
                            CreatedDate = new DateTime(2023, 11, 29, 12, 28, 44, 956, DateTimeKind.Local).AddTicks(8901),
                            Description = "Proba",
                            IsDeleted = false,
                            ModifiedDate = new DateTime(2023, 11, 29, 12, 28, 44, 956, DateTimeKind.Local).AddTicks(8903),
                            Name = "Bleach",
                            Price = 20.0
                        },
                        new
                        {
                            Id = 7,
                            Amount = 20,
                            ArtistId = 2,
                            CreatedDate = new DateTime(2023, 11, 29, 12, 28, 44, 956, DateTimeKind.Local).AddTicks(8905),
                            Description = "Proba",
                            IsDeleted = false,
                            ModifiedDate = new DateTime(2023, 11, 29, 12, 28, 44, 956, DateTimeKind.Local).AddTicks(8906),
                            Name = "Nevermind",
                            Price = 30.0
                        },
                        new
                        {
                            Id = 8,
                            Amount = 10,
                            ArtistId = 2,
                            CreatedDate = new DateTime(2023, 11, 29, 12, 28, 44, 956, DateTimeKind.Local).AddTicks(8909),
                            Description = "Proba",
                            IsDeleted = false,
                            ModifiedDate = new DateTime(2023, 11, 29, 12, 28, 44, 956, DateTimeKind.Local).AddTicks(8910),
                            Name = "In Utero",
                            Price = 45.0
                        },
                        new
                        {
                            Id = 9,
                            Amount = 20,
                            ArtistId = 2,
                            CreatedDate = new DateTime(2023, 11, 29, 12, 28, 44, 956, DateTimeKind.Local).AddTicks(8912),
                            Description = "Proba",
                            IsDeleted = false,
                            ModifiedDate = new DateTime(2023, 11, 29, 12, 28, 44, 956, DateTimeKind.Local).AddTicks(8913),
                            Name = "Nirvana",
                            Price = 15.0
                        },
                        new
                        {
                            Id = 10,
                            Amount = 20,
                            ArtistId = 2,
                            CreatedDate = new DateTime(2023, 11, 29, 12, 28, 44, 956, DateTimeKind.Local).AddTicks(8916),
                            Description = "Proba",
                            IsDeleted = false,
                            ModifiedDate = new DateTime(2023, 11, 29, 12, 28, 44, 956, DateTimeKind.Local).AddTicks(8917),
                            Name = "Incesticide",
                            Price = 20.0
                        },
                        new
                        {
                            Id = 11,
                            Amount = 20,
                            ArtistId = 2,
                            CreatedDate = new DateTime(2023, 11, 29, 12, 28, 44, 956, DateTimeKind.Local).AddTicks(8919),
                            Description = "Proba",
                            IsDeleted = false,
                            ModifiedDate = new DateTime(2023, 11, 29, 12, 28, 44, 956, DateTimeKind.Local).AddTicks(8920),
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

                    b.Navigation("Artist");
                });

            modelBuilder.Entity("audio_ecommerce.Models.Artist", b =>
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
                });
#pragma warning restore 612, 618
        }
    }
}
