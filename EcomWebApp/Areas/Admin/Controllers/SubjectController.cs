using Ecom.DataAccess.Data;
using Ecom.DataAccess.Repository.IRepository;
using Ecom.Models;
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
            //List<Subject> objCategoryList1 = _db.Categories.ToList();
            //  List<Subject>? objCategoryList = _categoryRepo.Get(e => e.Status == true).toList();
            List<Subject>? obj = _unitOfWork.Subject.GetAll().ToList();

            return View(obj);
        }

        public IActionResult Create()
        {
            return View();
        }
        
    }
}
