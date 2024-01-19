using Ecom.Models;
using Microsoft.EntityFrameworkCore;

namespace Ecom.DataAccess.Data
{
    public class ApplicationDBContext: DbContext
    {
        // DB context is from EF
       public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options) 
        
       {
        
       }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Class> Class { get; set; }
        public DbSet<Forma> Forma { get; set; }
        public DbSet<JobTicket> JobTicket { get; set; }
        public DbSet<JobType> JobType { get; set; }
        public DbSet<Machinary> Machinary { get; set; }
        public DbSet<Subject> Subject { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           modelBuilder.Entity<Category>().HasData(
               new Category { Id = 1, Name = "Action", Description = "Action", DisplayOrder = 1, Status = true, CreatedBy = "1", CreatedDate = DateTime.Now },
         new Category { Id = 2, Name = "Tamil", Description = "Tamil", DisplayOrder = 3, Status = true, CreatedBy = "1", CreatedDate = DateTime.Now },
           new Category { Id = 3, Name = "Animation", Description = "Animation", DisplayOrder = 2, Status = true, CreatedBy = "1", CreatedDate = DateTime.Now }
             


               );
            //modelBuilder.Entity<Product>().HasData(
              
            //    new Product { 
            //        Id = 1,
            //        Title = "Action",
            //        Description = "Action",
            //        ISBN = "aa"
            //    },
            // new Product
            // {
            //     Id = 2,
            //     Title = "Acq22tion",
            //     Description = "Action",
            //     ISBN = "aa"
            // }, new Product
            // {
            //     Id = 3,
            //     Title = "Act3ion",
            //     Description = "Action",
            //     ISBN = "aa"
            // }, new Product
            // {
            //     Id = 4,
            //     Title = "4Action",
            //     Description = "4Action",
            //     ISBN = "aa"
            // }


            //   );
        }
    }
}
