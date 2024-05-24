using Ecom.DataAccess.Data;
using Ecom.DataAccess.Repository.IRepository;
using Ecom.Models;
using Ecom.Utility;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
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
        public IActionResult Index(int pageNumber = 1, int pageSize = 10)
        {
            var objProductList = _unitOfWork.JobTicket.GetAll()
                .OrderByDescending(p => p.Id)
                .Skip((pageNumber - 1) * pageSize)
                .Take(pageSize)
                .ToList();



            if (objProductList != null)
            {
                objProductList.ForEach(e =>
                {
                    
                    e.Product = new Product // Assuming Product is a complex object
                    {
                        Title = _unitOfWork.Product.GetFirstOrDefault(c => c.Id == e.ProductId).Title,
                        Id = (int)e.ProductId,
                    };
                   
                    e.JobType = new JobType // Assuming Product is a complex object
                    {
                        Name = _unitOfWork.JobType.GetFirstOrDefault(c => c.Id == e.JobTypeId).Name,
                        Id = e.JobTypeId,
                    };








                });
            }

            var totalItems = _unitOfWork.JobTicket.GetAll().Count();

            var viewModel = new PaginatedViewModel<JobTicket>
            {
                Items = objProductList,
                PageNumber = pageNumber,
                PageSize = pageSize,
                TotalItems = totalItems
            };

            return View(viewModel);
        }
        public IActionResult Index2()
        {
            List<JobTicket>? objProductList = _unitOfWork.JobTicket.
              GetAll()?
          .Select(JobTicket => new JobTicket
          {
              Id = JobTicket.Id,
              Name = JobTicket.Name,
              PageNumber = JobTicket.PageNumber,
              PrintTarget = JobTicket.PrintTarget,
              JobDate = JobTicket.JobDate,
              JobStartDate = JobTicket.JobStartDate,
              JobCompleteDate = JobTicket.JobCompleteDate,
              ProductId = JobTicket.ProductId,
              LotNumber = JobTicket.LotNumber,
              JobTypeId = JobTicket.JobTypeId,
              PrintAchieved = JobTicket.PrintAchieved,
              Desc = JobTicket.Desc,
              Remarks = JobTicket.Remarks,
              Status = JobTicket.Status,
              FiscalYearId = JobTicket.FiscalYearId,
              JobStepId = JobTicket.JobStepId,
              PrePrintSize = JobTicket.PrePrintSize,
              Code  = JobTicket.Code,



              // Set values for any other new properties
          }).OrderByDescending(c => c.Id)
                                   .ToList();

            if (objProductList != null)
            {
                objProductList.ForEach(e =>
                {
                    e.Product = new Product // Assuming Product is a complex object
                    {
                        Title = _unitOfWork.Product.GetFirstOrDefault(c => c.Id == e.ProductId).Title,
                        Id = e.ProductId,
                    };
                    e.JobType = new JobType // Assuming Product is a complex object
                    {
                        Name = _unitOfWork.JobType.GetFirstOrDefault(c => c.Id == e.JobTypeId).Name,
                        Id = e.JobTypeId,
                    };
                    //e.FiscalYear = new FiscalYear // Assuming Product is a complex object
                    //{
                    //    Name = _unitOfWork.FiscalYear.GetFirstOrDefault(c => c.Id == e.FiscalYearId).Name,
                    //    Id = e.FiscalYearId,
                    //};





                    //// Assuming JobTicketId is of type int?
                    //int? MachinaryId = e.MachinaryId;

                    //e.Machinary = MachinaryId.HasValue ? new Machinary // Assuming JobTicket is a complex object
                    //{
                    //    Name = _unitOfWork.Machinary.GetFirstOrDefault(c => c.Id == MachinaryId.Value)?.Name,
                    //    Id = MachinaryId.Value,
                    //} : null;

                    //// Assuming JobTicketId is of type int?
                    //int? FormaId = e.FormaId;
                    //var formaEntity = _unitOfWork.Forma.GetFirstOrDefault(c => c.Id == FormaId.Value);
                    //if (formaEntity != null)
                    //{
                    //    e.Forma = new Forma
                    //    {
                    //        Id = formaEntity.Id,
                    //        Name = formaEntity.Name,
                    //        Page = formaEntity.Page,
                    //        PrintTarget = formaEntity.PrintTarget,
                    //        PrintAchieved = formaEntity.PrintAchieved
                    //    };
                    //}


                });
            }
            return View(objProductList);
        }

        public IActionResult Create()
        {
            //var model = new Product() { };
            List<Product>? objProduct = _unitOfWork.Product.GetAll().ToList();
            List<JobType>? objJobType = _unitOfWork.JobType.GetAll().ToList();
            List<FiscalYear>? objFY = _unitOfWork.FiscalYear.GetAll().ToList();

            IEnumerable<SelectListItem>? selectProductList = objProduct?.Select(form => new SelectListItem
            {
                Value = form.Id.ToString(), // Replace with the actual property you want as the value
                Text = form.Title // Replace with the actual property you want as the text
            });
            IEnumerable<SelectListItem>? selectJobTypeList = objJobType?.Select(f => new SelectListItem
            {
                Value = f.Id.ToString(), // Replace with the actual property you want as the value
                Text = f.Name // Replace with the actual property you want as the text
            });
            IEnumerable<SelectListItem>? selectFY = objFY?.Select(fy => new SelectListItem
            {
                Value = fy.Id.ToString(), // Replace with the actual property you want as the value
                Text = fy.Name // Replace with the actual property you want as the text
            });


            // Store the IEnumerable<SelectListItem> in ViewBag
            ViewBag.Product = selectProductList;
            ViewBag.JobType = selectJobTypeList;
            ViewBag.FiscalYear = selectFY;



            return View();
        }
        [HttpPost]
        public IActionResult Create(JobTicket obj)
        {
          
           

            if (ModelState.IsValid)
            {
                obj.Code = "JT-"+DateTime.Now.Year +"-"+ DateTime.Now.Month+ "-" +UniqueCodeGenerator.GenerateUniqueCodeFromTimestamp();

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
