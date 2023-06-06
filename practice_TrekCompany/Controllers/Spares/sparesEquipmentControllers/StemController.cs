using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using practice_TrekCompany.Data;
using practice_TrekCompany.Models.spares.sparesEquipment;

namespace practice_TrekCompany.Controllers.Spares.sparesEquipmentControllers
{
    public class StemController : Controller
    {
        private readonly ApplicationDbContext _context;

        public StemController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Stem> stems = _context.Stems.ToList();
            return View(stems);
        }
    }
}
