using System.ComponentModel.DataAnnotations;

namespace practice_TrekCompany.Models.spares.sparesEquipment
{
    public class Handlebar
    {
        //Модель для таблицы sparesEquipment.Brake
        [Key]
        public int HandlbarId { get; set; }
        public string HandlbarName { get; set; }

    }
}
