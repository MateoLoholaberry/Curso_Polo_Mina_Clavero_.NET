using Microsoft.AspNetCore.Mvc;
using Proyecto_final.Models;
using Proyecto_final.Rules;
using System.Diagnostics;

namespace Proyecto_final.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IConfiguration _configuration;

        public HomeController(ILogger<HomeController> logger, IConfiguration configuration)
        {
            _logger = logger;
            _configuration = configuration;
        }

        public IActionResult Index()
        {
            var rule = new PublicacionRule(_configuration);
            var posts = rule.GetPostHome();
            return View(posts);
        }

       
        public IActionResult Suerte()
        {
            var rule = new PublicacionRule(_configuration);
            var post = rule.GetOnePostRandom();
            return View(post);
        }

        public IActionResult Contacto()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Contacto(Contacto contacto)
        {
            if (!ModelState.IsValid)
            {
                return View(contacto);
            }

            return View();
        }

        public IActionResult AcercaDe()
        {
            return View();
        }


        public IActionResult Post(int id)
        {
            var rule = new PublicacionRule(_configuration);
            var post = rule.GetPostById(id);

            if (post == null)
            {
                return NotFound();
            }

            return View(post);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}