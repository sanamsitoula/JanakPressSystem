using Ecom.DataAccess.Data;
using Ecom.DataAccess.Repository.IRepository;
using Ecom.Models;
using Microsoft.AspNetCore.Mvc;

namespace Ecom.WebApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class JobTicketController : Controller
    {
      
        private readonly IUnitOfWork _unitOfWork;
        public JobTicketController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;

        }
        public IActionResult Index()
        {
            
            List<JobTicket>? obj = _unitOfWork.JobTicket.GetAll().ToList();

            return View(obj);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(JobTicket obj)
        {
          
           

            if (ModelState.IsValid)
            {
                obj.Status = true;
              
                _unitOfWork.JobTicket.Add(obj);
                _unitOfWork.Save();
                TempData["success"] = "JobTicket Created Sucessfully";
                return RedirectToAction("Index", "JobTicket");
            }

            return View();
        }


        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            JobTicket? obj = _unitOfWork.JobTicket.GetFirstOrDefault(u => u.Id == id);
            if (obj == null) { return NotFound(); }
            return View(obj);
        }
        [HttpPost]
        public IActionResult Edit(JobTicket obj)
        {


            obj.Status = true;
          
            if (ModelState.IsValid)
            {
                _unitOfWork.JobTicket.Update(obj);
                _unitOfWork.Save();
                TempData["success"] = "JobTicket Edited Sucessfully";
                return RedirectToAction("Index", "JobTicket");
            }



            return View();
        }


        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            JobTicket? obj = _unitOfWork.JobTicket.GetFirstOrDefault(u => u.Id == id);
            if (obj == null) { return NotFound(); }
            return View(obj);
        }
        [HttpPost, ActionName("Delete")]
        public IActionResult DeletePost(int? id)
        {

            JobTicket obj = _unitOfWork.JobTicket.GetFirstOrDefault(u => u.Id == id);
            if (obj == null)
            {
                return NotFound();

            }
            if (ModelState.IsValid)
            {
                obj.Status = false;
                _unitOfWork.JobTicket.Remove(obj);
                _unitOfWork.Save();
                TempData["success"] = "JobTicket Deleted Sucessfully";
                return RedirectToAction("Index", "JobTicket");
            }

            return View();
        }






    }
}
