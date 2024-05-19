using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecom.DataAccess.Repository.IRepository
{
    public  interface IUnitOfWork
    {
        ICategoryRepository Category{ get; }
        IProductRepository Product { get; }
        IClassRepository Class { get; }
        ISubjectRepository Subject { get; }
        IJobTypeRepository JobType { get; }
        IJobTicketRepository JobTicket { get; }
        IFormaRepository Forma { get; }
        IMachinaryRepository Machinary { get; }
        IFiscalYearRepository FiscalYear { get; }
        IMachineJobRepository MachineJob { get; }
        IP2MRepository P2M { get; }

        void Save();
    }
}
