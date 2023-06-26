using System.ComponentModel.DataAnnotations;

namespace practice_TrekCompany.Models.spares.sparesEquipment
{
    public class Brake
    {
        //Модель для таблицы sparesEquipment.Brake
        [Key]
        public int BrakeId { get; set; }
        public string BrakeName { get; set; }
    }
}
