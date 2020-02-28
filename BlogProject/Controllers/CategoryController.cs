using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogProject.Models;
using BlogProject.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace BlogProject.Controllers
{
    public class CategoryController : Controller
    {
        IRepository<Category> myCategories;

        public CategoryController(IRepository<Category> myCategories)
        {
            this.myCategories = myCategories;
        }

        // GET: /<controller>/
        public ViewResult Index()
        {
            var model = myCategories.GetAll();
            return View(model);
        }

        public ViewResult Detail(int id)
        {
            var model = myCategories.GetById(id);
            return View(model);
        }

        [HttpGet]
        public ViewResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Category category)
        {
            
            myCategories.Create(category);
            return RedirectToAction("Index", "Category");
        }

        [HttpGet]
        public ViewResult Update(int id)
        {
            var model = myCategories.GetById(id);

            return View(model);
        }

        [HttpPost]
        public ActionResult Update(Category category)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            myCategories.Update(category);

            return RedirectToAction("Index");
        }

        [HttpGet]
        public ViewResult Delete(int id)
        {
            var model = myCategories.GetById(id);

            return View(model);
        }

        [HttpPost]
        public ActionResult Delete(Category category)
        {
            myCategories.Delete(category);

            return RedirectToAction("Index");
        }
    }
}
