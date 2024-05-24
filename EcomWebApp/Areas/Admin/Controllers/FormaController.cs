using Ecom.DataAccess.Data;
using Ecom.DataAccess.Repository.IRepository;
using Ecom.Models;
using Ecom.Utility;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

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
            List<Forma>? objProductList = _unitOfWork.Forma.
                GetAll()?
            .Select(Forma => new Forma
            {
                Id = Forma.Id,
                Name = Forma.Name,
                Page = Forma.Page,
                PrintTarget = Forma.PrintTarget,
                ProductId = Forma.ProductId,
                Code=Forma.Code

                // Set values for any other new properties
            })
            .ToList();
            objProductList.ForEach(e =>
            {

                e.Product = new Product // Assuming Category is a complex object
                {
                    // Set the SubjectId here
                    Title = _unitOfWork.Product.GetFirstOrDefault(c => c.Id == e.ProductId).Title,
                    Id = e.ProductId
                    // Set other properties of the Category object if needed
                };
            });
            return View(objProductList);
        }

        public IActionResult Create()
        {
            List<Product>? pro = _unitOfWork.Product.GetAll().ToList();
            // Convert the List<Forma>? to IEnumerable<SelectListItem>
            IEnumerable<SelectListItem>? selectListItems3 = pro?.Select(s => new SelectListItem
            {
                Value = s.Id.ToString(), // Replace with the actual property you want as the value
                Text = s.Title // Replace with the actual property you want as the text
            });
            ViewBag.productlist = selectListItems3;

            return View();
        }
        [HttpPost]
        public IActionResult Create(Forma obj)
        {
          
           

            if (ModelState.IsValid)
            {
                obj.Code = "Forma-" + DateTime.Now.Year + "-" + DateTime.Now.Month + "-" + UniqueCodeGenerator.GenerateUniqueCodeFromTimestamp();

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
            Forma? obj = _unitOfWork.Forma.GetFirstOrDefault(u => u.Id == id);
            if (obj == null) { return NotFound(); }
            return View(obj);
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






    }
}
