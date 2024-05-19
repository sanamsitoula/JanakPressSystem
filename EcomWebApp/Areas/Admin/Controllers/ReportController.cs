using Ecom.DataAccess.Data;
using Ecom.DataAccess.Repository.IRepository;
using Ecom.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.CodeAnalysis;
using Microsoft.SqlServer.Server;
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
        public IActionResult P2MReport()
        {
            List<P2M>? objProductList = _unitOfWork.P2M.
              GetAll()?
          .Select(P2M => new P2M
          {
              Id = P2M.Id,
              Name = P2M.Name,
              ProductId = P2M.ProductId,
              JobStepId = P2M.JobStepId,
             


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
                  
                    


                });
            }
            return View(objProductList);
        }

       
    }
}
