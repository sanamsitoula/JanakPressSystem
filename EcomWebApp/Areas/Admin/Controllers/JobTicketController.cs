using Ecom.DataAccess.Data;
using Ecom.DataAccess.Repository.IRepository;
using Ecom.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis;
using Microsoft.SqlServer.Server;
using System.Net.Sockets;

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
            List<JobTicket>? objProductList = _unitOfWork.JobTicket.
              GetAll()?
          .Select(jobTicket => new JobTicket
          {
              Id = jobTicket.Id,
              Name = jobTicket.Name,
              ProductId = jobTicket.ProductId,
              // Set values for any other new properties
          }).ToList();


            objProductList.ForEach(e =>
            {
                e.Product = new Product // Assuming Product is a complex object
                {
                    Title = _unitOfWork.Product.GetFirstOrDefault(c => c.Id == e.ProductId).Title,
                    Id = e.ProductId,

                    // Set other properties of the Category object if needed
                };

            });
            return View(objProductList);
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
        public IActionResult View2(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            JobTicket jobTicket = _unitOfWork.JobTicket.GetFirstOrDefault(u => u.Id == id);

            // Create a list containing the single JobTicket object
            List<JobTicket> jobTicketList = new List<JobTicket> { jobTicket };

          
            var pisd= _unitOfWork.JobTicket.GetFirstOrDefault(u => u.Id == id);
          //  int k = pisd;
            // var jobTickets = _unitOfWork.JobTicket.GetFirstOrDefault(u => u.Id == id);

            // Mapping JobTicket entities to DTOs
            var objJobTicketList = jobTicketList.Select(jobTicket => new JobTicket
            {
                Id = jobTicket.Id,
                Name = jobTicket.Name,
                JobStartDate = jobTicket.JobStartDate,
               // JobStep = string.IsNullOrEmpty(jobTicket.JobStep) ? "" : jobTicket.JobStep,
                ProductId = jobTicket.ProductId,
                // Initialize Product property to avoid NullReferenceException
                Product = new Product { Title = "" }
            }).ToList();
            var Forma = _unitOfWork.Forma.GetAll().ToList();
            //var Forma = _unitOfWork.Forma.GetAll(x => listIds.Contains(x.Id)).ToList();
         //  var forma = _unitOfWork.Forma.GetAllThroughParam(u => u.ProductId == k).ToList();
           
            JobTicketForma jtf = new JobTicketForma()
            {
                jobstick = jobTicketList,
                forma = Forma
            };
            return View(jtf);
        }


        public IActionResult View(int? id, int? proId)
        {
            // Retrieve and filter the forma list based on the id parameter
            var forma = _unitOfWork.Forma.GetAll()
                         .Where(f => f.ProductId == proId)
                         .ToList();
            JobTicket jobTicket = _unitOfWork.JobTicket.GetFirstOrDefault(u => u.Id == id);
            Product product = _unitOfWork.Product.GetFirstOrDefault(u => u.Id == proId);
            //   var JobTicket = _unitOfWork.GetFirstOrDefault(u => u.Id == id);
            // JobTicket obj = _unitOfWork.JobTicket.GetFirstOrDefault(u => u.Id == id);

            var jtf = new JobTicketForma()
            {
               forma= forma,
                jobstick = jobTicket != null ? new List<JobTicket> { jobTicket } : new List<JobTicket>(),
                product = product != null ? new List<Product> { product } : new List<Product>()

                //  jobstick = new List<JobTicket> { jobTicket }
                // jobstick = jobTicket

            };

            return View(jtf);
        }




    }
}
