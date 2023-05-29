using System.ComponentModel.DataAnnotations;

namespace practice_TrekCompany.Models.spares.sparesEquipment
{
    public class Stem
    {
        //Модель для таблицы sparesEquipment.Brake
        [Key]
        public int stemId { get; set; }
        public string stemName { get; set; }
    }
}
