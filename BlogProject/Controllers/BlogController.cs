﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogProject.Models;
using BlogProject.Repositories;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BlogProject.Controllers
{
    public class BlogController : Controller
    {

        IRepository<Blog> myBlogs;

        public BlogController(IRepository<Blog> myBlogs)
        {
            this.myBlogs = myBlogs;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            var model = myBlogs.GetAll();
            return View(model);
        }

        public IActionResult Detail(int id)
        {
            var model = myBlogs.GetById(id);
            return View(model);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Blog blog)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            myBlogs.Create(blog);
            return RedirectToAction("Index");
        }

        //ViewBag
        [HttpGet]
        public ViewResult CreateByProductId(int id)
        {
            ViewBag.BlogId = id;
            return View();
        }

        [HttpGet]
        public ViewResult Update(int id)
        {
            var model = myBlogs.GetById(id);
            return View(model);
        }

        //Breaking Here
        [HttpPost]
        public ActionResult Update(Blog blog)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            myBlogs.Update(blog);
            return RedirectToAction("Detail", "Blog", new { id = blog.BlogId });
        }


        [HttpGet]
        public ViewResult Delete(int id)
        {
            Blog model = myBlogs.GetById(id);
            return View(model);
        }

        [HttpPost]
        public ActionResult Delete(Blog blog)
        {
            myBlogs.Delete(blog);
            return RedirectToAction("Index", "Blog");
        }

    }
}
