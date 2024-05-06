using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication6.Controllers
{
    public class Demo : Controller
    {
        [AllowAnonymous]
        public IActionResult Index()
        {
            return View();
        }
        [Authorize]
        public IActionResult Policy()
        {
            return View();
        }
        [Authorize]
        public IActionResult Details()
        {
            return View();
        }
    }
}
