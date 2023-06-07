using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using practice_TrekCompany.Data;
using practice_TrekCompany.Models.spares.sparesEquipment;

namespace practice_TrekCompany.Controllers.Spares.sparesEquipmentControllers
{
        public class BrakeController : Controller
        {   
            private readonly ApplicationDbContext _context;

             public BrakeController(ApplicationDbContext context)
             {
                 _context = context;
             }
            public IActionResult Index()
            {
                List<Brake> brakes = _context.Brakes.ToList();
                return View(brakes);
            }
        }
}
