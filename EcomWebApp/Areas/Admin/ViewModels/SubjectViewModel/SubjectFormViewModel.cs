using System.ComponentModel.DataAnnotations;

namespace Ecom.WebApp.Areas.Admin.ViewModels.SubjectViewModel;

public class SubjectFormViewModel
{
    [Required]
    public string Name { get; set; }
    public string? Description { get; set; }
    public bool? status { get; set; }
}