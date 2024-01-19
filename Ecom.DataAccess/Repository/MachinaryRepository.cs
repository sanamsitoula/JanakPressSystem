
using Ecom.DataAccess.Data;
using Ecom.DataAccess.Repository.IRepository;
using Ecom.Models;

namespace Ecom.DataAccess.Repository
{
    public class MachinaryRepository : Repository<Machinary>, IMachinaryRepository
    {
        private ApplicationDBContext _db;
        public MachinaryRepository(ApplicationDBContext db) : base(db)
        {
            _db = db;
        }
       
  

        public void Update(Machinary Machinary)
        {
           _db.Machinary.Update(Machinary);
        }
    }
}
