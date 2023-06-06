using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using practice_TrekCompany.Data;
using practice_TrekCompany.Models.spares.sparesGroopset;

namespace practice_TrekCompany.Controllers.Spares.sparesGroopsetControllers
{
    public class CarriageController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CarriageController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Carriage> carriages = _context.Carriages.ToList();
            return View(carriages);
        }
    }
}
