using System.Linq;
using Microsoft.Extensions.Configuration;
using System.IO;
using Microsoft.EntityFrameworkCore;
using HelpAFamily.Models;

namespace HelpAFamily
{
    public class DataContext : DbContext
    {

        public static DbContextOptions<DataContext> DefaultOptions;

        public DataContext() : base()
        {

        }
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var cascadeFKs = modelBuilder.Model.GetEntityTypes()
             .SelectMany(t => t.GetForeignKeys())
             .Where(fk => !fk.IsOwnership && fk.DeleteBehavior == DeleteBehavior.Cascade);

            foreach (var fk in cascadeFKs)
                fk.DeleteBehavior = DeleteBehavior.Restrict;
            base.OnModelCreating(modelBuilder);


        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var a = Directory.GetCurrentDirectory();
                IConfigurationRoot configuration = new ConfigurationBuilder()
                   .SetBasePath(Directory.GetCurrentDirectory())
                   .AddJsonFile("appsettings.json")
                   .Build();
                //var connectionString = configuration.GetConnectionString("DefaultConnection");
                // install  Microsoft.EntityFrameworkCore.SqlServe  for this to works
                optionsBuilder.UseSqlServer(@"Server=.\; Database=HelpAFamily; Trusted_Connection=true;");
            }
        }

        public static DataContext Default
=> new DataContext(DefaultOptions);

        public DbSet<User> Users { get; set; }
        public DbSet<Ad> Ads { get; set; }

        public DbSet<Category> Categories { get; set; }

     

    }
}