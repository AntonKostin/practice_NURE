using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using practice_TrekCompany.Data;
using practice_TrekCompany.Interfaces.Spares;
using practice_TrekCompany.Models.spares.sparesEquipment;

namespace practice_TrekCompany.Repository.sparesEquipmentRepositories
{
    public class StemRepository : IStemRepository
    {
        private readonly ApplicationDbContext _context;
        public StemRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public bool Add(Stem stem)
        {
            _context.Add(stem);
            return Save();
        }

        public bool Delete(Stem stem)
        {
            _context.Remove(stem);
            return Save();
        }

        public async Task<IEnumerable<Stem>> GetAll()
        {
            return await _context.Stems.ToListAsync();
        }

        public async Task<IEnumerable<Stem>> GetByName(string stemName)
        {
            return await _context.Stems.Where(c => c.StemName.Contains(stemName)).ToListAsync();
        }

        public bool Save()
        {
            var saved = _context.SaveChanges();
            return saved > 0 ? true : false;
        }

        public bool Update(Stem stem)
        {
            _context.Update(stem);
            return Save();
        }
    }
}
