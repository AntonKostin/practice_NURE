using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using practice_TrekCompany.Data;
using practice_TrekCompany.Interfaces.Spares;
using practice_TrekCompany.Models.spares.sparesEquipment;

namespace practice_TrekCompany.Repository.sparesEquipmentRepositories
{
    public class BrakeRepository : IBrakeRepository
    {
        private readonly ApplicationDbContext _context;
        public BrakeRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public bool Add(Brake brake)
        {
            _context.Add(brake);
            return Save();
        }

        public bool Delete(Brake brake)
        {
            _context.Remove(brake);
            return Save();
        }

        public async Task<IEnumerable<Brake>> GetAll()
        {
            return await _context.Brakes.ToListAsync();
        }

        public async Task<IEnumerable<Brake>> GetByName(string brakeName)
        {
            return await _context.Brakes.Where(c => c.BrakeName.Contains(brakeName)).ToListAsync();
        }

        public bool Save()
        {
            var saved = _context.SaveChanges();
            return saved > 0 ? true : false;
        }

        public bool Update(Brake brake)
        {
            _context.Update(brake);
            return Save();
        }
    }
}
