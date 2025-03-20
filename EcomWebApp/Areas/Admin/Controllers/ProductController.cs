using Ecom.DataAccess.Repository.IRepository;
using Ecom.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Ecom.Utility;
using Ecom.WebApp.Areas.Admin.ViewModels;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Ecom.WebApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public ProductController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public static List<SelectListItem> GetEnumSelectList<T>() where T : Enum
        {
            return Enum.GetValues(typeof(T))
                .Cast<T>()
                .Select(e => new SelectListItem
                {
                    Value = Convert.ToInt32(e).ToString(),
                    Text = e.ToString()
                }).ToList();
        }

        private IEnumerable<SelectListItem> GetSelectList<T>(
            IEnumerable<T> items, 
            string valueProperty, 
            string textProperty) 
            where T : class
        {
            return items.Select(i => new SelectListItem
            {
                Value = i.GetType().GetProperty(valueProperty)?.GetValue(i)?.ToString() ?? string.Empty,
                Text = i.GetType().GetProperty(textProperty)?.GetValue(i)?.ToString() ?? string.Empty
            });
        }


        public IActionResult Index()
        {
            
            var subjectLanguageType = typeof(SubjectLanguage);
            var subjectTypeType = typeof(SubjectType);

            var products = _unitOfWork.Product.GetAll()
                .Include(p => p.Category)
                .Include(p => p.Class)
                .Include(p => p.Subject)
                .Select(product => new ProductViewModel
                {
                    Id = product.Id,
                    Title = product.Title,
                    CategoryName = product.Category.Name ?? "N/A",
                    ClassName = product.Class.Name ?? "N/A",
                    SubjectName = product.Subject.Name ?? "N/A",
                    SubjectLanguage = product.SubjectLanguageId.ToString(),
                    SubjectType = product.SubjectTypeId.ToString(),
                    FormaNumber = product.FormaNumber,
                    PageNumber = product.PageNumber,
                    Description = product.Description
                }).ToList();

            return View(products);
        }

        public IActionResult Create()
        {
            var viewModel = new ProductFormViewModel
            {
                Categories = GetSelectList(_unitOfWork.Category.GetAll(), "Id", "Name"),
                Classes = GetSelectList(_unitOfWork.Class.GetAll(), "Id", "Name"),
                Subjects = GetSelectList(_unitOfWork.Subject.GetAll(), "Id", "Name"),
                Formas = GetSelectList(_unitOfWork.Forma.GetAll(), "Id", "Name"),
                SubjectLanguages = GetEnumSelectList<SubjectLanguage>(),  
                SubjectTypes = GetEnumSelectList<SubjectType>()   
                
            };

            return View(viewModel);
        }

        [HttpPost]
        public IActionResult Create(ProductFormViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                PopulateDropdowns(viewModel);
                return View(viewModel);
            }

            var product = new Product
            {
                Title = viewModel.Title,
                CategoryId = viewModel.CategoryId,
                ClassId = viewModel.ClassId,
                SubjectId = viewModel.SubjectId,
                FormaNumber = viewModel.FormaNumber,
                PageNumber = viewModel.PageNumber,
                SubjectLanguageId = viewModel.SubjectLanguageId,
                SubjectTypeId = viewModel.SubjectTypeId,
                Description = "PRO-" + DateTime.Now.Year + "-" + DateTime.Now.Month + "-" + UniqueCodeGenerator.GenerateUniqueCodeFromTimestamp()
            };

            _unitOfWork.Product.Add(product);
            _unitOfWork.Save();
            TempData["success"] = "Product created successfully";

            return RedirectToAction(nameof(Index));
        }

        public IActionResult Edit(int id)
        {
            var product = _unitOfWork.Product.GetFirstOrDefault(p => p.Id == id);
            if (product == null) return NotFound();

            var viewModel = new ProductFormViewModel
            {
                Id = product.Id,
                Title = product.Title,
                CategoryId = product.CategoryId ?? 0,
                ClassId = product.ClassId ?? 0,
                SubjectId = product.SubjectId ?? 0,
                FormaNumber = product.FormaNumber,
                PageNumber = product.PageNumber,
                SubjectLanguageId = product.SubjectLanguageId,
                SubjectTypeId = product.SubjectTypeId,
                Image = product.ImageURL,
                Categories = GetSelectList(_unitOfWork.Category.GetAll(), "Id", "Name"),
                Classes = GetSelectList(_unitOfWork.Class.GetAll(), "Id", "Name"),
                Subjects = GetSelectList(_unitOfWork.Subject.GetAll(), "Id", "Name"),
                Formas = GetSelectList(_unitOfWork.Forma.GetAll(), "Id", "Name"),
                SubjectLanguages = GetEnumSelectList<SubjectLanguage>(),  
                SubjectTypes = GetEnumSelectList<SubjectType>()   
            };

            return View(viewModel);
        }

        [HttpPost]
        public IActionResult Edit(ProductFormViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                TempData["error"] = "Product failed successfully";
                foreach (var error in ModelState)
                {
                    TempData["error"] = error;
                    Console.WriteLine(error);
                    foreach (var e in error.Value.Errors)
                    {
                        TempData["error"] = e;
                        Console.WriteLine(e);
                    }

                }
                PopulateDropdowns(viewModel);
                return View(viewModel);
            }

            var product = _unitOfWork.Product.GetFirstOrDefault(p => p.Id == viewModel.Id);
            if (product == null) return NotFound();

            product.Title = viewModel.Title;
            product.CategoryId = viewModel.CategoryId;
            product.ClassId = viewModel.ClassId;
            product.SubjectId = viewModel.SubjectId;
            product.FormaNumber = viewModel.FormaNumber;
            product.PageNumber = viewModel.PageNumber;
            product.SubjectLanguageId = viewModel.SubjectLanguageId;
            product.SubjectTypeId = viewModel.SubjectTypeId;
            product.ImageURL = viewModel.Image;
            

            _unitOfWork.Product.Update(product);
            _unitOfWork.Save();
            TempData["success"] = "Product updated successfully";

            return RedirectToAction(nameof(Index));
        }

        public IActionResult Delete(int id)
        {
            var product = _unitOfWork.Product.GetFirstOrDefault(p => p.Id == id);
            if (product == null) return NotFound();

            return View(product);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            var product = _unitOfWork.Product.GetFirstOrDefault(p => p.Id == id);
            if (product == null) return NotFound();

            _unitOfWork.Product.Remove(product);
            _unitOfWork.Save();
            TempData["success"] = "Product deleted successfully";

            return RedirectToAction(nameof(Index));
        }

 
        private void PopulateDropdowns(ProductFormViewModel viewModel)
        {
            viewModel.Categories = GetSelectList(_unitOfWork.Category.GetAll() , "Id", "Name");
            viewModel.Classes = GetSelectList(_unitOfWork.Class.GetAll(), "Id", "Name");
            viewModel.Subjects = GetSelectList(_unitOfWork.Subject.GetAll(), "Id", "Name");
            viewModel.Formas = GetSelectList(_unitOfWork.Forma.GetAll(), "Id", "Name");
            viewModel.SubjectTypes = GetEnumSelectList<SubjectType>();
            viewModel.SubjectLanguages = GetEnumSelectList<SubjectLanguage>();
        }
    }
    
    
}
