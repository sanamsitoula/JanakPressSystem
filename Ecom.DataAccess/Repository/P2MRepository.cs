
using Ecom.DataAccess.Data;
using Ecom.DataAccess.Repository.IRepository;
using Ecom.Models;

namespace Ecom.DataAccess.Repository
{
    public class P2MRepository : Repository<P2M>, IP2MRepository
    {
        private ApplicationDBContext _db;
        public P2MRepository(ApplicationDBContext db) : base(db)
        {
            _db = db;
        }
       
  

        public void Update(P2M P2M)
        {
           _db.P2M.Update(P2M);
        }

     
    }
}
