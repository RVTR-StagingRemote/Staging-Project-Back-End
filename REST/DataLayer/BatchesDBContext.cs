using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using REST.Models;

namespace REST.DataLayer
{
    public class BatchesDBContext : DbContext
    {
        public DbSet<Clients> Clients { get; set; }
        public DbSet<Occupations> Occupations { get; set; }
        public DbSet<OccupationsTopicsJoin> OccupationsTopicsJoins { get; set; }
        public DbSet<OrderDetails> OrderDetails { get; set; }
        public DbSet<Orders> Orders { get; set; }
        public DbSet<Topics> Topics { get; set; }
        public DbSet<User> Users { get; set; }


        public BatchesDBContext() { }


        public BatchesDBContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            /*   modelBuilder.Entity<Clients>()
                 .HasKey(cl => cl.ClientId);

               modelBuilder.Entity<Occupations>()
                .HasKey(c => c.OccupationId);

               modelBuilder.Entity<Orders>()
               .HasKey(o=> o.OrderId);

               modelBuilder.Entity<OrderDetails>()
              .HasKey(od => od.DetailsId);

               modelBuilder.Entity<Topics>()
              .HasKey(t => t.TopicId);

               modelBuilder.Entity<OccupationsTopicsJoin>()
             .HasKey(ctj => ctj.JoinId);*/


        }


    }
}