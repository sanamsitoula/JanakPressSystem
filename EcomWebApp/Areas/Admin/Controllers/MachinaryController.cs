using Ecom.DataAccess.Data;
using Ecom.DataAccess.Repository.IRepository;
using Ecom.Models;
using Ecom.Utility;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Ecom.WebApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class MachinaryController : Controller
    {
      
        private readonly IUnitOfWork _unitOfWork;
        public MachinaryController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;

        }
        public IActionResult Index()
        {
            var classes = _unitOfWork.Class.GetAll(); // Fetch products from your repository
            var categories = _unitOfWork.Category.GetAll(); // Fetch categories from your repository
            var subjects = _unitOfWork.Subject.GetAll(); // Fetch categories from your repository
            var fromas = _unitOfWork.Forma.GetAll(); // Fetch categories from your repository
                                                     // Assuming you have a ViewModel for displaying data in the view

            List<Machinary>? objProductList = _unitOfWork.Machinary.
                GetAll()?
            .Select(machinary => new Machinary
            {
                Id = machinary.Id,
                Name = machinary.Name,
                Description = machinary.Description,
                Status = machinary.Status,
                JobStepId = machinary.JobStepId

                // Set values for any other new properties
            })
            .ToList();



            //objProductList.ForEach(e =>
            //{

            //    e.Category = new Category // Assuming Category is a complex object
            //    {
            //        Name = _unitOfWork.Category.GetFirstOrDefault(c => c.Id == e.CategoryId).Name,
            //        // Set other properties of the Category object if needed
            //    };
            //    e.Class = new Class // Assuming Category is a complex object
            //    {
            //        Name = _unitOfWork.Class.GetFirstOrDefault(c => c.Id == e.ClassId).Name,
            //        // Set other properties of the Category object if needed
            //    };
            //    e.Subject = new Subject // Assuming Category is a complex object
            //    {
            //        Name = _unitOfWork.Subject.GetFirstOrDefault(c => c.Id == e.SubjectId).Name,
            //        // Set other properties of the Category object if needed
            //    };

            //});

            return View(objProductList);
        }

        public IActionResult Create()
        {
            //var model = new Product() { };
            List<Forma>? obj = _unitOfWork.Forma.GetAll().ToList();
            List<Class>? objc = _unitOfWork.Class.GetAll().ToList();
            List<Subject>? objs = _unitOfWork.Subject.GetAll().ToList();
            List<Category>? catobj = _unitOfWork.Category.GetAll().ToList();


            // Convert the List<Forma>? to IEnumerable<SelectListItem>
            IEnumerable<SelectListItem>? selectListItems = obj?.Select(form => new SelectListItem
            {
                Value = form.Id.ToString(), // Replace with the actual property you want as the value
                Text = form.Name // Replace with the actual property you want as the text
            });


            // Convert the List<Forma>? to IEnumerable<SelectListItem>
            IEnumerable<SelectListItem>? selectListItems1 = objc?.Select(c => new SelectListItem
            {
                Value = c.Id.ToString(), // Replace with the actual property you want as the value
                Text = c.Name // Replace with the actual property you want as the text
            });

            // Convert the List<Forma>? to IEnumerable<SelectListItem>
            IEnumerable<SelectListItem>? selectListItems2 = objs?.Select(s => new SelectListItem
            {
                Value = s.Id.ToString(), // Replace with the actual property you want as the value
                Text = s.Name // Replace with the actual property you want as the text
            });

            // Convert the List<Forma>? to IEnumerable<SelectListItem>
            IEnumerable<SelectListItem>? selectListItems3 = catobj?.Select(s => new SelectListItem
            {
                Value = s.Id.ToString(), // Replace with the actual property you want as the value
                Text = s.Name // Replace with the actual property you want as the text
            });




            // Store the IEnumerable<SelectListItem> in ViewBag
            ViewBag.Forma = selectListItems;
            ViewBag.classlist = selectListItems1;
            ViewBag.subjectlist = selectListItems2;
            ViewBag.categorylist = selectListItems3;


            return View();
        }
      
    }
}
