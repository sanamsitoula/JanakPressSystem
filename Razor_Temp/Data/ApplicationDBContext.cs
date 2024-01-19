using Microsoft.EntityFrameworkCore;
using Razor_Temp.Models;

namespace Razor_Temp.Data
{
    public class ApplicationDBContext : DbContext
    {
        // DB context is from EF
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)

        {

        }

        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Action", Description = "Action", DisplayOrder = 1, Status = true, CreatedBy = "1", CreatedDate = DateTime.Now },
          new Category { Id = 2, Name = "Tamil", Description = "Tamil", DisplayOrder = 3, Status = true, CreatedBy = "1", CreatedDate = DateTime.Now },
            new Category { Id = 3, Name = "Animation", Description = "Animation", DisplayOrder = 2, Status = true, CreatedBy = "1", CreatedDate = DateTime.Now }



                );
        }
    }
}
