namespace Ecom.WebApp.Areas.Admin.ViewModels.MachineryViewModel;

public class MachineryViewModel
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string ?Description { get; set; }
    public bool? Status { get; set; }
    public string? JobStep { get; set; }
}