using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecom.Models
{
    public class DropdownV
    {
        [Key]
        public int Id { get; set; }
        public  string? Para { get; set; } // 
        public string? Value { get; set; } // 
        public string? ParaModel { get; set; } // 

        public int? ParaId { get; set; }//
        public int? ParentParaId { get; set; }//

        public string? Remarks { get; set; } // 
        public bool? Status { get; set; }

    }
}
