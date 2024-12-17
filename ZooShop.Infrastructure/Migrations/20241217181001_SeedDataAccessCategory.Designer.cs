﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ZooShop.Infrastructure.Data;

#nullable disable

namespace ZooShop.Infrastructure.Migrations
{
    [DbContext(typeof(ZooShopDbContext))]
    [Migration("20241217181001_SeedDataAccessCategory")]
    partial class SeedDataAccessCategory
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.35")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasDiscriminator<string>("Discriminator").HasValue("IdentityUser");

                    b.HasData(
                        new
                        {
                            Id = "c2f14bf7-ffdd-47a4-90b3-f2309486fae9",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "ed47b3d0-667e-4d13-8adf-5727cd4e6867",
                            Email = "admin@gmail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN@GMAIL.COM",
                            NormalizedUserName = "ADMIN@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEFnYegb3YwB1andnmvkJV/WFyCa5qsLJ33WVpBrdRP43kzN9rZQyS4S+AO9lPCqZGQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "9b3e41f9-da14-4e1f-82f1-b3f2d41c6ea8",
                            TwoFactorEnabled = false,
                            UserName = "admin@gmail.com"
                        },
                        new
                        {
                            Id = "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "e641ff0e-31cd-412e-8468-4f8490e65e41",
                            Email = "guest@gmail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "GUEST@GMAIL.COM",
                            NormalizedUserName = "GUEST@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEBWvHU4z49SVh1FOTOokSZRMEnh7zIvr+GSEssspYPiiN8pcwNt8hAVisETNLozMWA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "3e610501-68a8-4333-82b8-32bc78ff46ab",
                            TwoFactorEnabled = false,
                            UserName = "guest@gmail.com"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("ZooShop.Infrastructure.Data.Models.Accessory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasComment("The current Accessory's Identifier");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)")
                        .HasComment("The Name of product category");

                    b.HasKey("Id");

                    b.ToTable("Accessories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Bed"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Aquarium"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Strap"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Cage"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Food"
                        });
                });

            modelBuilder.Entity("ZooShop.Infrastructure.Data.Models.AccessoryCategory", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<int>("CategoriesId")
                        .HasColumnType("int");

                    b.Property<int>("AccessoriesId")
                        .HasColumnType("int");

                    b.HasKey("Id", "CategoriesId", "AccessoriesId");

                    b.HasIndex("AccessoriesId");

                    b.HasIndex("CategoriesId");

                    b.ToTable("AccessoryCategories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoriesId = 1,
                            AccessoriesId = 3
                        },
                        new
                        {
                            Id = 2,
                            CategoriesId = 2,
                            AccessoriesId = 1
                        },
                        new
                        {
                            Id = 4,
                            CategoriesId = 4,
                            AccessoriesId = 5
                        });
                });

            modelBuilder.Entity("ZooShop.Infrastructure.Data.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasComment("The current Category's Identifier");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)")
                        .HasComment("The Name of product category");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Dog"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Cat"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Fish"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Bird"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Rodets"
                        });
                });

            modelBuilder.Entity("ZooShop.Infrastructure.Data.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("ZooShop.Infrastructure.Data.Models.OrderItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

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

            modelBuilder.Entity("ZooShop.Infrastructure.Data.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasComment("The current Product's Identifier");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("AccessoryId")
                        .HasColumnType("int");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)")
                        .HasComment("Product details");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasMaxLength(1000000000)
                        .HasColumnType("nvarchar(max)")
                        .HasComment("The current picture of product");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasComment("The name of product");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)")
                        .HasComment("The current Products price");

                    b.Property<int>("StockQuantity")
                        .HasColumnType("int")
                        .HasComment("Available quantity of the product");

                    b.HasKey("Id");

                    b.HasIndex("AccessoryId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AccessoryId = 1,
                            CategoryId = 1,
                            Description = "Кучешка храна Пюрина Мини Актив 800г с пилешко месо и ориз",
                            ImageUrl = "https://www.purina.bg/kucheta/hrana-za-kucheta/product-suha-pro-plan-puppy-healthy-start-sredni-porodi-pileshko",
                            Name = "Purina",
                            Price = 10.00m,
                            StockQuantity = 3
                        },
                        new
                        {
                            Id = 5,
                            AccessoryId = 4,
                            CategoryId = 3,
                            Description = "Перфектен за декорация на рестуранти, рецепции, офиси и за дома с изчистен и модерен дизайн. Предлагат се в 4 различни цвята и размери за перфектно съчетаване с вашето обзавеждане:",
                            ImageUrl = "https://www.zoomagazinche.bg/goliam-akvarium-za-ribi-190-litra-ferplast-dubai-100.html",
                            Name = "AquaEl Голям аквариум за риби 190 литра",
                            Price = 750.3m,
                            StockQuantity = 10
                        },
                        new
                        {
                            Id = 3,
                            AccessoryId = 1,
                            CategoryId = 1,
                            Description = "Здрав диван за кучета с вътрешен матрак от мемори пяна. Насърчава благосъстоянието и комфорта на вашето животно. Осигурява оптимална подкрепа за вашия приятел",
                            ImageUrl = "https://mypetshop.bg/ferplast-memor-one-medium-kucheshko-leglo-s-ortopedichen-matrak-ot-memori-pyana-64-x-52-x-h-165-sm-p1044198",
                            Name = "Ferplast MEMOR-ONE",
                            Price = 231.27m,
                            StockQuantity = 5
                        },
                        new
                        {
                            Id = 2,
                            AccessoryId = 3,
                            CategoryId = 2,
                            Description = "Обогатени с подбрани зеленчуци и масла , овкусени с билки и пресни подправки тези късчета месо имат превъзходен вкус, в който котката Ви ще се влюби.",
                            ImageUrl = "https://zoocenter.bg/product/whiskas-pure-delight-mesni-ili-ptichi-yastiya-4-h-85-gr",
                            Name = "Whiskas Pure Delight месни или птичи ястия 4 х 85 гр",
                            Price = 4.20m,
                            StockQuantity = 20
                        },
                        new
                        {
                            Id = 4,
                            AccessoryId = 2,
                            CategoryId = 2,
                            Description = "ПРОТИВОПАРАЗИТНА КАИШКА ЗА КОТЕ ЗА 8-МЕСЕЧНА ЗАЩИТА И ТРЕТИРАНЕ НА БЪЛХИ И КЪРЛЕЖИ ПРИ КУЧЕТА НА НАЙ-МАЛКО 7 СЕДМИЧНА ВЪЗРАСТ Инструкция за употреба: Поставете нашийникаоколо врата на домашния любимец, плъзнете края на нашийника при катараматаи го регулирайте да пасне. Оставете място около 4-5 смза разтеж на домашния любимец и допълнително регулирайте. Закопчайте на място и отрежете излишната дължина. При нормално състояние нашийника трябва да се сменя на всеки 8 месеца. При условия на силно заразяване, сменяйте нашийника по-често. Домашният любимецможе да се носи нашийника 24 часа на ден, докато се къпе или играе под дъжда.ВНИМАНИЕ: Дръжте нашийника далеч от деца. СЪСТАВ: Лимонов евкалипт- 60%, масло от линалое - 25%, масло от цитронела 10%, масло от лавандула - 5%.",
                            ImageUrl = "https://farmavet.bg/produkt/%D0%BF%D1%80%D0%BE%D1%82%D0%B8%D0%B2%D0%BE%D0%BF%D0%B0%D1%80%D0%B0%D0%B7%D0%B8%D1%82%D0%BD%D0%B8-%D0%BA%D0%B0%D0%B8%D1%88%D0%BA%D0%B8-%D0%B7%D0%B0-%D0%BA%D0%BE%D1%82%D0%B5-flea-and-tick-collar/",
                            Name = "ПРОТИВОПАРАЗИТНИ КАИШКИ ЗА КОТЕ FLEA AND TICK COLLAR",
                            Price = 6.70m,
                            StockQuantity = 8
                        });
                });

            modelBuilder.Entity("ZooShop.Infrastructure.Data.Models.Review", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("Reviews");
                });

            modelBuilder.Entity("ZooShop.Infrastructure.Data.Models.ApplicationUser", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityUser");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasDiscriminator().HasValue("ApplicationUser");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ZooShop.Infrastructure.Data.Models.AccessoryCategory", b =>
                {
                    b.HasOne("ZooShop.Infrastructure.Data.Models.Accessory", "Accessory")
                        .WithMany("AccessoryCategories")
                        .HasForeignKey("AccessoriesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ZooShop.Infrastructure.Data.Models.Category", "Category")
                        .WithMany("AccessoryCategories")
                        .HasForeignKey("CategoriesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Accessory");

                    b.Navigation("Category");
                });

            modelBuilder.Entity("ZooShop.Infrastructure.Data.Models.Order", b =>
                {
                    b.HasOne("ZooShop.Infrastructure.Data.Models.ApplicationUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("ZooShop.Infrastructure.Data.Models.OrderItem", b =>
                {
                    b.HasOne("ZooShop.Infrastructure.Data.Models.Order", "Order")
                        .WithMany("Items")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ZooShop.Infrastructure.Data.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("ZooShop.Infrastructure.Data.Models.Product", b =>
                {
                    b.HasOne("ZooShop.Infrastructure.Data.Models.Accessory", "Accessory")
                        .WithMany("Products")
                        .HasForeignKey("AccessoryId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("ZooShop.Infrastructure.Data.Models.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Accessory");

                    b.Navigation("Category");
                });

            modelBuilder.Entity("ZooShop.Infrastructure.Data.Models.Review", b =>
                {
                    b.HasOne("ZooShop.Infrastructure.Data.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("ZooShop.Infrastructure.Data.Models.Accessory", b =>
                {
                    b.Navigation("AccessoryCategories");

                    b.Navigation("Products");
                });

            modelBuilder.Entity("ZooShop.Infrastructure.Data.Models.Category", b =>
                {
                    b.Navigation("AccessoryCategories");

                    b.Navigation("Products");
                });

            modelBuilder.Entity("ZooShop.Infrastructure.Data.Models.Order", b =>
                {
                    b.Navigation("Items");
                });
#pragma warning restore 612, 618
        }
    }
}
