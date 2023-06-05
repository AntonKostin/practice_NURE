using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using practice_TrekCompany.Data;
using practice_TrekCompany.Models.factory;

namespace practice_TrekCompany.Controllers
{
    public class StaffController : Controller
    {
        private readonly ApplicationDbContext _context;

        public StaffController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {

            List<Staff> staff = _context.Staffs
                .Include(a => a.Factory)
                .Include(a => a.JobTitle).ToList();
            return View(staff);
        }
    }
}
