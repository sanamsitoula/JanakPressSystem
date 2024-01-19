
using Ecom.DataAccess.Data;
using Ecom.DataAccess.Repository.IRepository;
using Ecom.Models;

namespace Ecom.DataAccess.Repository
{
    public class JobTypeRepository : Repository<JobType>, IJobTypeRepository
    {
        private ApplicationDBContext _db;
        public JobTypeRepository(ApplicationDBContext db) : base(db)
        {
            _db = db;
        }
       
  

        public void Update(JobType JobType)
        {
           _db.JobType.Update(JobType);
        }
    }
}
