using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using practice_TrekCompany.Data;
using practice_TrekCompany.Models.spares.sparesWheelset;

namespace practice_TrekCompany.Controllers.Spares.sparesWheelsetControllers
{
    public class HubController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HubController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Hub> hubs = _context.Hubs.ToList();
            return View(hubs);
        }
    }
}
