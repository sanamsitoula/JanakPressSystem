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
    public class MachineJobController : Controller
    {
      
        private readonly IUnitOfWork _unitOfWork;
        public MachineJobController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;

        }
        public IActionResult Index(int pageNumber = 1, int pageSize = 10)
        {
            var objProductList = _unitOfWork.MachineJob.GetAll()
                .OrderByDescending(p => p.Id)
                .Skip((pageNumber - 1) * pageSize)
                .Take(pageSize)
                .ToList();



            if (objProductList != null)
            {
                objProductList.ForEach(e =>
                {
                    // Assuming JobTicketId is of type int?
                    int? JobTicketId = e.JobTicketId;
                    var jobTicketEntity = _unitOfWork.JobTicket.GetFirstOrDefault(c => c.Id == JobTicketId.Value);
                    if (jobTicketEntity != null)
                    {
                        e.JobTicket = new JobTicket
                        {
                            Id = jobTicketEntity.Id,
                            Name = jobTicketEntity.Name,
                            Code = jobTicketEntity.Code

                        };
                    }
                    e.Product = new Product // Assuming Product is a complex object
                    {
                        Title = _unitOfWork.Product.GetFirstOrDefault(c => c.Id == e.ProductId).Title,
                        Id = (int)e.ProductId,
                    };
                    // Assuming JobTicketId is of type int?
                    int? MachinaryId = e.MachinaryId;

                    e.Machinary = MachinaryId.HasValue ? new Machinary // Assuming JobTicket is a complex object
                    {
                        Name = _unitOfWork.Machinary.GetFirstOrDefault(c => c.Id == MachinaryId.Value)?.Name,
                        Id = MachinaryId.Value,
                    } : null;

                    // Assuming JobTicketId is of type int?
                    int? FormaId = e.FormaId;
                    var formaEntity = _unitOfWork.Forma.GetFirstOrDefault(c => c.Id == FormaId.Value);
                    if (formaEntity != null)
                    {
                        e.Forma = new Forma
                        {
                            Id = formaEntity.Id,
                            Name = formaEntity.Name,
                            Page = formaEntity.Page,
                            PrintTarget = formaEntity.PrintTarget,
                            PrintAchieved = formaEntity.PrintAchieved
                        };
                    }







                });
            }

            var totalItems = _unitOfWork.P2M.GetAll().Count();

            var viewModel = new PaginatedViewModel<MachineJob>
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
            List<MachineJob>? objProductList = _unitOfWork.MachineJob.
              GetAll()?
          .Select(MachineJob => new MachineJob
          {
              Id = MachineJob.Id,
              Name = MachineJob.Name,
              ProductId = MachineJob.ProductId,
              MachinaryId = MachineJob.MachinaryId, 
              FormaId = MachineJob.FormaId,
              JobTicketId = MachineJob.JobTicketId,
              JobType = MachineJob.JobType,
              FormaPageSize = MachineJob.FormaPageSize,
              FormaTarget=MachineJob.FormaTarget,
              JobQuantity = MachineJob.JobQuantity,
              JobDate= MachineJob.JobDate,
              SupervisorId=MachineJob.SupervisorId,
              OperatorId=MachineJob.OperatorId,
              JobStepId=MachineJob.JobStepId,
              ShiftId=MachineJob.ShiftId,
              ShiftDurationId=MachineJob.ShiftDurationId,

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



                // Assuming JobTicketId is of type int?
                int? JobTicketId = e.JobTicketId;

                e.JobTicket = JobTicketId.HasValue ? new JobTicket // Assuming JobTicket is a complex object
                {
                    Name = _unitOfWork.JobTicket.GetFirstOrDefault(c => c.Id == JobTicketId.Value)?.Name,
                    Id = JobTicketId.Value,
                } : null;

           
                // Assuming JobTicketId is of type int?
                int? MachinaryId = e.MachinaryId;

                e.Machinary = MachinaryId.HasValue ? new Machinary // Assuming JobTicket is a complex object
                {
                    Name = _unitOfWork.Machinary.GetFirstOrDefault(c => c.Id == MachinaryId.Value)?.Name,
                    Id = MachinaryId.Value,
                } : null;

                // Assuming JobTicketId is of type int?
                int? FormaId = e.FormaId;
                var formaEntity = _unitOfWork.Forma.GetFirstOrDefault(c => c.Id == FormaId.Value);
                if (formaEntity != null)
                {
                    e.Forma = new Forma
                    {
                        Id = formaEntity.Id,
                        Name = formaEntity.Name,
                        Page = formaEntity.Page,
                        PrintTarget = formaEntity.PrintTarget,
                        PrintAchieved = formaEntity.PrintAchieved
                    };
                }


            });
            }
            return View(objProductList);
        }

        public IActionResult Create()
        {
            List<Forma>? f = _unitOfWork.Forma.GetAll()
                                   .OrderByDescending(c => c.Id)
                                   .ToList();
            List<Product>? objProduct = _unitOfWork.Product.GetAll().OrderByDescending(c => c.Id).ToList();
            List<JobType>? objJobType = _unitOfWork.JobType.GetAll().ToList();
            List<Machinary>? objMac = _unitOfWork.Machinary.GetAll().OrderByDescending(c => c.Id).ToList();
            List<JobTicket>? objJT = _unitOfWork.JobTicket.GetAll().OrderByDescending(c => c.Id).ToList();

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


            IEnumerable<SelectListItem>? selectFormaItems = f?.Select(form => new SelectListItem
            {
                Value = form.Id.ToString(), // Use 'form' here, not 'f'
                Text = form.Name // Use 'form' here, not 'f'
            });
            IEnumerable<SelectListItem>? selectMachineItems = objMac?.Select(form => new SelectListItem
            {
                Value = form.Id.ToString(), // Use 'form' here, not 'f'
                Text = form.Name // Use 'form' here, not 'f'
            });
            IEnumerable<SelectListItem>? selectJobTicketItems = objJT?.Select(form => new SelectListItem
            {
                Value = form.Id.ToString(), // Use 'form' here, not 'f'
                Text = form.Name // Use 'form' here, not 'f'
            });


            // Store the IEnumerable<SelectListItem> in ViewBag
            ViewBag.Product = selectProductList;
            ViewBag.JobType = selectJobTypeList;
            ViewBag.Forma = selectFormaItems;
            ViewBag.Machinary = selectMachineItems;
            ViewBag.JobTicket = selectJobTicketItems;



            return View();
        }
        [HttpPost]
        public IActionResult Create(MachineJob obj)
        {
            if (ModelState.IsValid)
            {
                obj.Desc = "MJ-"+obj.JobStepId + "-"+ DateTime.Now.Year + "-" + DateTime.Now.Month + "-" + UniqueCodeGenerator.GenerateUniqueCodeFromTimestamp();

                obj.JobDate = obj.JobDate.Value.Date;
                obj.ReportDate = obj.ReportDate.Value.Date;
                obj.Status = true;
              
                _unitOfWork.MachineJob.Add(obj);
                _unitOfWork.Save();
                TempData["success"] = "MachineJob Created Sucessfully";
                return RedirectToAction("Index", "MachineJob");
            }

            return View();
        }


        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            MachineJob? obj = _unitOfWork.MachineJob.GetFirstOrDefault(u => u.Id == id);
            if (obj == null) { return NotFound(); }
            return View(obj);
        }
        [HttpPost]
        public IActionResult Edit(MachineJob obj)
        {


            obj.Status = true;
          
            if (ModelState.IsValid)
            {
                _unitOfWork.MachineJob.Update(obj);
                _unitOfWork.Save();
                TempData["success"] = "MachineJob Edited Sucessfully";
                return RedirectToAction("Index", "MachineJob");
            }



            return View();
        }


        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            MachineJob? obj = _unitOfWork.MachineJob.GetFirstOrDefault(u => u.Id == id);
            if (obj == null) { return NotFound(); }
            return View(obj);
        }
        [HttpPost, ActionName("Delete")]
        public IActionResult DeletePost(int? id)
        {

            MachineJob obj = _unitOfWork.MachineJob.GetFirstOrDefault(u => u.Id == id);
            if (obj == null)
            {
                return NotFound();

            }
            if (ModelState.IsValid)
            {
                obj.Status = false;
                _unitOfWork.MachineJob.Remove(obj);
                _unitOfWork.Save();
                TempData["success"] = "MachineJob Deleted Sucessfully";
                return RedirectToAction("Index", "MachineJob");
            }

            return View();
        }
       

        public IActionResult View(int? id, int? proId)
        {
            // Retrieve and filter the forma list based on the id parameter
            var forma = _unitOfWork.Forma.GetAll()
                         .Where(f => f.ProductId == proId)
                         .ToList();
            MachineJob MachineJob = _unitOfWork.MachineJob.GetFirstOrDefault(u => u.Id == id);
            Product product = _unitOfWork.Product.GetFirstOrDefault(u => u.Id == proId);
            //   var MachineJob = _unitOfWork.GetFirstOrDefault(u => u.Id == id);
            // MachineJob obj = _unitOfWork.MachineJob.GetFirstOrDefault(u => u.Id == id);

            var jtf = new MachineJob()
            {
             

            };

            return View(jtf);
        }

        [HttpGet]
        public JsonResult GetFormasByProductId(int productId)
        {
            var formas = _unitOfWork.Forma.GetAll()
                                 .Where(f => f.ProductId == productId)
                                 .Select(f => new SelectListItem
                                 {
                                     Value = f.Id.ToString(),
                                     Text = f.Name
                                 }).ToList();

            return Json(formas);
        }

        [HttpGet]

        public JsonResult GetPageSizeByFormaId(int formaId)
        {
            var forma = _unitOfWork.Forma.GetFirstOrDefault(f => f.Id == formaId);
            if (forma != null)
            {
                return Json(new
                {
                    pageSize = forma.Page,
                    formaTarget = forma.PrintTarget
                });
            }
            return Json(new
            {
                pageSize = "",
                formaTarget = ""
            });
        }


    }
}
