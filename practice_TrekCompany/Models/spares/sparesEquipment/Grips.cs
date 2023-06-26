using System.ComponentModel.DataAnnotations;

namespace practice_TrekCompany.Models.spares.sparesEquipment
{
    public class Grips
    {
        //Модель для таблицы sparesEquipment.Brake
        [Key]
        public int GripsId { get; set; }
        public string GripsName { get; set; }
    }
}
