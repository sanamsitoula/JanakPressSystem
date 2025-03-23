namespace Ecom.WebApp.Areas.Admin.ViewModels.FormaViewModel;

public class FormaViewModel
{
    public int Id { get; set; }

    public string Name { get; set; } // TA-24, 53-84 
    public int ?Page { get; set; }//332
    public int ?PrintTarget { get; set; }
    public int ?PrintAchieved { get; set; } 
    public string ?AssociatedForma { get; set; }
    public string ?Remarks { get; set; }
    public bool ?Status { get; set; }
    public  string Product { get; set; }
    public int ProductId { get; set; }
    public string ?Code { get; set; }
}