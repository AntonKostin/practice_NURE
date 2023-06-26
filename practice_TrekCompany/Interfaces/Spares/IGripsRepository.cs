using practice_TrekCompany.Models.spares.sparesEquipment;

namespace practice_TrekCompany.Interfaces.Spares
{
    public interface IGripsRepository
    {
        Task<IEnumerable<Grips>> GetAll();
        Task<IEnumerable<Grips>> GetByName(string gripsName);
        bool Add(Grips grips);
        bool Update(Grips grips);
        bool Delete(Grips grips);
        bool Save();
    }
}
