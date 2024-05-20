using Ecom.DataAccess.Data;
using Ecom.DataAccess.Repository.IRepository;
using Ecom.Models;
using Ecom.Utility;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.CodeAnalysis;
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
        public IActionResult P2MReport(DateTime? specificDate)
        {
            if (specificDate == null)
            {
                specificDate = DateTime.Now.Date;

            }
            DateTime dateTimeValue = (DateTime)specificDate;
            string dateString = dateTimeValue.ToString("yyyy-MM-dd");
            // Filter the P2M records based on the specific date
            List<P2M>? objProductList = _unitOfWork.P2M.GetAll()?
                .Where(p2m => p2m.P2MDate == dateString) // Filter records for the specific date
                .Select(p2m => new P2M
                {
                    Id = p2m.Id,
                    Name = p2m.Name,
                    ProductId = p2m.ProductId,
                    JobStepId = p2m.JobStepId,
                    P2MDate = p2m.P2MDate,
                })
                .OrderByDescending(c => c.Id)
                .ToList();

            if (objProductList != null)
            {
                objProductList.ForEach(e =>
                {
                    // Set the Product property if necessary
                    var product = _unitOfWork.Product.GetFirstOrDefault(c => c.Id == e.ProductId);
                    if (product != null)
                    {
                        e.Product = new Product
                        {
                            Title = product.Title,
                            Id = product.Id,
                        };
                    }
                });
            }

            return View(objProductList);
        }

    }
}
