using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata;
using Yummer.Models;

public class ApplicationDbContext:DbContext
{
    public DbSet<Recipe> Recipe { get; set; }

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
    : base(options)
    { }

         protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
      
            //optionsBuilder.UseSqlServer(@"Server=localhost;Database=master;Trusted_Connection=True;");
        }
 
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

    }


}

