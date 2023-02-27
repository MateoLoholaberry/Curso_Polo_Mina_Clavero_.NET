using Microsoft.AspNetCore.Mvc;

namespace Introducción_a_Js_parte_2.Controllers
{
    public class PostController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
