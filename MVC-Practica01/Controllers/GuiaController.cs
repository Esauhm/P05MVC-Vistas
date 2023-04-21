using Microsoft.AspNetCore.Mvc;

namespace MVC_Practica01.Controllers
{
    public class GuiaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
