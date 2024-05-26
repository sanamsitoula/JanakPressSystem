using Ecom.DataAccess.Data;
using Ecom.DataAccess.Repository.IRepository;
using Ecom.Models;
using Ecom.Utility;
using Microsoft.AspNetCore.Mvc;

namespace Ecom.WebApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SubjectController : Controller
    {
      
        private readonly IUnitOfWork _unitOfWork;
        public SubjectController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;

        }
        public IActionResult Index()
        {
            List<Subject>? obj = _unitOfWork.Subject.GetAll().ToList();

            return View(obj);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Subject obj)
        {
            if (ModelState.IsValid)
            {
                obj.Description = "SUB-" + DateTime.Now.Year + "-" + DateTime.Now.Month + "-" + UniqueCodeGenerator.GenerateUniqueCodeFromTimestamp();
                obj.status = true;
                _unitOfWork.Subject.Add(obj);
                _unitOfWork.Save();
                TempData["success"] = "Subject Created Sucessfully";
                return RedirectToAction("Index", "Subject");
            }

            return View();
        }

    }
}
