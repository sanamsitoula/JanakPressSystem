using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecom.Models
{
    public class P2M
    {
        [Key]
        public int Id { get; set; }
        public  string Name { get; set; }
        public string ?P2M_Code { get; set; }// 
     
        public int ?ProductId { get; set; }
        public Product ?Product { get; set; }
        [Required]
        public int ClassId { get; set; }
        public Class ?Class { get; set; }
        public DateTime? P2MDate { get; set; }
        public DateTime? ReportDate { get; set; }

        public int? PerPokaSize { get; set; }
        public int? PokaNumber { get; set; }
        public int? ProductQuantity { get; set; }

        public int? PiecesQuantity { get; set; } //khaudra
        public int? TotalProductQuantity { get; set; }

       
        public string? JobStepId { get; set; }
        public JobStep? JobStep { get; set; }
        
        public bool? Status { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public string? Desc { get; set; } // 
        public string? Remarks { get; set; }
        public int? CheckedById { get; set; }
        public int? VerifiedById { get; set; }
        public int? ReceivedById { get; set; }
        public int? FiscalYear { get; set; }
    }
}
