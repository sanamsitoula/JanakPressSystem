using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecom.Models
{
    public class FiscalYear
    {
        [Key]
        public int Id { get; set; }
        public  string Name { get; set; }
        public string ?Description { get; set; }
        public bool? Status { get; set; }
    }
}
