using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using practice_TrekCompany.Data;
using practice_TrekCompany.Models.spares.sparesGroopset;

namespace practice_TrekCompany.Controllers.Spares.sparesGroopsetControllers
{
    public class PedalsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PedalsController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Pedals> pedals = _context.Pedalses.ToList();
            return View(pedals);
        }
    }
}
