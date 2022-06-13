using hightqual_it_backend.Models;
using hightqual_it_backend.Models.Detail;
using hightqual_it_backend.Models.Device;
using hightqual_it_backend.Models.Logistic;
using hightqual_it_backend.Models.Motherboard;
using Microsoft.EntityFrameworkCore;

namespace hightqual_it_backend.Tools
{
    public class DataContext : DbContext
    {
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<Commentary> Commentaries { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Rank> Ranks { get; set; }
        public DbSet<Mouse> Mouses { get; set; }
        public DbSet <Screen> Screens { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<CriticalStock> CriticalStocks { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<Connector> Connectors { get; set; }
        public DbSet<Cpu> Cpus { get; set; }
        public DbSet<GraphicProduct> GraphicProducts { get; set; }
        public DbSet <HardDisk> HardDisks { get; set; }
        public DbSet<Memory> Memories { get; set; } 
        public DbSet<Os> Oss { get; set; }
        public DbSet<PowerSupply> PowerSupplies { get; set; }
        public DbSet<Sound> Sounds { get; set; }
        public DbSet<Computer> Computers { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            MySqlServerVersion v = new MySqlServerVersion(new System.Version(10, 4, 19));
            optionsBuilder.UseMySql(@"server = localhost; user id = user;port = 9906; database = qual_it;password = password", v);
            optionsBuilder.EnableSensitiveDataLogging();
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
