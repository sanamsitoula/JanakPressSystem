
using Ecom.DataAccess.Data;
using Ecom.DataAccess.Repository.IRepository;
using Ecom.Models;

namespace Ecom.DataAccess.Repository
{
    public class JobTicketRepository : Repository<JobTicket>, IJobTicketRepository
    {
        private ApplicationDBContext _db;
        public JobTicketRepository(ApplicationDBContext db) : base(db)
        {
            _db = db;
        }
       
  

        public void Update(JobTicket JobTicket)
        {
           _db.JobTicket.Update(JobTicket);
        }
    }
}
