using practice_TrekCompany.Models.production;

namespace practice_TrekCompany.Interfaces
{
    public interface IBikeRepository
    {
        Task<IEnumerable<Bike>> GetAll();
        Task<Bike> GetByIdAsync(int id);
        Task<IEnumerable<Bike>> GetBikeByCatagory(string typeName);
        bool Add(Bike bike);
        bool Update(Bike bike);
        bool Delete(Bike bike);
        bool Save ();
    }
}
