using Microsoft.EntityFrameworkCore;
using practice_TrekCompany.Data;
using practice_TrekCompany.Interfaces.Spares;
using practice_TrekCompany.Models.spares.sparesEquipment;

namespace practice_TrekCompany.Repository.sparesEquipmentRepositories
{
    public class SaddleRepository : ISaddleRepository
    {
        private readonly ApplicationDbContext _context;
        public SaddleRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public bool Add(Saddle saddle)
        {
            _context.Add(saddle);
            return Save();
        }

        public bool Delete(Saddle saddle)
        {
            _context.Remove(saddle);
            return Save();
        }

        public async Task<IEnumerable<Saddle>> GetAll()
        {
            return await _context.Saddles.ToListAsync();
        }

        public async Task<IEnumerable<Saddle>> GetByName(string saddleName)
        {
            return await _context.Saddles.Where(c => c.SaddleName.Contains(saddleName)).ToListAsync();
        }

        public bool Save()
        {
            var saved = _context.SaveChanges();
            return saved > 0 ? true : false;
        }

        public bool Update(Saddle saddle)
        {
            _context.Update(saddle);
            return Save();
        }
    }
}
