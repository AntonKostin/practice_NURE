using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using practice_TrekCompany.Data;
using practice_TrekCompany.Models.spares.sparesGroopset;

namespace practice_TrekCompany.Controllers.Spares.sparesGroopsetControllers
{
    public class TransmitionController : Controller
    {
        private readonly ApplicationDbContext _context;

        public TransmitionController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Transmition> transmitions = _context.Transmitions
                .Include(a => a.Cassette)
                .Include(a => a.Shifter)
                .Include(a => a.Switch).ToList();
            return View(transmitions);
        }
    }
}
