using Ecom.DataAccess.Data;
using Ecom.DataAccess.Repository;
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
    public class P2MController : Controller
    {

        private readonly IUnitOfWork _unitOfWork;

        public P2MController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;

        }
        public IActionResult Index()
        {
            List<P2M>? objProductList = _unitOfWork.P2M.
              GetAll()?
          .Select(P2M => new P2M
          {
              Id = P2M.Id,
              P2M_Code = P2M.P2M_Code,
              Name = P2M.Name,
              ProductId = P2M.ProductId,
              ClassId = P2M.ClassId,
              P2MDate = P2M.P2MDate,
              ReportDate = P2M.ReportDate,
              JobTicketId = P2M.JobTicketId,
              FormaNumber = P2M.FormaNumber,
              PerPokaSize = P2M.PerPokaSize,
              PokaNumber = P2M.PokaNumber,
              ProductQuantity = P2M.ProductQuantity,
              PiecesQuantity = P2M.PiecesQuantity,
              TotalProductQuantity = P2M.TotalProductQuantity,
              JobStepId = P2M.JobStepId,
              Status = P2M.Status,
              Desc = P2M.Desc,
              CheckedById = P2M.CheckedById,
              VerifiedById = P2M.VerifiedById,
              ReceivedById = P2M.ReceivedById,
              FiscalYear = P2M.FiscalYear,


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
                        Id = (int)e.ProductId,
                    };
                    e.Class = new Class // Assuming Product is a complex object
                    {
                        Name = _unitOfWork.Class.GetFirstOrDefault(c => c.Id == e.ClassId).Name,
                        Id = e.ClassId,
                    };








                });
            }
            return View(objProductList);
        }

        public IActionResult Create()
        {
            List<JobTicket>? f = _unitOfWork.JobTicket.GetAll()
                                   .OrderByDescending(c => c.Id)
                                   .ToList();
            List<Product>? objProduct = _unitOfWork.Product.GetAll().OrderByDescending(c => c.Id).ToList();
            List<JobType>? objJobType = _unitOfWork.JobType.GetAll().ToList();
            List<DropdownV>? objDropdownV = _unitOfWork.DropdownV.GetAll().Where(d => d.ParaModel == "PerPokaSize").OrderByDescending(c => c.Id).ToList();
            List<Class>? objClass = _unitOfWork.Class.GetAll().OrderByDescending(c => c.Id).ToList();

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


            IEnumerable<SelectListItem>? selectJobTicketItems = f?.Select(form => new SelectListItem
            {
                Value = form.Id.ToString(), // Use 'form' here, not 'f'
                Text = form.Name // Use 'form' here, not 'f'
            });
            IEnumerable<SelectListItem>? selectDropdownVItems = objDropdownV?.Select(form => new SelectListItem
            {
                Value = form.Value.ToString(), // Use 'form' here, not 'f'
                Text = form.Para // Use 'form' here, not 'f'
            });
            IEnumerable<SelectListItem>? selectClassItems = objClass?.Select(form => new SelectListItem
            {
                Value = form.Id.ToString(), // Use 'form' here, not 'f'
                Text = form.Name // Use 'form' here, not 'f'
            });


            // Store the IEnumerable<SelectListItem> in ViewBag
            ViewBag.Product = selectProductList;
            ViewBag.JobType = selectJobTypeList;
            ViewBag.JobTicket = selectJobTicketItems;
            ViewBag.DropdownV = selectDropdownVItems;
            ViewBag.Class = selectClassItems;



            return View();
        }
        [HttpPost]
        public IActionResult Create(P2M obj)
        {
            if (ModelState.IsValid)
            {
                obj.P2M_Code = "P2M-" + DateTime.Now.Year + "-" + DateTime.Now.Month + "-" + UniqueCodeGenerator.GenerateUniqueCodeFromTimestamp();
                //DateTime dateTimeValue = obj.P2MDate;
                //  string dateString = obj.P2MDate; // Assuming obj.P2MDate is already a string
                //DateTime parsedDate;
                //if (DateTime.TryParse(dateString, out parsedDate))
                //{
                //    dateString = parsedDate.ToString("yyyy-MM-dd");
                //}
                //else
                //{
                //    // Handle invalid date string
                //    Console.WriteLine("Invalid date string format.");
                //}


                //string dateString2 = parsedDate.ToString("yyyy-MM-dd"); // Format the date as needed

                //obj.P2MDate = dateString2;
                obj.ReportDate = obj.ReportDate;
                obj.Status = true;

                _unitOfWork.P2M.Add(obj);
                _unitOfWork.Save();
                TempData["success"] = "P2M Created Sucessfully";
                return RedirectToAction("Index", "P2M");
            }

            return View();
        }


        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            P2M? obj = _unitOfWork.P2M.GetFirstOrDefault(u => u.Id == id);
            if (obj == null) { return NotFound(); }
            return View(obj);
        }
        [HttpPost]
        public IActionResult Edit(P2M obj)
        {


            obj.Status = true;

            if (ModelState.IsValid)
            {
                _unitOfWork.P2M.Update(obj);
                _unitOfWork.Save();
                TempData["success"] = "P2M Edited Sucessfully";
                return RedirectToAction("Index", "P2M");
            }



            return View();
        }


        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            P2M? obj = _unitOfWork.P2M.GetFirstOrDefault(u => u.Id == id);
            if (obj == null) { return NotFound(); }
            return View(obj);
        }
        [HttpPost, ActionName("Delete")]
        public IActionResult DeletePost(int? id)
        {

            P2M obj = _unitOfWork.P2M.GetFirstOrDefault(u => u.Id == id);
            if (obj == null)
            {
                return NotFound();

            }
            if (ModelState.IsValid)
            {
                obj.Status = false;
                _unitOfWork.P2M.Remove(obj);
                _unitOfWork.Save();
                TempData["success"] = "P2M Deleted Sucessfully";
                return RedirectToAction("Index", "P2M");
            }

            return View();
        }


        public IActionResult View(int? id, int? proId)
        {
            // Retrieve and filter the forma list based on the id parameter
            var forma = _unitOfWork.Forma.GetAll()
                         .Where(f => f.ProductId == proId)
                         .ToList();
            P2M P2M = _unitOfWork.P2M.GetFirstOrDefault(u => u.Id == id);
            Product product = _unitOfWork.Product.GetFirstOrDefault(u => u.Id == proId);
            //   var P2M = _unitOfWork.GetFirstOrDefault(u => u.Id == id);
            // P2M obj = _unitOfWork.P2M.GetFirstOrDefault(u => u.Id == id);

            var jtf = new P2M()
            {


            };

            return View(jtf);
        }

        [HttpGet]
        public JsonResult GetClassByProductId(int productId)
        {
            var classes = _unitOfWork.Product.GetAll()
                                 .Where(f => f.Id == productId)
                                 .Select(f => new SelectListItem
                                 {
                                     Value = f.Id.ToString(),
                                     Text = f.Class.Name,
                                 }).ToList();

            return Json(classes);
        }

        [HttpGet]

        public JsonResult GetProductByJobTicketId(int jobTicketId)
        {
            var jobTicket = _unitOfWork.JobTicket.GetFirstOrDefault(f => f.Id == jobTicketId);
            var product = _unitOfWork.Product.GetFirstOrDefault(f => f.Id == jobTicket.ProductId);
            var cls = _unitOfWork.Class.GetFirstOrDefault(f => f.Id == product.ClassId);
            if (jobTicket != null && product != null && cls != null)
            {
                return Json(new
                {
                    productId = jobTicket.ProductId,
                    noofAssociatedForma = jobTicket.NoofAssociatedForma,
                    classId = cls.Id
                });
            }
            return Json(new
            {
                productId = "",
                noofAssociatedForma = ""
            });
        }




    }
}
