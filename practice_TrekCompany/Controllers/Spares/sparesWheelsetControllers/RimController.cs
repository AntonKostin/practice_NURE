using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using practice_TrekCompany.Data;
using practice_TrekCompany.Models.spares.sparesWheelset;

namespace practice_TrekCompany.Controllers.Spares.sparesWheelsetControllers
{
    public class RimController : Controller
    {
        private readonly ApplicationDbContext _context;

        public RimController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Rim> rims = _context.Rims.ToList();
            return View(rims);
        }
    }
}
