using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecom.Models
{
    public class MachineJob
    {
        [Key]
        public int Id { get; set; }
        public  string Name { get; set; } // 
        [Required]
        public int ProductId { get; set; }
      
        public Product ?Product { get; set; }
        [Required]
        public int JobTicketId { get; set; }
        
        public JobTicket? JobTicket { get; set; }
        [Required]
        public int MachinaryId { get; set; }
       
        public Machinary? Machinary { get; set; }
        [Required]
        public int FormaId { get; set; }
        public Forma? Forma { get; set; }

        public DateTime? JobDate { get; set; }
        public DateTime? ReportDate { get; set; }
        public int? FormaPageSize { get; set; }
        public int? JobQuantity { get; set; }
        public int? FormaTarget { get; set; }
        [Required]
        public int JobTypeId { get; set; }
     
        public JobType? JobType { get; set; }
        public string? JobStepId { get; set; }
        public JobStep? JobStep { get; set; }
        public string? ShiftId { get; set; }
        public Shift? Shift { get; set; }
        public string? ShiftDurationId { get; set; }
        public ShiftDuration? ShiftDuration { get; set; }
        public bool? Status { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public string? Desc { get; set; } // 
        public string? Remarks { get; set; }
        public int? SupervisorId { get; set; }
        public int? InchargeId { get; set; }
        public int? OperatorId { get; set; }
    }
}
