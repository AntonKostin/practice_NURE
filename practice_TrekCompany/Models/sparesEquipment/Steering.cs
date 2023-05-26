using System.ComponentModel.DataAnnotations;

namespace practice_TrekCompany.Models.sparesEquipment
{
    public class Steering
    {
        //Модель для таблицы sparesEquipment.Brake
        [Key]
        public int steeringId { get; set; }
        public string steeringName { get; set; }
    }
}
