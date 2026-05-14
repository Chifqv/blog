using System.Diagnostics;
using blog.Models;
using Microsoft.AspNetCore.Mvc;

namespace blog.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            User user = new User("Eli", "eli@mail.ru", "00");
            List<Post> posts = new List<Post>() { 
            new Post("hi!","https://avatars.mds.yandex.net/i?id=ee144099594ad4bd83755a6a556ba3a4_l-5088988-images-thumbs&n=13",user),
            new Post("hi!","https://avatars.mds.yandex.net/i?id=ee144099594ad4bd83755a6a556ba3a4_l-5088988-images-thumbs&n=13",user),
            new Post("hi!","https://avatars.mds.yandex.net/i?id=ee144099594ad4bd83755a6a556ba3a4_l-5088988-images-thumbs&n=13",user)
            };

            return View(posts);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
