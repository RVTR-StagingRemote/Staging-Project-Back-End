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
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
              => optionsBuilder.UseNpgsql(config.GetConnectionString("batchesDB"));
  }
}