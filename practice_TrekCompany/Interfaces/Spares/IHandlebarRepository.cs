using practice_TrekCompany.Models.spares.sparesEquipment;

namespace practice_TrekCompany.Interfaces.Spares
{
    public interface IHandlebarRepository
    {
        Task<IEnumerable<Handlebar>> GetAll();
        Task<IEnumerable<Handlebar>> GetByName(string handlebarName);
        bool Add(Handlebar handlebar);
        bool Update(Handlebar handlebar);
        bool Delete(Handlebar handlebar);
        bool Save();
    }
}
