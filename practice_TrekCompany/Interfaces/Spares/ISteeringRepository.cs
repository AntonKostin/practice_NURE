using practice_TrekCompany.Models.spares.sparesEquipment;

namespace practice_TrekCompany.Interfaces.Spares
{
    public interface ISteeringRepository
    {
        Task<IEnumerable<Steering>> GetAll();
        Task<IEnumerable<Steering>> GetByName(string steeringName);
        bool Add(Steering steeringName);
        bool Update(Steering steeringName);
        bool Delete(Steering steeringName);
        bool Save();
    }
}
