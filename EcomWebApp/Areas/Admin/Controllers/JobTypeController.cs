using Ecom.DataAccess.Data;
using Ecom.DataAccess.Repository.IRepository;
using Ecom.Models;
using Ecom.Utility;
using Microsoft.AspNetCore.Mvc;

namespace Ecom.WebApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class JobTypeController : Controller
    {
      
        private readonly IUnitOfWork _unitOfWork;
        public JobTypeController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;

        }
        public IActionResult Index()
        {
            //List<Category> objCategoryList1 = _db.Categories.ToList();
            //  List<Category>? objCategoryList = _categoryRepo.Get(e => e.Status == true).toList();
            List<JobType>? objCategoryList = _unitOfWork.JobType.GetAll().ToList();

            return View(objCategoryList);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(JobType obj)
        {
            if (ModelState.IsValid)
            {
                obj.Description = "JT-" + DateTime.Now.Year + "-" + DateTime.Now.Month + "-" + UniqueCodeGenerator.GenerateUniqueCodeFromTimestamp();
             
                _unitOfWork.JobType.Add(obj);
                _unitOfWork.Save();
                TempData["success"] = "JobType Created Sucessfully";
                return RedirectToAction("Index", "JobType");
            }

            return View();
        }

    }
}
