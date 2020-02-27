using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogProject.Models;
using BlogProject.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace BlogProject.Controllers
{
    public class TagController : Controller
    {
        IRepository<Tag> myTags;

        public TagController(IRepository<Tag> myTags)
        {
            this.myTags = myTags;
        }

        // GET: /<controller>/
        public ActionResult Index()
        {
            var model = myTags.GetAll();
            return View(model);
        }

        public IActionResult Detail(int id)
        {
            var model = myTags.GetById(id);
            return View(model);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Tag tag)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            myTags.Create(tag);
            return RedirectToAction("Index");
        }
    }
}