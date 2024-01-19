
using Ecom.DataAccess.Data;
using Ecom.DataAccess.Repository.IRepository;
using Ecom.Models;

namespace Ecom.DataAccess.Repository
{
    public class FormaRepository : Repository<Forma>, IFormaRepository
    {
        private ApplicationDBContext _db;
        public FormaRepository(ApplicationDBContext db) : base(db)
        {
            _db = db;
        }
       
  

        public void Update(Forma Forma)
        {
           _db.Forma.Update(Forma);
        }
    }
}
