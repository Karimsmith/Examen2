using Examen2.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Examen2.Controllers
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
            ListaCarros lc = ListaCarros.listcar;
            return View(lc.Carros);
        }
        public IActionResult Buscar(String text)
        {
            ListaCarros car = ListaCarros.listcar;
            var carro = car.Carros.Where(x => x.Marca.Contains(text));
            return View(carro);
        }
        public IActionResult VerCarros (int id)
        {
            ListaCarros lc = ListaCarros.listcar;
            Carros cr = lc.Carros.Where(x => x.Id == id).FirstOrDefault();
            if(cr == null)
            {
                return NotFound();
            }
            else
            {
                return View(cr);
            }
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