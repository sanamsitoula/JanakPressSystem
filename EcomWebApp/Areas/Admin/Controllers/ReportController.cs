
using Ecom.DataAccess.Data;
using Ecom.DataAccess.Repository;
using Ecom.DataAccess.Repository.IRepository;
using Ecom.Models;
using Ecom.Utility;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.CodeAnalysis;
using Microsoft.EntityFrameworkCore;
using Microsoft.SqlServer.Server;
using NepaliCalendarBS;
using System.Net.Sockets;

namespace Ecom.WebApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ReportController : Controller
    {
      
        private readonly IUnitOfWork _unitOfWork;
        public ReportController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;

        }
        public IActionResult Index3(int pageNumber = 1, int pageSize = 100)
        {
            var objProductList = _unitOfWork.P2M.GetAll()
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
                    e.Class = new Class // Assuming Product is a complex object
                    {
                        Name = _unitOfWork.Class.GetFirstOrDefault(c => c.Id == e.ClassId).Name,
                        Id = e.ClassId,
                    };
                    e.Subject = new Subject // Assuming Product is a complex object
                    {
                        Name = _unitOfWork.Subject.GetFirstOrDefault(c => c.Id == e.SubjectId).Name,
                        Id = (int)e.SubjectId,
                    };








                });
            }

            var totalItems = _unitOfWork.P2M.GetAll().Count();

            var viewModel = new PaginatedViewModel<P2M>
            {
                Items = objProductList,
                PageNumber = pageNumber,
                PageSize = pageSize,
                TotalItems = totalItems
            };

            return View(viewModel);
        }

        public async Task<IActionResult> P2MReport(string searchString, int? classId, int? productId, DateTime? fromDate, DateTime? toDate,int pageNumber = 1, int pageSize = 100)
        {
            var classList = _unitOfWork.Class.GetAll().ToList(); // Get all classes
        
            var p2mList = _unitOfWork.P2M.GetAll()
              .OrderByDescending(p => p.Id)
              .Skip((pageNumber - 1) * pageSize)
              .Take(pageSize)
              .ToList();

            //var p2m = from p in _unitOfWork.P2M.GetAll()
            //          select p;
            // Apply filters
            if (!string.IsNullOrEmpty(searchString))
            {
                p2mList = p2mList.Where(p =>
                      p.P2M_Code.Contains(searchString, StringComparison.OrdinalIgnoreCase) ||
                             p.Name.Contains(searchString, StringComparison.OrdinalIgnoreCase)
                           //  ||                             p.JobTicket.Name.Contains(searchString, StringComparison.OrdinalIgnoreCase)
                       ).ToList();
            }
          
            if (classId.HasValue)
            {
                p2mList = (List<P2M>)p2mList.Where(p => p.ClassId == classId);
            }

            if (productId.HasValue)
            {
                p2mList = (List<P2M>)p2mList.Where(p => p.ProductId == productId);
            }

            // Apply date filters
            if (fromDate.HasValue)
            {
                p2mList = p2mList.Where(p => p.P2MDate >= fromDate.Value).ToList();
            }

            if (toDate.HasValue)
            {
                p2mList = p2mList.Where(p => p.P2MDate <= toDate.Value).ToList();
            }


            if (p2mList != null)
            {
                p2mList.ForEach(e =>
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
                    e.Class = new Class // Assuming Product is a complex object
                    {
                        Name = _unitOfWork.Class.GetFirstOrDefault(c => c.Id == e.ClassId).Name,
                        Id = e.ClassId,
                    };
                    e.Subject = new Subject // Assuming Product is a complex object
                    {
                        Name = _unitOfWork.Subject.GetFirstOrDefault(c => c.Id == e.SubjectId).Name,
                        Id = (int)e.SubjectId,
                    };

                });
            }
          



            ViewBag.ClassList = new SelectList(classList, "Id", "Name");
            var totalItems = _unitOfWork.P2M.GetAll().Count();

            var viewModel = new PaginatedViewModel<P2M>
            {
                Items = p2mList,
                PageNumber = pageNumber,
                PageSize = pageSize,
                TotalItems = totalItems
            };

            return View(viewModel);

            //var viewModel = new ReportViewModel
            //{
            //    SearchString = searchString,
            //    ClassId = classId,
            //    ProductId = productId,
            //    FromDate = fromDate,
            //    ToDate = toDate,
            //    P2MList = await p2m.ToListAsync(),
            //    ClassList = new SelectList(classList, "Id", "Name") // Set the SelectList for the dropdown
            //};

            //return View(viewModel);
        }



        public IActionResult Index()
        {
            var searchViewModel = new SearchViewModel();

            // Populate default values for objProductList and the list of products
            var objProductList = _unitOfWork.P2M.GetAll().ToList(); // Get all P2M records
            var classList = _unitOfWork.Class.GetAll().ToList(); // Get all products

            // You may perform additional operations on objProductList and productList if needed

        

            ViewBag.ClassList = new SelectList(classList, "Id", "Name"); // Set the SelectList for the dropdown
            return View();
        }
        [HttpPost]
        public IActionResult GenerateReport2(SearchViewModel searchViewModel)
        {
            // Similar logic as before to filter P2M records based on search criteria
            return Ok();
        }

    }
}
