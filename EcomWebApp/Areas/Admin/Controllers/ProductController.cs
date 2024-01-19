using Ecom.DataAccess.Data;
using Ecom.DataAccess.Repository.IRepository;
using Ecom.Models;
using Microsoft.AspNetCore.Mvc;

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
        public IActionResult Index()
        {
            //List<Product> objProductList1 = _db.Categories.ToList();
            //  List<Product>? objProductList = _productRepo.Get(e => e.Status == true).toList();
            List<Product>? objProductList = _unitOfWork.Product.GetAll().ToList();

            return View(objProductList);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Product c)
        {
           // var p = new Product { Title = c.Title };
            //Stuff server should set goes now
            c.Status = true;
            c.CreatedBy = "SYSADMIN";
            if (ModelState.IsValid)
            {
                // return ValidationProblem();

                _unitOfWork.Product.Add(c);
                _unitOfWork.Save();
                TempData["success"] = "Product Created Sucessfully";
                return RedirectToAction("Index", "Product");
            }

            return View();
        }


        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            Product? cd = _unitOfWork.Product.GetFirstOrDefault(u => u.Id == id);
            if (cd == null) { return NotFound(); }
            return View(cd);
        }
        [HttpPost]
        public IActionResult Edit(Product c)
        {


            c.Status = true;
            c.CreatedBy = "1";
            if (ModelState.IsValid)
            {
                _unitOfWork.Product.Update(c);
                _unitOfWork.Save();
                TempData["success"] = "Product Edited Sucessfully";
                return RedirectToAction("Index", "Product");
            }



            return View();
        }


        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            Product? cd = _unitOfWork.Product.GetFirstOrDefault(u => u.Id == id);
            if (cd == null) { return NotFound(); }
            return View(cd);
        }
        [HttpPost, ActionName("Delete")]
        public IActionResult DeletePost(int? id)
        {

            Product c = _unitOfWork.Product.GetFirstOrDefault(u => u.Id == id);
            if (c == null)
            {
                return NotFound();

            }
            if (ModelState.IsValid)
            {
                c.Status = false;
                _unitOfWork.Product.Remove(c);
                _unitOfWork.Save();
                TempData["success"] = "Product Deleted Sucessfully";
                return RedirectToAction("Index", "Product");
            }

            return View();
        }
    }
}
