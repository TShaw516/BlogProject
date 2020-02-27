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
        public IActionResult Index()
        {
            var model = myCategories.GetAll();
            return View(model);
        }

        public IActionResult Detail(int id)
        {
            var model = myCategories.GetById(id);
            return View(model);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Category category)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            myCategories.Create(category);
            return RedirectToAction("Index");
        }
    }
}
