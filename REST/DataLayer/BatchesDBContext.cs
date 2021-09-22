using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using REST.Models;

namespace REST.DataLayer
{
    public class BatchesDBContext : DbContext
    {
        public DbSet<Clients> Clients { get; set; }
        public DbSet<Courses> Courses { get; set; }
        public DbSet<CoursesTopicsJoin> CoursesTopicsJoins { get; set; }
        public DbSet<OrderDetails> OrderDetails { get; set; }
        public DbSet<Orders> Orders { get; set; }
        public DbSet<Topics> Topics { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<Employee> Employees { get; set; }

        public DbSet<EmployeeSkills> EmployeeSkills { get; set; }


        public BatchesDBContext() { }


        public BatchesDBContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            /*   modelBuilder.Entity<Clients>()
                 .HasKey(cl => cl.ClientId);

               modelBuilder.Entity<Courses>()
                .HasKey(c => c.CourseId);

               modelBuilder.Entity<Orders>()
               .HasKey(o=> o.OrderId);

               modelBuilder.Entity<OrderDetails>()
              .HasKey(od => od.DetailsId);

               modelBuilder.Entity<Topics>()
              .HasKey(t => t.TopicId);

               modelBuilder.Entity<CoursesTopicsJoin>()
             .HasKey(ctj => ctj.JoinId);*/


        }


    }
}