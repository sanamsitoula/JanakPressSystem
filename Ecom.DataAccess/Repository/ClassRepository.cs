
using Ecom.DataAccess.Data;
using Ecom.DataAccess.Repository.IRepository;
using Ecom.Models;

namespace Ecom.DataAccess.Repository
{
    public class ClassRepository : Repository<Class>, IClassRepository
    {
        private ApplicationDBContext _db;
        public ClassRepository(ApplicationDBContext db) : base(db)
        {
            _db = db;
        }
       
  

        public void Update(Class Class)
        {
           _db.Class.Update(Class);
        }
    }
}
