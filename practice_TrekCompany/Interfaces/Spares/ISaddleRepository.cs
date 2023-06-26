using practice_TrekCompany.Models.spares.sparesEquipment;

namespace practice_TrekCompany.Interfaces.Spares
{
    public interface ISaddleRepository
    {
        Task<IEnumerable<Saddle>> GetAll();
        Task<IEnumerable<Saddle>> GetByName(string saddleName);
        bool Add(Saddle saddle);
        bool Update(Saddle saddle);
        bool Delete(Saddle saddle);
        bool Save();
    }
}
