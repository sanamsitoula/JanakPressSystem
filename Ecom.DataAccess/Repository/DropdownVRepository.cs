
using Ecom.DataAccess.Data;
using Ecom.DataAccess.Repository.IRepository;
using Ecom.Models;

namespace Ecom.DataAccess.Repository
{
    public class DropdownVRepository : Repository<DropdownV>, IDropdownVRepository
    {
        private ApplicationDBContext _db;
        public DropdownVRepository(ApplicationDBContext db) : base(db)
        {
            _db = db;
        }
       
  

        public void Update(DropdownV DropdownV)
        {
           _db.DropdownV.Update(DropdownV);
        }
    }
}
