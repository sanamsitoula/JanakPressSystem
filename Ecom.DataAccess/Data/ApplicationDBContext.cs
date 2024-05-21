using Ecom.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Ecom.DataAccess.Data
{
    public class ApplicationDBContext: IdentityDbContext<IdentityUser>
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
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<FiscalYear> FiscalYear { get; set; }
        public DbSet<MachineJob> MachineJobs { get; set; }
        public DbSet<P2M> P2M { get; set; }
        public DbSet<DropdownV> DropdownV { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<FiscalYear>().HasData(
          new FiscalYear { Id = 1, Name = "2080" },
    new FiscalYear { Id = 2, Name = "2081" },
      new FiscalYear
      {
          Id = 3,
          Name = "2082"
      });

            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "NEB", Description = "NEB", DisplayOrder = 1, Status = true, CreatedBy = "1", CreatedDate = DateTime.Now },
          new Category { Id = 2, Name = "HSEB", Description = "HSEB", DisplayOrder = 3, Status = true, CreatedBy = "1", CreatedDate = DateTime.Now },
           new Category { Id = 3, Name = "SLC", Description = "SLC", DisplayOrder = 3, Status = true, CreatedBy = "1", CreatedDate = DateTime.Now },
            new Category { Id = 4, Name = "Book", Description = "Book", DisplayOrder = 3, Status = true, CreatedBy = "1", CreatedDate = DateTime.Now },
             new Category { Id = 5, Name = "Exercise Book", Description = "Exercise Book", DisplayOrder = 3, Status = true, CreatedBy = "1", CreatedDate = DateTime.Now },
              new Category { Id = 6, Name = "Jhura Kagaj", Description = "Jhura Kagaj", DisplayOrder = 3, Status = true, CreatedBy = "1", CreatedDate = DateTime.Now },
               new Category { Id = 7, Name = "Kawadi", Description = "Kawadi", DisplayOrder = 3, Status = true, CreatedBy = "1", CreatedDate = DateTime.Now },
              new Category { Id = 8, Name = "Religious", Description = "Religious", DisplayOrder = 3, Status = true, CreatedBy = "1", CreatedDate = DateTime.Now },
            new Category { Id = 9, Name = "Election", Description = "Election", DisplayOrder = 2, Status = true, CreatedBy = "1", CreatedDate = DateTime.Now });



             modelBuilder.Entity<Subject>().HasData(
               new Subject { Id = 1, Name = "Math"},
         new Subject { Id = 2, Name = "Science" },
           new Subject { Id = 3, Name = "Nepali"
           });

            modelBuilder.Entity<JobType>().HasData(
              new JobType { Id = 1, Name = "Pre-Press" },
        new JobType { Id = 2, Name = "Press" },
          new JobType
          {
              Id = 3,
              Name = "Post-Press"
          });

            modelBuilder.Entity<Machinary>().HasData(
       new JobType { Id = 1, Name = "Oliver " },
 new JobType { Id = 2, Name = "RMGT" },
   new JobType
   {
       Id = 3,
       Name = "NaphA"
   });


            modelBuilder.Entity<Class>().HasData(
              new Class { Id = 1, Name = "One" },
        new Class { Id = 2, Name = "Two" },
          new Class
          {
              Id = 3,
              Name = "Three"
          });
            // Seed data for Product entity
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Title = "Product 1",
                    Description = "Description 1",
                    ISBN = "ISBN-1",
                    Author = "Author 1",
                    BasePrice = 100.0,
                    CostPrice = 50.0,
                    Status = true,
                    CreatedBy = "Admin",
                    CategoryId = 1,
                    ImageURL = "http://example.com/product1.jpg",
                    FiscalYear = 2080,
                    PageNumber = 100,
                    SubjectId = 1,
                    ClassId = 1,
                   
                    SubjectLanguageId = "1",
                    SubjectTypeId = "1"
                },
                new Product
                {
                    Id = 2,
                    Title = "Product 2",
                    Description = "Description 2",
                    ISBN = "ISBN-2",
                    Author = "Author 2",
                    BasePrice = 200.0,
                    CostPrice = 150.0,
                    Status = true,
                    CreatedBy = "Admin",
                    CategoryId = 2,
                    ImageURL = "http://example.com/product2.jpg",
                    FiscalYear = 2081,
                    PageNumber = 200,
                    SubjectId = 2,
                    ClassId = 2,
                 //   FormaAssociation = "FormA2",
                 //   FormaListId = "2",
                  //  FormaNames = "FormB",
                    SubjectLanguageId = "2",
                    SubjectTypeId = "2"
                },
                 new Product
                 {
                     Id = 3,
                     Title = "Product 3",
                     Description = "Description 1",
                     ISBN = "ISBN-1",
                     Author = "Author 1",
                     BasePrice = 100.0,
                     CostPrice = 50.0,
                     Status = true,
                     CreatedBy = "Admin",
                     CategoryId = 1,
                     ImageURL = "http://example.com/product1.jpg",
                     FiscalYear = 2080,
                     PageNumber = 100,
                     SubjectId = 1,
                     ClassId = 1,

                     SubjectLanguageId = "1",
                     SubjectTypeId = "1"
                 }
                // Add more seed data as required
            );

            modelBuilder.Entity<Forma>().HasData(
              new Forma { Id = 1, Name = "TA-32",ProductId=1 },
        new Forma { Id = 2, Name = "33-40", ProductId = 1 },
        new Forma { Id = 3, Name = "41-51", ProductId = 1 },
        new Forma { Id = 4, Name = "52-62", ProductId = 1 },
          new Forma
          {
              Id = 5,
              Name = "64-93",
              ProductId = 1
          });

            modelBuilder.Entity<JobTicket>().HasData(
           new JobTicket { Id = 1, Name = "Job 1", PageNumber = 1, PrintTarget = 1000, JobDate = new DateTimeOffset(new DateTime(2024, 1, 1, 10, 0, 0, DateTimeKind.Utc)), JobStartDate = new DateTimeOffset(new DateTime(2024, 1, 1, 10, 0, 0, DateTimeKind.Utc)), JobCompleteDate = new DateTimeOffset(new DateTime(2024, 1, 1, 18, 0, 0, DateTimeKind.Utc)), ProductId = 1, LotNumber = 100, JobTypeId = 1, PrintAchieved = 950, Desc = "Description 1", Remarks = "Remarks 1", Status = true, CreatedBy = 1, UpdatedBy = 1, CreatedDate = new DateTimeOffset(new DateTime(2024, 1, 1, 9, 0, 0, DateTimeKind.Utc)), FiscalYearId = 1, PrePrintSize = 50,  JobStepId = "Step1" },
           new JobTicket { Id = 2, Name = "Job 2", PageNumber = 2, PrintTarget = 2000, JobDate = new DateTimeOffset(new DateTime(2024, 1, 2, 10, 0, 0, DateTimeKind.Utc)), JobStartDate = new DateTimeOffset(new DateTime(2024, 1, 2, 10, 0, 0, DateTimeKind.Utc)), JobCompleteDate = new DateTimeOffset(new DateTime(2024, 1, 2, 18, 0, 0, DateTimeKind.Utc)), ProductId = 2, LotNumber = 101, JobTypeId = 1, PrintAchieved = 1900, Desc = "Description 2", Remarks = "Remarks 2", Status = true, CreatedBy = 2, UpdatedBy = 2, CreatedDate = new DateTimeOffset(new DateTime(2024, 1, 2, 9, 0, 0, DateTimeKind.Utc)), FiscalYearId = 2, PrePrintSize = 100,  JobStepId = "Step2" },
           new JobTicket { Id = 3, Name = "Job 3", PageNumber = 3, PrintTarget = 3000, JobDate = new DateTimeOffset(new DateTime(2024, 1, 3, 10, 0, 0, DateTimeKind.Utc)), JobStartDate = new DateTimeOffset(new DateTime(2024, 1, 3, 10, 0, 0, DateTimeKind.Utc)), JobCompleteDate = new DateTimeOffset(new DateTime(2024, 1, 3, 18, 0, 0, DateTimeKind.Utc)), ProductId = 3, LotNumber = 102, JobTypeId = 1, PrintAchieved = 2850, Desc = "Description 3", Remarks = "Remarks 3", Status = true, CreatedBy = 3, UpdatedBy = 3, CreatedDate = new DateTimeOffset(new DateTime(2024, 1, 3, 9, 0, 0, DateTimeKind.Utc)), FiscalYearId = 3, PrePrintSize = 150, JobStepId = "Step3" },
           new JobTicket { Id = 4, Name = "Job 4", PageNumber = 4, PrintTarget = 4000, JobDate = new DateTimeOffset(new DateTime(2024, 1, 4, 10, 0, 0, DateTimeKind.Utc)), JobStartDate = new DateTimeOffset(new DateTime(2024, 1, 4, 10, 0, 0, DateTimeKind.Utc)), JobCompleteDate = new DateTimeOffset(new DateTime(2024, 1, 4, 18, 0, 0, DateTimeKind.Utc)), ProductId = 1, LotNumber = 103, JobTypeId = 1, PrintAchieved = 3800, Desc = "Description 4", Remarks = "Remarks 4", Status = true, CreatedBy = 4, UpdatedBy = 4, CreatedDate = new DateTimeOffset(new DateTime(2024, 1, 4, 9, 0, 0, DateTimeKind.Utc)), FiscalYearId = 1, PrePrintSize = 200, JobStepId = "Step4" },
           new JobTicket { Id = 5, Name = "Job 5", PageNumber = 5, PrintTarget = 5000, JobDate = new DateTimeOffset(new DateTime(2024, 1, 5, 10, 0, 0, DateTimeKind.Utc)), JobStartDate = new DateTimeOffset(new DateTime(2024, 1, 5, 10, 0, 0, DateTimeKind.Utc)), JobCompleteDate = new DateTimeOffset(new DateTime(2024, 1, 5, 18, 0, 0, DateTimeKind.Utc)), ProductId = 2, LotNumber = 104, JobTypeId = 2, PrintAchieved = 4750, Desc = "Description 5", Remarks = "Remarks 5", Status = true, CreatedBy = 1, UpdatedBy = 1, CreatedDate = new DateTimeOffset(new DateTime(2024, 1, 5, 9, 0, 0, DateTimeKind.Utc)), FiscalYearId = 2, PrePrintSize = 250,  JobStepId = "Step5" },
           new JobTicket { Id = 6, Name = "Job 6", PageNumber = 6, PrintTarget = 6000, JobDate = new DateTimeOffset(new DateTime(2024, 1, 6, 10, 0, 0, DateTimeKind.Utc)), JobStartDate = new DateTimeOffset(new DateTime(2024, 1, 6, 10, 0, 0, DateTimeKind.Utc)), JobCompleteDate = new DateTimeOffset(new DateTime(2024, 1, 6, 18, 0, 0, DateTimeKind.Utc)), ProductId = 3, LotNumber = 105, JobTypeId = 2, PrintAchieved = 5700, Desc = "Description 6", Remarks = "Remarks 6", Status = true, CreatedBy = 1, UpdatedBy = 2, CreatedDate = new DateTimeOffset(new DateTime(2024, 1, 6, 9, 0, 0, DateTimeKind.Utc)), FiscalYearId = 3, PrePrintSize = 300, JobStepId = "Step6" },
           new JobTicket { Id = 7, Name = "Job 7", PageNumber = 7, PrintTarget = 7000, JobDate = new DateTimeOffset(new DateTime(2024, 1, 7, 10, 0, 0, DateTimeKind.Utc)), JobStartDate = new DateTimeOffset(new DateTime(2024, 1, 7, 10, 0, 0, DateTimeKind.Utc)), JobCompleteDate = new DateTimeOffset(new DateTime(2024, 1, 7, 18, 0, 0, DateTimeKind.Utc)), ProductId = 3, LotNumber = 106, JobTypeId = 2, PrintAchieved = 6650, Desc = "Description 7", Remarks = "Remarks 7", Status = true, CreatedBy = 1, UpdatedBy = 1, CreatedDate = new DateTimeOffset(new DateTime(2024, 1, 7, 9, 0, 0, DateTimeKind.Utc)), FiscalYearId = 1, PrePrintSize = 350, JobStepId = "Step7" },
           new JobTicket { Id = 8, Name = "Job 8", PageNumber = 8, PrintTarget = 8000, JobDate = new DateTimeOffset(new DateTime(2024, 1, 8, 10, 0, 0, DateTimeKind.Utc)), JobStartDate = new DateTimeOffset(new DateTime(2024, 1, 8, 10, 0, 0, DateTimeKind.Utc)), JobCompleteDate = new DateTimeOffset(new DateTime(2024, 1, 8, 18, 0, 0, DateTimeKind.Utc)), ProductId = 3, LotNumber = 107, JobTypeId = 2, PrintAchieved = 7600, Desc = "Description 8", Remarks = "Remarks 8", Status = true, CreatedBy = 1, UpdatedBy = 2, CreatedDate = new DateTimeOffset(new DateTime(2024, 1, 8, 9, 0, 0, DateTimeKind.Utc)), FiscalYearId = 2, PrePrintSize = 400,  JobStepId = "Step8" },
           new JobTicket { Id = 9, Name = "Job 9", PageNumber = 9, PrintTarget = 9000, JobDate = new DateTimeOffset(new DateTime(2024, 1, 9, 10, 0, 0, DateTimeKind.Utc)), JobStartDate = new DateTimeOffset(new DateTime(2024, 1, 9, 10, 0, 0, DateTimeKind.Utc)), JobCompleteDate = new DateTimeOffset(new DateTime(2024, 1, 9, 18, 0, 0, DateTimeKind.Utc)), ProductId = 3, LotNumber = 108, JobTypeId = 2, PrintAchieved = 8550, Desc = "Description 9", Remarks = "Remarks 9", Status = true, CreatedBy = 1, UpdatedBy = 1, CreatedDate = new DateTimeOffset(new DateTime(2024, 1, 9, 9, 0, 0, DateTimeKind.Utc)), FiscalYearId = 3, PrePrintSize = 450,  JobStepId = "Step9" }
       );
            // Seed data for MachineJob
            modelBuilder.Entity<MachineJob>().HasData(
                new MachineJob
                {
                    Id = 1,
                    Name = "Machine Job 1",
                    ProductId = 1,
                    JobTicketId = 1,
                    MachinaryId = 1,
                    FormaId = 1,
                    JobDate = DateTime.UtcNow,
                    ReportDate = DateTime.UtcNow.AddDays(1),
                    FormaPageSize = 10,
                    JobQuantity = 10,
                    JobTypeId = 1,
                    JobStepId = "Step1",
                    ShiftId = "Shift1",
                    ShiftDurationId = "Duration1",
                    Status = true,
                    CreatedBy = 1,
                    CreatedDate = DateTime.UtcNow,
                    UpdatedBy = 1,
                    Desc = "Description 1",
                    Remarks = "Remarks 1",
                    SupervisorId = 1,
                    InchargeId = 1
                },
                new MachineJob
                {
                    Id = 2,
                    Name = "Machine Job 2",
                    ProductId = 2,
                    JobTicketId = 2,
                    MachinaryId = 2,
                    FormaId = 2,
                    JobDate = DateTime.UtcNow,
                    ReportDate = DateTime.UtcNow.AddDays(2),
                    FormaPageSize = 10,
                    JobQuantity = 10,
                    JobTypeId = 2,
                    JobStepId = "Step2",
                    ShiftId = "Shift2",
                    ShiftDurationId = "Duration2",
                    Status = true,
                    CreatedBy = 2,
                    CreatedDate = DateTime.UtcNow,
                    UpdatedBy = 2,
                    Desc = "Description 2",
                    Remarks = "Remarks 2",
                    SupervisorId = 2,
                    InchargeId = 2
                }
                // Add more seed data as required
            );
            // Configuration for relationships with OnDelete behavior
            modelBuilder.Entity<MachineJob
                >(entity =>
            {
                entity.HasOne(mj => mj.Product)
                      .WithMany()
                      .HasForeignKey(mj => mj.ProductId)
                      .OnDelete(DeleteBehavior.NoAction);

                entity.HasOne(mj => mj.JobTicket)
                      .WithMany()
                      .HasForeignKey(mj => mj.JobTicketId)
                      .OnDelete(DeleteBehavior.Cascade);

                entity.HasOne(mj => mj.Machinary)
                      .WithMany()
                      .HasForeignKey(mj => mj.MachinaryId)
                      .OnDelete(DeleteBehavior.NoAction);

                entity.HasOne(mj => mj.Forma)
                      .WithMany()
                      .HasForeignKey(mj => mj.FormaId)
                      .OnDelete(DeleteBehavior.NoAction);

                entity.HasOne(mj => mj.JobType)
                      .WithMany()
                      .HasForeignKey(mj => mj.JobTypeId)
                      .OnDelete(DeleteBehavior.NoAction);

                
            });

            // Configuration for Product entity
            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasKey(p => p.Id);

                entity.Property(p => p.Title).IsRequired();

                entity.HasOne(p => p.Category)
                      .WithMany()
                      .HasForeignKey(p => p.CategoryId)
                      .OnDelete(DeleteBehavior.SetNull);

                entity.HasOne(p => p.Subject)
                      .WithMany()
                      .HasForeignKey(p => p.SubjectId)
                      .OnDelete(DeleteBehavior.SetNull);

                entity.HasOne(p => p.Class)
                      .WithMany()
                      .HasForeignKey(p => p.ClassId)
                      .OnDelete(DeleteBehavior.SetNull);

               
            });

            // Seed data for DropdownV entity
            modelBuilder.Entity<DropdownV>().HasData(
                new DropdownV
                {
                   Id= 1,
                    Para = "5",
                    Value = "5",
                    ParaModel = "PerPokaSize",
                    ParaId = 1001,
                    ParentParaId = 2001,
                    Remarks = "PerPokaSize",
                    Status = true
                },
                  new DropdownV
                  {
                      Id = 2,
                      Para = "10",
                      Value = "10",
                      ParaModel = "PerPokaSize",
                      ParaId = 1001,
                      ParentParaId = 2001,
                      Remarks = "PerPokaSize",
                      Status = true
                  },
                    new DropdownV
                    {
                        Id = 3,
                        Para = "15",
                        Value = "15",
                        ParaModel = "PerPokaSize",
                        ParaId = 1001,
                        ParentParaId = 2001,
                        Remarks = "PerPokaSize",
                        Status = true
                    },
                      new DropdownV
                      {
                          Id = 4,
                          Para = "20",
                          Value = "20",
                          ParaModel = "PerPokaSize",
                          ParaId = 1001,
                          ParentParaId = 2001,
                          Remarks = "PerPokaSize",
                          Status = true
                      },
                        new DropdownV
                        {
                            Id = 5,
                            Para = "25",
                            Value = "25",
                            ParaModel = "PerPokaSize",
                            ParaId = 1001,
                            ParentParaId = 2001,
                            Remarks = "PerPokaSize",
                            Status = true
                        }
                        ,
                        new DropdownV
                        {
                            Id = 6,
                            Para = "30",
                            Value = "30",
                            ParaModel = "PerPokaSize",
                            ParaId = 1001,
                            ParentParaId = 2001,
                            Remarks = "PerPokaSize",
                            Status = true
                        }
                        ,
                        new DropdownV
                        {
                            Id = 7,
                            Para = "35",
                            Value = "35",
                            ParaModel = "PerPokaSize",
                            ParaId = 1001,
                            ParentParaId = 2001,
                            Remarks = "PerPokaSize",
                            Status = true
                        },
                        new DropdownV
                        {
                            Id = 8,
                            Para = "40",
                            Value = "40",
                            ParaModel = "PerPokaSize",
                            ParaId = 1001,
                            ParentParaId = 2001,
                            Remarks = "PerPokaSize",
                            Status = true
                        },
                        new DropdownV
                        {
                            Id = 9,
                            Para = "45",
                            Value = "45",
                            ParaModel = "PerPokaSize",
                            ParaId = 1001,
                            ParentParaId = 2001,
                            Remarks = "PerPokaSize",
                            Status = true
                        },
                        new DropdownV
                        {
                            Id = 10,
                            Para = "50",
                            Value = "50",
                            ParaModel = "PerPokaSize",
                            ParaId = 1001,
                            ParentParaId = 2001,
                            Remarks = "PerPokaSize",
                            Status = true
                        }
                        ,
                        new DropdownV
                        {
                            Id = 11,
                            Para = "Male",
                            Value = "Male",
                            ParaModel = "Gender",
                            ParaId = 1002,
                            ParentParaId = 2002,
                            Remarks = "Gender",
                            Status = true
                        }
                        ,
                        new DropdownV
                        {
                            Id = 12,
                            Para = "Female",
                            Value = "Female",
                            ParaModel = "Gender",
                            ParaId = 1002,
                            ParentParaId = 2002,
                            Remarks = "Gender",
                            Status = true
                        }
                        ,
                        new DropdownV
                        {
                            Id = 13,
                            Para = "Others",
                            Value = "Others",
                            ParaModel = "Gender",
                            ParaId = 1002,
                            ParentParaId = 2002,
                            Remarks = "Gender",
                            Status = true
                        }
            );

 
            modelBuilder.Entity<IdentityUserRole<string>>().HasKey(u => new { u.UserId, u.RoleId });
            modelBuilder.Entity<IdentityUserLogin<string>>().HasNoKey();
            modelBuilder.Entity<IdentityUserToken<string>>().HasNoKey();
         //  modelBuilder.Entity<IdentityUserRole<string>>().HasNoKey();
          
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
