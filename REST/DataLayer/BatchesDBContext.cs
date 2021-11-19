using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using REST.Models;

namespace REST.DataLayer
{
    public class BatchesDBContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<ApplicantOccupation> ApplicantOccupations { get; set; }
        public DbSet<Application> Applications { get; set; }
        public DbSet<Interview> Interviews { get; set; }
        public BatchesDBContext() { }


        public BatchesDBContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
              modelBuilder.Entity<User>()
              .Property(u=>u.UserId)
              .ValueGeneratedOnAdd();

              modelBuilder.Entity<ApplicantOccupation>()
              .Property(ao=>ao.ApplicantOccupationId)
              .ValueGeneratedOnAdd();

              modelBuilder.Entity<Application>()
              .Property(a=>a.ApplicationId)
              .ValueGeneratedOnAdd();

              modelBuilder.Entity<Interview>()
              .Property(i=>i.InterviewId)
              .ValueGeneratedOnAdd();
        }


    }
}