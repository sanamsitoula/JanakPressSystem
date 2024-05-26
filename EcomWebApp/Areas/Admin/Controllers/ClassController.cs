using Ecom.DataAccess.Data;
using Ecom.DataAccess.Repository.IRepository;
using Ecom.Models;
using Ecom.Utility;
using Microsoft.AspNetCore.Mvc;

namespace Ecom.WebApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ClassController : Controller
    {
      
        private readonly IUnitOfWork _unitOfWork;
        public ClassController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;

        }
        public IActionResult Index()
        {
            //List<Category> objCategoryList1 = _db.Categories.ToList();
            //  List<Category>? objCategoryList = _categoryRepo.Get(e => e.Status == true).toList();
            List<Class>? obj = _unitOfWork.Class.GetAll().ToList();

            return View(obj);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Class obj)
        {
            if (ModelState.IsValid)
            {
                obj.Code = "Class-" + DateTime.Now.Year + "-" + DateTime.Now.Month + "-" + UniqueCodeGenerator.GenerateUniqueCodeFromTimestamp();


                obj.status = true;

                _unitOfWork.Class.Add(obj);
                _unitOfWork.Save();
                TempData["success"] = "Class Created Sucessfully";
                return RedirectToAction("Index", "Class");
            }

            return View();
        }


    }
}
