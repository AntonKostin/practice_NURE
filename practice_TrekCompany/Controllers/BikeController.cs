using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using practice_TrekCompany.Data;
using practice_TrekCompany.Models.production;

namespace practice_TrekCompany.Controllers
{
    public class BikeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public BikeController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            List<Bike> bikes = _context.Bikes
                .Include(a => a.TypeOfBike).ToList();
            return View(bikes);
        }

        public IActionResult Detail(int id)
        {
            Bike bike = _context.Bikes
                .Include(a => a.Wheelset.Rim)
                .Include(a => a.Wheelset.Hub)
                .Include(a => a.Wheelset.Tire)
                .Include(a => a.Frameset.Frame)
                .Include(a => a.Frameset.Fork)
                .Include(a => a.Groopset.Transmition.Cassette)
                .Include(a => a.Groopset.Transmition.Switch)
                .Include(a => a.Groopset.Transmition.Shifter)
                .Include(a => a.Groopset.Transmition)
                .Include(a => a.Groopset.Pedals)
                .Include(a => a.Groopset.Carriage)
                .Include(a => a.Equipment.Brake)
                .Include(a => a.Equipment.Grips)
                .Include(a => a.Equipment.Handlebar)
                .Include(a => a.Equipment.Saddle)
                .Include(a => a.Equipment.SeatPost)
                .Include(a => a.Equipment.Steering)
                .Include(a => a.Equipment.Stem)
                .Include(a => a.TypeOfBike)
                .FirstOrDefault(c => c.bikeId == id);
            return View(bike);
        }
    }
}
