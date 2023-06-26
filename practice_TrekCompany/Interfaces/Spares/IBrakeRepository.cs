using practice_TrekCompany.Models.spares.sparesEquipment;

namespace practice_TrekCompany.Interfaces.Spares
{
    public interface IBrakeRepository
    {
        Task<IEnumerable<Brake>> GetAll();
        Task<IEnumerable<Brake>> GetByName(string brakeName);
        bool Add(Brake brake);
        bool Update(Brake brake);
        bool Delete(Brake brake);
        bool Save();
    }
}
