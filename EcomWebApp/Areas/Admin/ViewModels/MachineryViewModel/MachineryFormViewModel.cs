using System.ComponentModel.DataAnnotations;

namespace Ecom.WebApp.Areas.Admin.ViewModels.MachineryViewModel;

public class MachineryFormViewModel
{
    [Required]
    public string Name { get; set; }
    public string ?Description { get; set; }
    public bool? Status { get; set; }
    public string? JobStep { get; set; }
}