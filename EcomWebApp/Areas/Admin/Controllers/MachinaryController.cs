using Ecom.DataAccess.Data;
using Ecom.DataAccess.Repository.IRepository;
using Ecom.Models;
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
      
    }
}
