using Microsoft.EntityFrameworkCore;
using Core.Models;

namespace Core.Dal;

public class AppDbContext : DbContext
    {
        public AppDbContext()//(DbContextOptions options)
           // : base(options)
        {
        }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("server=zoodotnet.database.windows.net;database=zooDB;UserId=login;Password=Zoo1234!");
    }

    public virtual DbSet<Animal> Animals { get; set; }
        public virtual DbSet<Closing> Closings { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Dependant> Dependants { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Enclosure> Enclosures { get; set; }
        public virtual DbSet<Event> Events { get; set; }
        public virtual DbSet<Food_store> Food_store { get; set; }
        public virtual DbSet<Gift_shop> Gift_shop { get; set; }
        public virtual DbSet<Item> Items { get; set; }
        public virtual DbSet<Manager> Managers { get; set; }
        public virtual DbSet<Purchase> Purchases { get; set; }
        public virtual DbSet<Ticket> Tickets { get; set; }
        public virtual DbSet<Zookeeper> Zookeepers { get; set; }
    }
