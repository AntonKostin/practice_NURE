using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using practice_TrekCompany.Data;
using practice_TrekCompany.Interfaces.Spares;
using practice_TrekCompany.Models.spares.sparesEquipment;

namespace practice_TrekCompany.Repository.sparesEquipmentRepositories
{
    public class SeatPostRepository : ISeatPostRepository
    {
        private readonly ApplicationDbContext _context;
        public SeatPostRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public bool Add(SeatPost seatPost)
        {
            _context.Add(seatPost);
            return Save();
        }

        public bool Delete(SeatPost seatPost)
        {
            _context.Remove(seatPost);
            return Save();
        }

        public async Task<IEnumerable<SeatPost>> GetAll()
        {
            return await _context.SeatPosts.ToListAsync();
        }

        public async Task<IEnumerable<SeatPost>> GetByName(string seatPostName)
        {
            return await _context.SeatPosts.Where(c => c.SeatPostName.Contains(seatPostName)).ToListAsync();
        }

        public bool Save()
        {
            var saved = _context.SaveChanges();
            return saved > 0 ? true : false;
        }

        public bool Update(SeatPost seatPost)
        {
            _context.Update(seatPost);
            return Save();
        }
    }
}
