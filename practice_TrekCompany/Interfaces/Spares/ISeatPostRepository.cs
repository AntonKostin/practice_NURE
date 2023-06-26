using practice_TrekCompany.Models.spares.sparesEquipment;

namespace practice_TrekCompany.Interfaces.Spares
{
    public interface ISeatPostRepository
    {
        Task<IEnumerable<SeatPost>> GetAll();
        Task<IEnumerable<SeatPost>> GetByName(string seatPostName);
        bool Add(SeatPost seatPost);
        bool Update(SeatPost seatPost);
        bool Delete(SeatPost seatPost);
        bool Save();
    }
}
