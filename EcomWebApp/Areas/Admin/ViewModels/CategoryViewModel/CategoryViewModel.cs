namespace Ecom.WebApp.Areas.Admin.ViewModels.CategoryViewModel;

public class CategoryViewModel
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public string ?Description { get; set; }
}