using Domain;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure;

public class RepositoryDbContext : DbContext
{
    public RepositoryDbContext(DbContextOptions<RepositoryDbContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        //Customer builder. Autoincrement on add
        modelBuilder.Entity<Customer>().Property(c => c.Id).ValueGeneratedOnAdd();
        
        //Box builder. Autoincrement on add
        modelBuilder.Entity<Box>().Property(b => b.Id).ValueGeneratedOnAdd();
        
        //Foreign Key to customer
        modelBuilder.Entity<Box>()
            .HasOne(b => b.Customer)
            .WithMany(c => c.Boxes)
            .HasForeignKey(b => b.CustomerId)
            .OnDelete(DeleteBehavior.Cascade);

        //Seed data / Seeding 
        //Customer
        var customer1 = new Customer { Id = 1, FirstName = "John", LastName = "Johnson", Email = "John123@gmail.com"};
        var customer2 = new Customer { Id = 2, FirstName = "Bo", LastName = "Bosen", Email = "Bo123@gmail.com"};
        var customer3 = new Customer { Id = 3, FirstName = "Mikkel", LastName = "Mikkelsen", Email = "Mikkel123@gmail.com"};
        var customer4 = new Customer { Id = 4, FirstName = "Ib", LastName = "Ibsen", Email = "Ib123@gmail.com"};
        var customer5 = new Customer { Id = 5, FirstName = "Ole", LastName = "Olesen", Email = "Ole123@gmail.com"};
        modelBuilder.Entity<Customer>().HasData(customer1, customer2, customer3, customer4, customer5);
        
        //Box
        var box1 = new Box { Id = 1, BoxName = "CoolBox 1", Description = "Epic box, with crazy surprises", Price = 2000, CustomerId = 1};
        var box2 = new Box { Id = 2, BoxName = "CoolBox 2", Description = "Crazy box, with crazy surprises", Price = 1800, CustomerId = 2};
        var box3 = new Box { Id = 3, BoxName = "CoolBox 3", Description = "Lol box, with crazy surprises", Price = 1600, CustomerId = 3};
        var box4 = new Box { Id = 4, BoxName = "CoolBox 4", Description = "GG box, with crazy surprises", Price = 1400, CustomerId = 4};
        var box5 = new Box { Id = 5, BoxName = "CoolBox 5", Description = "BG box, with crazy surprises", Price = 1200, CustomerId = 5};
        modelBuilder.Entity<Box>().HasData(box1, box2, box3, box4, box5);
        
    }

    public DbSet<Box> Boxes;
    public DbSet<Customer> Customer;
}