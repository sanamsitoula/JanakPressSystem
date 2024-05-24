using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;



namespace Ecom.Models
{
    public class ReportViewModel
    {
        public string SearchString { get; set; }
        public int? ClassId { get; set; }
        public int? ProductId { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public List<P2M> P2MList { get; set; }
        public SelectList ClassList { get; set; }
    }
}
