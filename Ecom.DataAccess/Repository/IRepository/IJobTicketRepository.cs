using Ecom.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecom.DataAccess.Repository.IRepository
{
    public interface IJobTicketRepository : IRepository<JobTicket>
    {
        void Update(JobTicket JobTicket);
     
    }
    
}
