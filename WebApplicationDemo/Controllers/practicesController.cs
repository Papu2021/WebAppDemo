using Microsoft.AspNetCore.Mvc;

namespace WebApplicationDemo.Controllers
{
    public class practicesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
