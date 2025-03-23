using Ecom.DataAccess.Data;
using Ecom.DataAccess.Repository.IRepository;
using Ecom.Models;
using Ecom.Utility;
using Ecom.WebApp.Areas.Admin.ViewModels.FormaViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace Ecom.WebApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class FormaController : Controller
    {
      
        private readonly IUnitOfWork _unitOfWork;
        public FormaController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;

        }
        public IActionResult Index()
        {
            List<FormaViewModel>? objProductList = _unitOfWork.Forma.
                GetAll().Include(f=> f.Product)
            .Select(forma => new FormaViewModel
                {
                    Id = forma.Id,
                    Name = forma.Name,
                    Page = forma.Page,
                    PrintTarget = forma.PrintTarget,
                    PrintAchieved = forma.PrintAchieved,
                    AssociatedForma = forma.AssociatedFormaId,
                    Remarks = forma.Remarks,
                    Status = forma.Status,
                    Product = forma.Product.Title,
                    ProductId = forma.ProductId,
                    Code = forma.Code
                })
            .ToList();
            
            return View(objProductList);
        }

        public IActionResult Create()
        {
            var selectItems = GetProductList();
            // Convert the List<Forma>? to IEnumerable<SelectListItem>
            
            ViewBag.productlist = selectItems;

            return View();
        }
        [HttpPost]
        public IActionResult Create(Forma obj)
        {
          
           

            if (ModelState.IsValid)
            {
                obj.Code = "F-" + obj.Name+"-"+ DateTime.Now.Year + "-" + DateTime.Now.Month + "-" + UniqueCodeGenerator.GenerateUniqueCodeFromTimestamp();

                obj.Status = true;
              
                _unitOfWork.Forma.Add(obj);
                _unitOfWork.Save();
                TempData["success"] = "Forma Created Sucessfully";
                return RedirectToAction("Index", "Forma");
            }

            return View();
        }


        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            Forma obj = _unitOfWork.Forma
                .GetFirstOrDefault(o => o.Id == id, o=>o.Product);
            if (obj == null) { return NotFound(); }

            var productId = obj.Product.Id;
            FormaFormViewModel ffvm = new FormaFormViewModel
            {
                Name = obj.Name,
                Page = obj.Page,
                PrintTarget = obj.PrintTarget,
                PrintAchieved = obj.PrintAchieved,
                AssociatedForma = obj.AssociatedFormaId,
                Remarks = obj.Remarks,
                Status = obj.Status,
                Product = obj.Product.Title,
                Code = obj.Code
            };
            var selectItems = GetProductList();
            ViewBag.productlist = selectItems;
            return View(ffvm);
        }
        [HttpPost]
        public IActionResult Edit(Forma obj)
        {


            obj.Status = true;
          
            if (ModelState.IsValid)
            {
                _unitOfWork.Forma.Update(obj);
                _unitOfWork.Save();
                TempData["success"] = "Forma Edited Sucessfully";
                return RedirectToAction("Index", "Forma");
            }



            return View();
        }


        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            Forma? obj = _unitOfWork.Forma.GetFirstOrDefault(u => u.Id == id);
            if (obj == null) { return NotFound(); }
            return View(obj);
        }
        [HttpPost, ActionName("Delete")]
        public IActionResult DeletePost(int? id)
        {

            Forma obj = _unitOfWork.Forma.GetFirstOrDefault(u => u.Id == id);
            if (obj == null)
            {
                return NotFound();

            }
            if (ModelState.IsValid)
            {
                obj.Status = false;
                _unitOfWork.Forma.Remove(obj);
                _unitOfWork.Save();
                TempData["success"] = "Forma Deleted Sucessfully";
                return RedirectToAction("Index", "Forma");
            }

            return View();
        }

        public IQueryable<SelectListItem> GetProductList()
        {
            var selectItems = _unitOfWork.Product.GetAll().Select(s => new SelectListItem
            {
                Value = s.Id.ToString(), // Replace with the actual property you want as the value
                Text = s.Title // Replace with the actual property you want as the text
            });
            return selectItems;
        }




    }
}
