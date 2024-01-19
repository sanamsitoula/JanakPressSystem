using Ecom.DataAccess.Data;
using Ecom.DataAccess.Repository.IRepository;
using Ecom.Models;
using Microsoft.AspNetCore.Mvc;

namespace Ecom.WebApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController : Controller
    {
      
        private readonly IUnitOfWork _unitOfWork;
        public CategoryController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;

        }
        public IActionResult Index()
        {
            //List<Category> objCategoryList1 = _db.Categories.ToList();
            //  List<Category>? objCategoryList = _categoryRepo.Get(e => e.Status == true).toList();
            List<Category>? objCategoryList = _unitOfWork.Category.GetAll().ToList();

            return View(objCategoryList);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Category c)
        {
            if (c.Name == c.DisplayOrder.ToString())
            {
                ModelState.AddModelError("name", "The display order cannot match the name");
            }
            if (c.Name == c.DisplayOrder.ToString())
            {
                ModelState.AddModelError("name", "The display order cannot match the name");
            }

            if (ModelState.IsValid)
            {
                c.Status = true;
                c.CreatedDate = DateTime.Now;
                c.CreatedBy = "1";
                _unitOfWork.Category.Add(c);
                _unitOfWork.Save();
                TempData["success"] = "Category Created Sucessfully";
                return RedirectToAction("Index", "Category");
            }

            return View();
        }


        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            Category? cd = _unitOfWork.Category.GetFirstOrDefault(u => u.Id == id);
            //Category? cd1 = _db.Categories.FirstOrDefault(cd => cd.Id == id);    
            //Category? cd2 = _db.Categories.Where(u=>u.Id==id).FirstOrDefault();
            if (cd == null) { return NotFound(); }
            return View(cd);
        }
        [HttpPost]
        public IActionResult Edit(Category c)
        {


            c.Status = true;
            c.CreatedDate = DateTime.Now;
            c.CreatedBy = "1";
            if (ModelState.IsValid)
            {
                _unitOfWork.Category.Update(c);
                _unitOfWork.Save();
                TempData["success"] = "Category Edited Sucessfully";
                return RedirectToAction("Index", "Category");
            }



            return View();
        }


        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            Category? cd = _unitOfWork.Category.GetFirstOrDefault(u => u.Id == id);
            if (cd == null) { return NotFound(); }
            return View(cd);
        }
        [HttpPost, ActionName("Delete")]
        public IActionResult DeletePost(int? id)
        {

            Category c = _unitOfWork.Category.GetFirstOrDefault(u => u.Id == id);
            if (c == null)
            {
                return NotFound();

            }
            if (ModelState.IsValid)
            {
                c.Status = false;
                _unitOfWork.Category.Remove(c);
                _unitOfWork.Save();
                TempData["success"] = "Category Deleted Sucessfully";
                return RedirectToAction("Index", "Category");
            }

            return View();
        }
    }
}
