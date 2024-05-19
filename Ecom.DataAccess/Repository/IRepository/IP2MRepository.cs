using Ecom.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecom.DataAccess.Repository.IRepository
{
    public interface IP2MRepository : IRepository<P2M>
    {
        void Update(P2M P2M);
     
    }
    
}
