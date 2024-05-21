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
    
            public async Task<IActionResult> P2MReport(string searchString, int? classId, int? productId, DateTime? fromDate, DateTime? toDate)
            {
                var p2m = from p in _unitOfWork.P2M.GetAll()
                               select p;
                if (!String.IsNullOrEmpty(searchString))
            {
                p2m = p2m.Where(p => p.Name.Contains(searchString));
            }

            if (classId.HasValue)
            {
                p2m = p2m.Where(p => p.ClassId == classId);
            }

            if (productId.HasValue)
            {
                p2m = p2m.Where(p => p.ProductId == productId);
            }

            if (fromDate.HasValue)
            {
                p2m = p2m.Where(p => p.P2MDate >= fromDate);
            }

            if (toDate.HasValue)
            {
                p2m = p2m.Where(p => p.P2MDate <= toDate);
            }

            return View(await p2m.ToListAsync());
        }

        public IActionResult Index()
        {
            var searchViewModel = new SearchViewModel();

            // Populate default values for objProductList and the list of products
            var objProductList = _unitOfWork.P2M.GetAll().ToList(); // Get all P2M records
            var classList = _unitOfWork.Class.GetAll().ToList(); // Get all products

            // You may perform additional operations on objProductList and productList if needed

            var ReportViewModel = new ReportViewModel
            {
                P2MList = objProductList,
                ClassList = classList
            };

            ViewBag.ClassList = new SelectList(classList, "Id", "Name"); // Set the SelectList for the dropdown
            return View(ReportViewModel);
        }
        [HttpPost]
        public IActionResult GenerateReport2(SearchViewModel searchViewModel)
        {
            // Similar logic as before to filter P2M records based on search criteria
            return Ok();
        }

    }
}
