using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using REST.Models;

namespace REST.DataLayer
{
    public class BatchesDBContext : DbContext
    {
        public DbSet<Applicant> Applicants { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Occupation> Occupations { get; set; }
        public DbSet<OccupationsTopicsJoin> OccupationsTopicsJoins { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderLine> OrderLines { get; set; }
        public DbSet<Owner> Owners { get; set; }
        public DbSet<Topic> Topics { get; set; }
        public BatchesDBContext() { }


        public BatchesDBContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Applicant>()
              .HasKey(a => a.Id);

            modelBuilder.Entity<Client>()
              .HasKey(cl => cl.Id);

              modelBuilder.Entity<Occupation>()
              .HasKey(c => c.Id);

              modelBuilder.Entity<Order>()
              .HasKey(o=> o.Id);

              modelBuilder.Entity<Owner>()
              .HasKey(ow => ow.Id);

              modelBuilder.Entity<Topic>()
              .HasKey(t => t.Id);

              modelBuilder.Entity<OccupationsTopicsJoin>()
              .HasKey(ctj => ctj.JoinId);



        }


    }
}