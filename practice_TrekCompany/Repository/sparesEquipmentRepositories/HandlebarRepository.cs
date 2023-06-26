using Microsoft.EntityFrameworkCore;
using practice_TrekCompany.Data;
using practice_TrekCompany.Interfaces.Spares;
using practice_TrekCompany.Models.spares.sparesEquipment;

namespace practice_TrekCompany.Repository.sparesEquipmentRepositories
{
    public class HandlebarRepository : IHandlebarRepository
    {
        private readonly ApplicationDbContext _context;
        public HandlebarRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public bool Add(Handlebar handlebar)
        {
            _context.Add(handlebar);
            return Save();
        }

        public bool Delete(Handlebar handlebar)
        {
            _context.Remove(handlebar);
            return Save();
        }

        public async Task<IEnumerable<Handlebar>> GetAll()
        {
            return await _context.Handlebars.ToListAsync();
        }

        public async Task<IEnumerable<Handlebar>> GetByName(string handlebarName)
        {
            return await _context.Handlebars.Where(c => c.HandlbarName.Contains(handlebarName)).ToListAsync();
        }

        public bool Save()
        {
            var saved = _context.SaveChanges();
            return saved > 0 ? true : false;
        }

        public bool Update(Handlebar handlebar)
        {
            _context.Update(handlebar);
            return Save();
        }
    }
}
