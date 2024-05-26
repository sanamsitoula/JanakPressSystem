using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Ecom.Models
{
    public class Forma
    {
        public int Id { get; set; }
        public required string Name { get; set; } // TA-24, 53-84 
        public int ?Page { get; set; }//332
        public int ?PrintTarget { get; set; }
        public int ?PrintAchieved { get; set; } 
        public string ?AssociatedFormaId { get; set; }
        public string ?Remarks { get; set; }
        public bool ?Status { get; set; }
        public  int ProductId { get; set; }
        public string ?Code { get; set; }

        public Product? Product { get; set; }


    }

    public class JobTicketForma
    {

        public List<JobTicket> jobstick { get; set; }
        public List<Forma> forma { get; set; }
        public List<Product> ?product { get; set; }
    }
}
