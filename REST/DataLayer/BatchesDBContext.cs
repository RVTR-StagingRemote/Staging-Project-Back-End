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

    private readonly IConfiguration config;


    public BatchesDBContext(DbContextOptions options, IConfiguration config) : base(options)
    {
      this.config = config;
      
      // currently needed for databse seeding
      Database.EnsureCreated();
    }

    // TODO:  May not be neceassary, remove later if that's the case
    // protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    //           => optionsBuilder.UseNpgsql("Host=chunee.db.elephantsql.com;Port=5432;Database=fuscqkyo;Username=fuscqkyo;Password=h44EoNlnqesNQ9k_v_YNXuJsiXWqZCC3;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      modelBuilder.Entity<Courses>().HasData(
        new Courses
        {
          CourseId = 1,
          CourseName = ".Net",
          Description = ".Net Fullstack Course"
        },
            new Courses
            {
              CourseId = 2,
              CourseName = "Java",
              Description = "Java Fullstack Course"
            }
      );
    }
  }
}