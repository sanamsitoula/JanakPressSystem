
using Ecom.DataAccess.Data;
using Ecom.DataAccess.Repository.IRepository;
using Ecom.Models;

namespace Ecom.DataAccess.Repository
{
    public class MachineJobRepository : Repository<MachineJob>, IMachineJobRepository
    {
        private ApplicationDBContext _db;
        public MachineJobRepository(ApplicationDBContext db) : base(db)
        {
            _db = db;
        }
       
  

        public void Update(MachineJob MachineJob)
        {
           _db.MachineJobs.Update(MachineJob);
        }
    }
}
