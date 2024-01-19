using Ecom.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecom.DataAccess.Repository.IRepository
{
    public interface IJobTypeRepository : IRepository<JobType>
    {
        void Update(JobType JobType);
     
    }
    
}
