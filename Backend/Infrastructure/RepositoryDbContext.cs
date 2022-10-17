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
        
        //Order builder. Many to Many
        // Box foreign key
        modelBuilder.Entity<Order>().HasOne(o => o.Box)
            .WithMany(b => b.Orders)
            .HasForeignKey(b => b.BoxId);
        // Customer foreign key
        modelBuilder.Entity<Order>().HasOne(o => o.Customer)
            .WithMany(b => b.Orders)
            .HasForeignKey(b => b.CustomerId);

        //Seed data / Seeding 
        //Customer
        Customer customer1 = new Customer { Id = 1, FirstName = "John", LastName = "Johnson", Email = "John123@gmail.com"};
        Customer customer2 = new Customer { Id = 2, FirstName = "Bo", LastName = "Bosen", Email = "Bo123@gmail.com"};
        Customer customer3 = new Customer { Id = 3, FirstName = "Mikkel", LastName = "Mikkelsen", Email = "Mikkel123@gmail.com"};
        Customer customer4 = new Customer { Id = 4, FirstName = "Ib", LastName = "Ibsen", Email = "Ib123@gmail.com"};
        Customer customer5 = new Customer { Id = 5, FirstName = "Ole", LastName = "Olesen", Email = "Ole123@gmail.com"};
        modelBuilder.Entity<Customer>().HasData(customer1, customer2, customer3, customer4, customer5);
        
        //Box
        Box box1 = new Box { Id = 1, BoxName = "CoolBox 1", Description = "Epic box, with crazy surprises", Price = 2000};
        Box box2 = new Box { Id = 2, BoxName = "CoolBox 2", Description = "Crazy box, with crazy surprises", Price = 1800};
        Box box3 = new Box { Id = 3, BoxName = "CoolBox 3", Description = "Lol box, with crazy surprises", Price = 1600};
        Box box4 = new Box { Id = 4, BoxName = "CoolBox 4", Description = "GG box, with crazy surprises", Price = 1400};
        Box box5 = new Box { Id = 5, BoxName = "CoolBox 5", Description = "BG box, with crazy surprises", Price = 1200};
        modelBuilder.Entity<Box>().HasData(box1, box2, box3, box4, box5);
        
        //Order
        Order order1 = new Order{Id = 1, BoxId = 1, CustomerId = 1};
        Order order2 = new Order{Id = 2, BoxId = 2, CustomerId = 2};
        Order order3 = new Order{Id = 3, BoxId = 3, CustomerId = 3};
        Order order4 = new Order{Id = 4, BoxId = 4, CustomerId = 4};
        Order order5 = new Order{Id = 5, BoxId = 5, CustomerId = 5};
        modelBuilder.Entity<Order>().HasData(order1, order2, order3, order4, order5);

    }
    public DbSet<Box> Boxes { get; set; }
    public DbSet<Customer> Customer { get; set; }
    public DbSet<Order> Orders { get; set; }
}