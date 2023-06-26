using Microsoft.EntityFrameworkCore;
using practice_TrekCompany.Data;
using practice_TrekCompany.Interfaces.Spares;
using practice_TrekCompany.Models.spares.sparesEquipment;

namespace practice_TrekCompany.Repository.sparesEquipmentRepositories
{
    public class GripsRepository : IGripsRepository
    {
        private readonly ApplicationDbContext _context;
        public GripsRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public bool Add(Grips grips)
        {
            _context.Add(grips);
            return Save();
        }

        public bool Delete(Grips grips)
        {
            _context.Remove(grips);
            return Save();
        }

        public async Task<IEnumerable<Grips>> GetAll()
        {
            return await _context.Gripses.ToListAsync();
        }

        public async Task<IEnumerable<Grips>> GetByName(string gripsName)
        {
            return await _context.Gripses.Where(c => c.GripsName == gripsName).ToListAsync();
        }

        public bool Save()
        {
            var saved = _context.SaveChanges();
            return saved > 0 ? true : false;
        }

        public bool Update(Grips grips)
        {
            _context.Update(grips);
            return Save();
        }
    }
}
