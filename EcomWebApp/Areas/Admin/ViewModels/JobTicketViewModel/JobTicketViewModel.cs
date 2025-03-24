using System.Runtime.InteropServices.JavaScript;

namespace Ecom.WebApp.Areas.Admin.ViewModels.JobTicketViewModel;

public class JobTicketViewModel
{
    public required string Name { get; set; }
    public  string ?Code { get; set; } // }
    public int ?PageNumber{ get; set; }//
    public int ?PrintTarget { get; set; }
    public DateTimeOffset ?JobDate { get; set; }
    public DateTimeOffset ?JobStartDate { get; set; }
    public DateTimeOffset ?JobCompleteDate { get; set; }
    public string Product { get; set; }
    public int ?LotNumber { get; set; }
    public string ?JobType { get; set; }
    public int? PrintAchieved { get; set; }
    public string? Desc { get; set; } // 
    public string? Remarks { get; set; }
    public bool? Status { get; set; }
    public int? CreatedBy { get; set; }
    public int? UpdatedBy { get; set;}
    public int? DeletedBy { get; set; }
    public DateTimeOffset? CreatedDate { get; set; }
    public DateOnly? FiscalYear { get; set; }
    public int? PrePrintSize { get; set; }
    public string ?JobStep { get; set; }
    public int? NoOfAssociatedForma { get; set; }
}