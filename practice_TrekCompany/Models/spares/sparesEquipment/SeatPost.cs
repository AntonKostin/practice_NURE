using System.ComponentModel.DataAnnotations;

namespace practice_TrekCompany.Models.spares.sparesEquipment
{
    public class SeatPost
    {
        //Модель для таблицы sparesEquipment.Brake
        [Key]
        public int seatPostId { get; set; }
        public string seatPostName { get; set; }
    }
}
