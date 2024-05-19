
using Ecom.DataAccess.Data;
using Ecom.DataAccess.Repository.IRepository;
using Ecom.Models;

namespace Ecom.DataAccess.Repository
{
    public class FiscalYearRepository : Repository<FiscalYear>, IFiscalYearRepository
    {
        private ApplicationDBContext _db;
        public FiscalYearRepository(ApplicationDBContext db) : base(db)
        {
            _db = db;
        }
       
  

        public void Update(FiscalYear FiscalYear)
        {
           _db.FiscalYear.Update(FiscalYear);
        }
    }
}
