using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecom.Models
{
    public class ReportViewModel
    {
        public IEnumerable<P2M> P2MList { get; set; }
        public List<Class> ClassList { get; set; }
    }
}
