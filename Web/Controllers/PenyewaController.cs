using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    public class PenyewaController : Controller
    {
        [HttpGet]
        public IActionResult CreateGet()
        {
            return View();
        }
    }
}
