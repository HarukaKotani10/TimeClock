using Microsoft.AspNetCore.Mvc;

namespace clockin.api.Controllers
{
    public class AccessController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public void Get()
        {
            Console.WriteLine("Access Controller Get");
        }

    }
}
