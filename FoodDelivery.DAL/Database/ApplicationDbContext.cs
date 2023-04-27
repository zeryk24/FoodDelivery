using FoodDelivery.DAL.Database;
using FoodDelivery.DAL.EFCore.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FoodDelivery.DAL.EFCore.Database;

public class ApplicationDbContext : IdentityDbContext<UserEntity,IdentityRole<int>,int>
{
    public ApplicationDbContext()
    {

    }

    public ApplicationDbContext(DbContextOptions options) : base(options) { }
    
    //only for migrations
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlServer(@"Data Source=ermo.cloud;Encrypt=False;Initial Catalog=fooddelivery;Integrated Security=False;User ID=erikbacaadmin;Password=Pj8#7v45a");

            //optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=FoodDelivery;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            //optionsBuilder.UseSqlServer(@"Server=localhost;Initial Catalog=FoodDelivery;User Id=sa;Password=someThingComplicated1234;");
            //optionsBuilder.UseSqlServer(@"Server=localhost;Initial Catalog=FoodDelivery;Trusted_Connection=True;");
            optionsBuilder.LogTo(Console.WriteLine);
        }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Seed();
    }
}
