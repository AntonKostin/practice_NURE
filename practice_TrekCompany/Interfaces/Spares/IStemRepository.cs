using practice_TrekCompany.Models.spares.sparesEquipment;

namespace practice_TrekCompany.Interfaces.Spares
{
    public interface IStemRepository
    {
        Task<IEnumerable<Stem>> GetAll();
        Task<IEnumerable<Stem>> GetByName(string stemName);
        bool Add(Stem stem);
        bool Update(Stem stem);
        bool Delete(Stem stem);
        bool Save();
    }
}
