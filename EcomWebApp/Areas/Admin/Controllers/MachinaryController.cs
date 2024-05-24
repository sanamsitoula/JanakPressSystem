using Ecom.DataAccess.Data;
using Ecom.DataAccess.Repository.IRepository;
using Ecom.Models;
using Ecom.Utility;
using Microsoft.AspNetCore.Mvc;

namespace Ecom.WebApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class MachinaryController : Controller
    {
      
        private readonly IUnitOfWork _unitOfWork;
        public MachinaryController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;

        }
        public IActionResult Index()
        {
            //List<Category> objCategoryList1 = _db.Categories.ToList();
            //  List<Category>? objCategoryList = _categoryRepo.Get(e => e.Status == true).toList();
            List<Machinary>? obj = _unitOfWork.Machinary.GetAll().ToList();

            return View(obj);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Machinary obj)
        {
            if (ModelState.IsValid)
            {
                obj.Description = "MAC-" + DateTime.Now.Year + "-" + DateTime.Now.Month + "-" + UniqueCodeGenerator.GenerateUniqueCodeFromTimestamp();

              
                obj.Status = true;

                _unitOfWork.Machinary.Add(obj);
                _unitOfWork.Save();
                TempData["success"] = "Machinary Created Sucessfully";
                return RedirectToAction("Index", "Machinary");
            }

            return View();
        }



    }
}
