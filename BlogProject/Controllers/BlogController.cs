using System;
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
    }
}
