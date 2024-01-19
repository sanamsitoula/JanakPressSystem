
using Ecom.DataAccess.Data;
using Ecom.DataAccess.Repository.IRepository;
using Ecom.Models;

namespace Ecom.DataAccess.Repository
{
    public class SubjectRepository : Repository<Subject>, ISubjectRepository
    {
        private ApplicationDBContext _db;
        public SubjectRepository(ApplicationDBContext db) : base(db)
        {
            _db = db;
        }
       
  

        public void Update(Subject Subject)
        {
           _db.Subject.Update(Subject);
        }
    }
}
