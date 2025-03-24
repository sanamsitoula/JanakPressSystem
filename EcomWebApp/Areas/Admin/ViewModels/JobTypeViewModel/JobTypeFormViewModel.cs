using System.ComponentModel.DataAnnotations;

namespace Ecom.WebApp.Areas.Admin.ViewModels;

public class JobTypeFormViewModel
{
    [Required]
    public required string Name { get; set; }
    public string ?Description { get; set; }
}