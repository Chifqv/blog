using blog.Data;
using blog.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text.Json;

namespace blog.Controllers
{
    public class HomeController : Controller
    {
        PostRepository postRepository;

        public HomeController(PostRepository postrep)
        {
            this.postRepository = postrep;
        }
        public IActionResult Index()
        {
            
            var posts = postRepository.GetAll();

            return View(posts);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Profile()
        {
            return View();
        }
    }
}
