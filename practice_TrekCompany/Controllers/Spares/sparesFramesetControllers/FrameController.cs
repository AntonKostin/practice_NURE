using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using practice_TrekCompany.Data;
using practice_TrekCompany.Models.spares.sparesFrameset;

namespace practice_TrekCompany.Controllers.Spares.sparesFramesetControllers
{
    public class FrameController : Controller
    {
        private readonly ApplicationDbContext _context;

        public FrameController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Frame> frames = _context.Frames.ToList();
            return View(frames);
        }
    }
}
