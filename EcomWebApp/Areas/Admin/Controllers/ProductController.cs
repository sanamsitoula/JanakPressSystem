﻿using Ecom.DataAccess.Data;
using Ecom.DataAccess.Repository.IRepository;
using Ecom.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Text;
using Ecom.Utility;

namespace Ecom.WebApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductController : Controller
    {
      
        private readonly IUnitOfWork _unitOfWork;
        public ProductController(IUnitOfWork unitOfWork)
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

            List<Product>? objProductList = _unitOfWork.Product.                
                GetAll()?
            .Select(product => new Product
            {
                Id = product.Id,
                Title = product.Title,
                CategoryId = product.CategoryId,
               // FormaListId = string.IsNullOrEmpty(product.FormaListId)?"" : product.FormaListId,
                SubjectId = product.SubjectId,
                ClassId = product.ClassId,
                SubjectLanguageId = product.SubjectLanguageId,
                SubjectTypeId= product.SubjectTypeId,
                FormaNumber=product.FormaNumber,
                PageNumber=product.PageNumber,
                Description=product.Description
                

            

            // Set values for any other new properties
        })
            .ToList();

         

            objProductList.ForEach(e =>
            {
               
                e.Category = new Category // Assuming Category is a complex object
                {
                    Name = _unitOfWork.Category.GetFirstOrDefault(c => c.Id == e.CategoryId).Name,
                    // Set other properties of the Category object if needed
                };
                e.Class = new Class // Assuming Category is a complex object
                {
                    Name = _unitOfWork.Class.GetFirstOrDefault(c => c.Id == e.ClassId).Name,
                    // Set other properties of the Category object if needed
                };
                e.Subject = new Subject // Assuming Category is a complex object
                {
                    Name = _unitOfWork.Subject.GetFirstOrDefault(c => c.Id == e.SubjectId).Name,
                    // Set other properties of the Category object if needed
                };
              
            });

            return View(objProductList);
        }

        public IActionResult Create()
        {
            //var model = new Product() { };
            List < Forma >? obj = _unitOfWork.Forma.GetAll().ToList();
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
        [HttpPost]
        public IActionResult Create(Product c)
        {
           

                if (ModelState.IsValid)
            {
                c.Description = "PRO-" + DateTime.Now.Year + "-" + DateTime.Now.Month + "-" + UniqueCodeGenerator.GenerateUniqueCodeFromTimestamp();

                _unitOfWork.Product.Add(c);
                _unitOfWork.Save();
                TempData["success"] = "Product Created Sucessfully";
                return RedirectToAction("Index", "Product");
            }

            return RedirectToAction("Create", "Product");

        }


        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            Product? cd = _unitOfWork.Product.GetFirstOrDefault(u => u.Id == id);
            if (cd == null) { return NotFound(); }
            return View(cd);
        }
        [HttpPost]
        public IActionResult Edit(Product c)
        {


            c.Status = true;
            c.CreatedBy = "1";
            if (ModelState.IsValid)
            {
                _unitOfWork.Product.Update(c);
                _unitOfWork.Save();
                TempData["success"] = "Product Edited Sucessfully";
                return RedirectToAction("Index", "Product");
            }



            return View();
        }


        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            Product? cd = _unitOfWork.Product.GetFirstOrDefault(u => u.Id == id);
            if (cd == null) { return NotFound(); }
            return View(cd);
        }
        [HttpPost, ActionName("Delete")]
        public IActionResult DeletePost(int? id)
        {

            Product c = _unitOfWork.Product.GetFirstOrDefault(u => u.Id == id);
            if (c == null)
            {
                return NotFound();

            }
            if (ModelState.IsValid)
            {
                c.Status = false;
                _unitOfWork.Product.Remove(c);
                _unitOfWork.Save();
                TempData["success"] = "Product Deleted Sucessfully";
                return RedirectToAction("Index", "Product");
            }

            return View();
        }
    }

 
}
