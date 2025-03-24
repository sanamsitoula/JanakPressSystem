using System.ComponentModel.DataAnnotations;
using Ecom.Models;

namespace Ecom.WebApp.Areas.Admin.ViewModels.MachineJobViewModel;

public class MachineJobViewModel
{
    public int Id { get; set; }
    public  string Name { get; set; } // 
    public string Product { get; set; }
    public string JobTicket { get; set; }
        
    public string Machinary { get; set; }
    
    public string Forma { get; set; }

    public DateTime? JobDate { get; set; }
    public DateTime? ReportDate { get; set; }
    public int? FormaPageSize { get; set; }
    public int? JobQuantity { get; set; }
    public int? FormaTarget { get; set; }
    public string JobType { get; set; }
    public string? JobStep { get; set; }
    public string? Shift { get; set; }
    public string? ShiftDuration { get; set; }
    public bool? Status { get; set; }
    public int? CreatedBy { get; set; }
    public DateTimeOffset? CreatedDate { get; set; }
    public int? UpdatedBy { get; set; }
    public string? Desc { get; set; } // 
    public string? Remarks { get; set; }
    public string? Supervisor { get; set; }
    public string? Incharge { get; set; }
    public string? Operator { get; set; }
    public DateTimeOffset? FiscalYear { get; set; }
    public int? JobTicketTarget { get; set; }
}