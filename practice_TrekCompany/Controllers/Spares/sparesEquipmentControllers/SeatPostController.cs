using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using practice_TrekCompany.Data;
using practice_TrekCompany.Models.spares.sparesEquipment;

namespace practice_TrekCompany.Controllers.Spares.sparesEquipmentControllers
{
    public class SeatPostController : Controller
    {
        private readonly ApplicationDbContext _context;

        public SeatPostController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<SeatPost> seatposts = _context.SeatPosts.ToList();
            return View(seatposts);
        }
    }
}
