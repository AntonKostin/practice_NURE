using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using practice_TrekCompany.Data;
using practice_TrekCompany.Models.spares.sparesEquipment;

namespace practice_TrekCompany.Controllers.Spares.sparesEquipmentControllers
{
    public class SteeringController : Controller
    {
        private readonly ApplicationDbContext _context;

        public SteeringController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Steering> steerings = _context.Steerings.ToList();
            return View(steerings);
        }
    }
}
