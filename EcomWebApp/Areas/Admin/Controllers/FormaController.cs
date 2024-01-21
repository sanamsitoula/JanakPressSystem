using Ecom.DataAccess.Data;
using Ecom.DataAccess.Repository.IRepository;
using Ecom.Models;
using Microsoft.AspNetCore.Mvc;

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
            
            List<Forma>? obj = _unitOfWork.Forma.GetAll().ToList();

            return View(obj);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Forma obj)
        {
          
           

            if (ModelState.IsValid)
            {
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
