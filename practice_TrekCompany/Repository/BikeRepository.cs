using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using practice_TrekCompany.Data;
using practice_TrekCompany.Interfaces;
using practice_TrekCompany.Models.production;

namespace practice_TrekCompany.Repository
{
    public class BikeRepository : IBikeRepository
    {
        private readonly ApplicationDbContext _context;
        public BikeRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public bool Add(Bike bike)
        {
            _context.Add(bike);
            return Save();
        }

        public bool Delete(Bike bike)
        {
            _context.Remove(bike);
            return Save();
        }

        public async Task<IEnumerable<Bike>> GetAll()
        {
            return await _context.Bikes.ToListAsync();
        }

        public async Task<IEnumerable<Bike>> GetBikeByCatagory(string typeName)
        {
            return await _context.Bikes.Where(c => c.TypeOfBike.TypeName.Contains(typeName)).ToListAsync();
        }

        public async Task<Bike> GetByIdAsync(int id)
        {
            return await _context.Bikes.FirstOrDefaultAsync(i => i.BikeId == id);
        }

        public bool Save()
        {
            var saved = _context.SaveChanges();
            return saved > 0 ? true : false;
        }

        public bool Update(Bike bike)
        {
            _context.Update(bike);
            return Save();
        }
    }
}
