using System.Diagnostics;
using blog.Models;
using Microsoft.AspNetCore.Mvc;

namespace blog.Controllers
{
    public class HomeController : Controller
    {

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

        public IActionResult Profile()
        {
            return View();
        }
    }
}
