﻿// <auto-generated />
using System;
using FoodDelivery.DAL.EFCore.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FoodDelivery.DAL.EFCore.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20221205004359_AddDefaultIdentityRoles")]
    partial class AddDefaultIdentityRoles
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("FoodDelivery.DAL.EFCore.Entities.AddressEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Number")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostalCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("AddressEntity");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            City = "New York",
                            Number = "3818",
                            PostalCode = "10016",
                            Street = "My Drive"
                        },
                        new
                        {
                            Id = 2,
                            City = "New York",
                            Number = "3435",
                            PostalCode = "10019",
                            Street = "Briercliff Road"
                        },
                        new
                        {
                            Id = 3,
                            City = "New York",
                            Number = "1079",
                            PostalCode = "10001",
                            Street = "Layman Court"
                        },
                        new
                        {
                            Id = 4,
                            City = "New York",
                            Number = "3521",
                            PostalCode = "10011",
                            Street = "Farnum Road"
                        },
                        new
                        {
                            Id = 5,
                            City = "New York",
                            Number = "676",
                            PostalCode = "10013",
                            Street = "My Drive"
                        },
                        new
                        {
                            Id = 6,
                            City = "New York",
                            Number = "1702",
                            PostalCode = "10011",
                            Street = "Oakwood Avenue"
                        },
                        new
                        {
                            Id = 7,
                            City = "New York",
                            Number = "2187",
                            PostalCode = "10014",
                            Street = "Duncan Avenue"
                        },
                        new
                        {
                            Id = 8,
                            City = "New York",
                            Number = "2952",
                            PostalCode = "10013",
                            Street = "Old Dear Lane"
                        },
                        new
                        {
                            Id = 9,
                            City = "New York",
                            Number = "3872",
                            PostalCode = "10007",
                            Street = "Settlers Lane"
                        },
                        new
                        {
                            Id = 10,
                            City = "New York",
                            Number = "1264",
                            PostalCode = "10007",
                            Street = "Geraldine Lane"
                        });
                });

            modelBuilder.Entity("FoodDelivery.DAL.EFCore.Entities.CustomerEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("AddressId")
                        .HasColumnType("int");

                    b.Property<int>("UserEntityId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AddressId");

                    b.HasIndex("UserEntityId");

                    b.ToTable("CustomerEntity");
                });

            modelBuilder.Entity("FoodDelivery.DAL.EFCore.Entities.FeedbackEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("MealId")
                        .HasColumnType("int");

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.Property<int?>("RestaurantId")
                        .HasColumnType("int");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MealId");

                    b.HasIndex("RestaurantId");

                    b.HasIndex("UserId");

                    b.ToTable("FeedbackEntity");
                });

            modelBuilder.Entity("FoodDelivery.DAL.EFCore.Entities.MealEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MealType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<int?>("RestaurantId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RestaurantId");

                    b.ToTable("MealEntity");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Fresh egg pasta in a sauce made from fresh broccoli and smoked pancetta",
                            MealType = "Pasta",
                            Name = "Broccoli and pancetta fusilli",
                            Price = 10.5,
                            RestaurantId = 1
                        },
                        new
                        {
                            Id = 2,
                            Description = "A warm bagel filled with steak and parmesan",
                            MealType = "Steak",
                            Name = "Steak and parmesan bagel",
                            Price = 15.199999999999999,
                            RestaurantId = 2
                        },
                        new
                        {
                            Id = 3,
                            Description = "Fresh egg tubular pasta in a sauce made from tuna and tangy lemon",
                            MealType = "Pasta",
                            Name = "Tuna and lemon penne",
                            Price = 8.5999999999999996,
                            RestaurantId = 3
                        },
                        new
                        {
                            Id = 4,
                            Description = "Succulent burger made from chunky sausage and spicy chilli, served in a roll",
                            MealType = "Burger",
                            Name = "Sausage and chilli burger",
                            Price = 16.5,
                            RestaurantId = 4
                        },
                        new
                        {
                            Id = 5,
                            Description = "A warm bagel filled with grouse and romaine lettuce",
                            MealType = "Bagel",
                            Name = "Grouse and lettuce bagel",
                            Price = 5.0999999999999996,
                            RestaurantId = 5
                        },
                        new
                        {
                            Id = 6,
                            Description = "Sizzling sausages made from smoked tofu and pattypan squash, served in a roll",
                            MealType = "Vegan",
                            Name = "Tofu and squash sausages",
                            Price = 7.0999999999999996,
                            RestaurantId = 6
                        },
                        new
                        {
                            Id = 7,
                            Description = "Fresh strawberries and sweet pepper combined into smooth soup",
                            MealType = "Soup",
                            Name = "Strawberry and pepper soup",
                            Price = 8.0,
                            RestaurantId = 7
                        },
                        new
                        {
                            Id = 8,
                            Description = "Sole and fresh durian served on a bed of lettuce",
                            MealType = "Salad",
                            Name = "Sole and durian salad",
                            Price = 10.5,
                            RestaurantId = 8
                        },
                        new
                        {
                            Id = 9,
                            Description = "A mouth-watering pasta salad served with garlic dressing",
                            MealType = "Pasta salad",
                            Name = "Pasta salad with garlic dressing",
                            Price = 11.300000000000001,
                            RestaurantId = 9
                        },
                        new
                        {
                            Id = 10,
                            Description = "Fresh egg pasta in a sauce made from green pesto and baby spinach",
                            MealType = "Pasta",
                            Name = "Pesto and spinach pasta",
                            Price = 8.0,
                            RestaurantId = 10
                        });
                });

            modelBuilder.Entity("FoodDelivery.DAL.EFCore.Entities.OrderEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("AddressId")
                        .HasColumnType("int");

                    b.Property<int>("PaymentType")
                        .HasColumnType("int");

                    b.Property<int?>("RestaurantId")
                        .HasColumnType("int");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AddressId");

                    b.HasIndex("RestaurantId");

                    b.HasIndex("UserId");

                    b.ToTable("OrderEntity");
                });

            modelBuilder.Entity("FoodDelivery.DAL.EFCore.Entities.OrderItemEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<int?>("MealId")
                        .HasColumnType("int");

                    b.Property<int?>("OrderId")
                        .HasColumnType("int");

                    b.Property<double>("UnitPrice")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("MealId");

                    b.HasIndex("OrderId");

                    b.ToTable("OrderItemEntity");
                });

            modelBuilder.Entity("FoodDelivery.DAL.EFCore.Entities.PaymentCardEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("CardVerificationCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ExpirationDate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Number")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("PaymentCardEntity");
                });

            modelBuilder.Entity("FoodDelivery.DAL.EFCore.Entities.RestaurantEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("RestaurantManagerEntityId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RestaurantManagerEntityId");

                    b.ToTable("RestaurantEntity");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "The Private Port"
                        },
                        new
                        {
                            Id = 2,
                            Name = "The Sailing Stranger"
                        },
                        new
                        {
                            Id = 3,
                            Name = "The Juniper Angel"
                        },
                        new
                        {
                            Id = 4,
                            Name = "The Mountain Courtyard"
                        },
                        new
                        {
                            Id = 5,
                            Name = "The Mountain Lantern"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Indigo"
                        },
                        new
                        {
                            Id = 7,
                            Name = "The Peacock"
                        },
                        new
                        {
                            Id = 8,
                            Name = "Sapphire"
                        },
                        new
                        {
                            Id = 9,
                            Name = "The Nightingale"
                        },
                        new
                        {
                            Id = 10,
                            Name = "Mumbles"
                        });
                });

            modelBuilder.Entity("FoodDelivery.DAL.EFCore.Entities.RestaurantManagerEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("UserEntityId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserEntityId");

                    b.ToTable("RestaurantManagerEntity");
                });

            modelBuilder.Entity("FoodDelivery.DAL.EFCore.Entities.UserEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
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

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

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

                    b.Property<string>("Surname")
                        .IsRequired()
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
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("IdentityRole");

                    b.HasData(
                        new
                        {
                            Id = "30195817-b567-4701-85db-2f19922c7ae4",
                            ConcurrencyStamp = "e0bc081d-ae4f-494b-8fb9-3aaee22157d3",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "6671cda6-f9bc-4ef3-a3a3-4cfd5f33fb64",
                            ConcurrencyStamp = "aabe1141-5957-4d24-af26-c1d634e4001d",
                            Name = "Customer",
                            NormalizedName = "CUSTOMER"
                        },
                        new
                        {
                            Id = "b4719349-5148-49e3-ba3b-acb66685eca4",
                            ConcurrencyStamp = "745169be-aeb7-4acb-b3d3-4d37f8a2f70f",
                            Name = "RestaurantManager",
                            NormalizedName = "RESTAURANTMANAGER"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

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

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("FoodDelivery.DAL.EFCore.Entities.CustomerEntity", b =>
                {
                    b.HasOne("FoodDelivery.DAL.EFCore.Entities.AddressEntity", "Address")
                        .WithMany()
                        .HasForeignKey("AddressId");

                    b.HasOne("FoodDelivery.DAL.EFCore.Entities.UserEntity", "UserEntity")
                        .WithMany()
                        .HasForeignKey("UserEntityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Address");

                    b.Navigation("UserEntity");
                });

            modelBuilder.Entity("FoodDelivery.DAL.EFCore.Entities.FeedbackEntity", b =>
                {
                    b.HasOne("FoodDelivery.DAL.EFCore.Entities.MealEntity", "Meal")
                        .WithMany("Feedbacks")
                        .HasForeignKey("MealId");

                    b.HasOne("FoodDelivery.DAL.EFCore.Entities.RestaurantEntity", "Restaurant")
                        .WithMany("Feedbacks")
                        .HasForeignKey("RestaurantId");

                    b.HasOne("FoodDelivery.DAL.EFCore.Entities.CustomerEntity", "User")
                        .WithMany("Feedbacks")
                        .HasForeignKey("UserId");

                    b.Navigation("Meal");

                    b.Navigation("Restaurant");

                    b.Navigation("User");
                });

            modelBuilder.Entity("FoodDelivery.DAL.EFCore.Entities.MealEntity", b =>
                {
                    b.HasOne("FoodDelivery.DAL.EFCore.Entities.RestaurantEntity", "Restaurant")
                        .WithMany("Meals")
                        .HasForeignKey("RestaurantId");

                    b.Navigation("Restaurant");
                });

            modelBuilder.Entity("FoodDelivery.DAL.EFCore.Entities.OrderEntity", b =>
                {
                    b.HasOne("FoodDelivery.DAL.EFCore.Entities.AddressEntity", "Address")
                        .WithMany("Orders")
                        .HasForeignKey("AddressId");

                    b.HasOne("FoodDelivery.DAL.EFCore.Entities.RestaurantEntity", "Restaurant")
                        .WithMany()
                        .HasForeignKey("RestaurantId");

                    b.HasOne("FoodDelivery.DAL.EFCore.Entities.CustomerEntity", "User")
                        .WithMany("Orders")
                        .HasForeignKey("UserId");

                    b.Navigation("Address");

                    b.Navigation("Restaurant");

                    b.Navigation("User");
                });

            modelBuilder.Entity("FoodDelivery.DAL.EFCore.Entities.OrderItemEntity", b =>
                {
                    b.HasOne("FoodDelivery.DAL.EFCore.Entities.MealEntity", "Meal")
                        .WithMany("OrderItems")
                        .HasForeignKey("MealId");

                    b.HasOne("FoodDelivery.DAL.EFCore.Entities.OrderEntity", "Order")
                        .WithMany("OrderItems")
                        .HasForeignKey("OrderId");

                    b.Navigation("Meal");

                    b.Navigation("Order");
                });

            modelBuilder.Entity("FoodDelivery.DAL.EFCore.Entities.PaymentCardEntity", b =>
                {
                    b.HasOne("FoodDelivery.DAL.EFCore.Entities.CustomerEntity", "User")
                        .WithMany("PaymentCards")
                        .HasForeignKey("UserId");

                    b.Navigation("User");
                });

            modelBuilder.Entity("FoodDelivery.DAL.EFCore.Entities.RestaurantEntity", b =>
                {
                    b.HasOne("FoodDelivery.DAL.EFCore.Entities.RestaurantManagerEntity", null)
                        .WithMany("Restaurants")
                        .HasForeignKey("RestaurantManagerEntityId");
                });

            modelBuilder.Entity("FoodDelivery.DAL.EFCore.Entities.RestaurantManagerEntity", b =>
                {
                    b.HasOne("FoodDelivery.DAL.EFCore.Entities.UserEntity", "UserEntity")
                        .WithMany()
                        .HasForeignKey("UserEntityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("UserEntity");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole<int>", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.HasOne("FoodDelivery.DAL.EFCore.Entities.UserEntity", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.HasOne("FoodDelivery.DAL.EFCore.Entities.UserEntity", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole<int>", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FoodDelivery.DAL.EFCore.Entities.UserEntity", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.HasOne("FoodDelivery.DAL.EFCore.Entities.UserEntity", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("FoodDelivery.DAL.EFCore.Entities.AddressEntity", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("FoodDelivery.DAL.EFCore.Entities.CustomerEntity", b =>
                {
                    b.Navigation("Feedbacks");

                    b.Navigation("Orders");

                    b.Navigation("PaymentCards");
                });

            modelBuilder.Entity("FoodDelivery.DAL.EFCore.Entities.MealEntity", b =>
                {
                    b.Navigation("Feedbacks");

                    b.Navigation("OrderItems");
                });

            modelBuilder.Entity("FoodDelivery.DAL.EFCore.Entities.OrderEntity", b =>
                {
                    b.Navigation("OrderItems");
                });

            modelBuilder.Entity("FoodDelivery.DAL.EFCore.Entities.RestaurantEntity", b =>
                {
                    b.Navigation("Feedbacks");

                    b.Navigation("Meals");
                });

            modelBuilder.Entity("FoodDelivery.DAL.EFCore.Entities.RestaurantManagerEntity", b =>
                {
                    b.Navigation("Restaurants");
                });
#pragma warning restore 612, 618
        }
    }
}
