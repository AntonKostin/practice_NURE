using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using practice_TrekCompany.Data;
using practice_TrekCompany.Interfaces.Spares;
using practice_TrekCompany.Models.spares.sparesEquipment;

namespace practice_TrekCompany.Repository.sparesEquipmentRepositories
{
    public class SteeringRepository : ISteeringRepository
    {
        private readonly ApplicationDbContext _context;
        public SteeringRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public bool Add(Steering steeringName)
        {
            _context.Add(steeringName);
            return Save();
        }

        public bool Delete(Steering steeringName)
        {
            _context.Add(steeringName);
            return Save();
        }

        public async Task<IEnumerable<Steering>> GetAll()
        {
            return await _context.Steerings.ToListAsync();
        }

        public async Task<IEnumerable<Steering>> GetByName(string steeringName)
        {
            return await _context.Steerings.Where(c => c.SteeringName.Contains(steeringName)).ToListAsync();
        }

        public bool Save()
        {
            var saved = _context.SaveChanges();
            return saved > 0 ? true : false;
        }

        public bool Update(Steering steeringName)
        {
            _context.Add(steeringName);
            return Save();
        }
    }
}
