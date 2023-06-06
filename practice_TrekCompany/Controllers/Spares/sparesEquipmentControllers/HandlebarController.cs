using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using practice_TrekCompany.Data;
using practice_TrekCompany.Models.spares.sparesEquipment;

namespace practice_TrekCompany.Controllers.Spares.sparesEquipmentControllers
{
    public class HandlebarController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HandlebarController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Handlebar> handlebars = _context.Handlebars.ToList();
            return View(handlebars);
        }
    }
}
