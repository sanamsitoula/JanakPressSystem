using Ecom.DataAccess.Data;
using Ecom.DataAccess.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecom.DataAccess.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private ApplicationDBContext _db;
       public ICategoryRepository Category { get; private set; }
        public IProductRepository Product { get; private set; }
        public IJobTypeRepository JobType { get; private set; }
        public IJobTicketRepository JobTicket { get; private set; }
        public ISubjectRepository Subject { get; private set; }
        public IClassRepository Class { get; private set; }
        public IMachinaryRepository Machinary { get; private set; }
        public IFormaRepository Forma { get; private set; }

        public UnitOfWork (ApplicationDBContext db) 
        {
            _db = db;
            Category = new CategoryRepository(_db);
            Product = new ProductRepository(_db);
            JobType = new JobTypeRepository(_db);
            JobTicket = new JobTicketRepository(_db);
            Subject = new SubjectRepository(_db);
            Class = new ClassRepository(_db);
            Machinary = new MachinaryRepository(_db);
            Forma = new FormaRepository(_db);



        }
        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
