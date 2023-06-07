using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using practice_TrekCompany.Data;
using practice_TrekCompany.Models.spares.sparesWheelset;

namespace practice_TrekCompany.Controllers.Spares.sparesWheelsetControllers
{
    public class TireController : Controller
    {
        private readonly ApplicationDbContext _context;

        public TireController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Tire> tires = _context.Tires.ToList();
            return View(tires);
        }
    }
}
