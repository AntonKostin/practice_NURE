using Microsoft.AspNetCore.Mvc;

namespace practice_TrekCompany.Controllers.Spares
{
    public class SparesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
