using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using practice_TrekCompany.Data;
using practice_TrekCompany.Models.spares.sparesEquipment;

namespace practice_TrekCompany.Controllers.Spares.sparesEquipmentControllers
{
    public class SaddleController : Controller
    {
        private readonly ApplicationDbContext _context;

        public SaddleController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Saddle> saddles = _context.Saddles.ToList();
            return View(saddles);
        }
    }
}
