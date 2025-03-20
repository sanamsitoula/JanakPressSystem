using Ecom.Models;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.Rendering;

public class ProductFormViewModel
{
    public int? Id { get; set; }  
    public string Title { get; set; }
    public int CategoryId { get; set; }
    public int ClassId { get; set; }
    public int SubjectId { get; set; }
    public SubjectLanguage SubjectLanguageId { get; set; }  // Enum instead of int
    public SubjectType SubjectTypeId { get; set; }  // Enum instead of int
    public int FormaNumber { get; set; }
    public int PageNumber { get; set; }
    
    public string Image { get; set; }

    // Dropdown lists
    [BindNever]
    public IEnumerable<SelectListItem> Categories { get; set; }
    [BindNever]

    public IEnumerable<SelectListItem> Classes { get; set; }
    [BindNever]

    public IEnumerable<SelectListItem> Subjects { get; set; }
    [BindNever]

    public IEnumerable<SelectListItem> Formas { get; set; }
    [BindNever]

    public IEnumerable<SelectListItem> SubjectLanguages { get; set; }
    [BindNever]

    public IEnumerable<SelectListItem> SubjectTypes { get; set; }
}