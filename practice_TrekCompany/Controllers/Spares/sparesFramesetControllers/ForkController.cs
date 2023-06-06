using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using practice_TrekCompany.Data;
using practice_TrekCompany.Models.spares.sparesFrameset;

namespace practice_TrekCompany.Controllers.Spares.sparesFramesetControllers
{
    public class ForkController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ForkController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Fork> forks = _context.Forks.ToList();
            return View(forks);
        }
    }
}
