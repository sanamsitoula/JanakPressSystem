using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecom.Models
{
    public class JobTicket
    {
        [Key]
        public int Id { get; set; }
        public required string Name { get; set; } // 
        public int ?PageNumber{ get; set; }//
        public int ?PrintTarget { get; set; }
        public DateTimeOffset ?JobDate { get; set; }
        public DateTimeOffset ?JobStartDate { get; set; }
        public DateTimeOffset ?JobCompleteDate { get; set; }

        [Required]
        public int ProductId { get; set; }
        [ForeignKey("ProductId")]
        public Product ?Product { get; set; }
        public int ?LotNumber { get; set; }
        [Required]
        public int JobTypeId { get; set; }
        [ForeignKey("JobTypeId")]
        public JobType ?JobType { get; set; }

        public int? PrintAchieved { get; set; }
        public string? Desc { get; set; } // 

        public string? Remarks { get; set; }
      
        public bool? Status { get; set; }
        public int? CreatedBy { get; set; }
        public int? UpdatedBy { get; set;}
        public int? DeletedBy { get; set; }
        public DateTimeOffset? CreatedDate { get; set; }
        public int? FiscalYear { get; set; }
        public int? PrePrintSize { get; set; }
        public string ?JobStepId { get; set; }
        public JobStep ?JobStep { get; set; }


    }
}
