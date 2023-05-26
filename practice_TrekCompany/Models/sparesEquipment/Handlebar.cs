using System.ComponentModel.DataAnnotations;

namespace practice_TrekCompany.Models.sparesEquipment
{
    public class Handlebar
    {
        //Модель для таблицы sparesEquipment.Brake
        [Key]
        public int handlbarId { get; set; }
        public string handlbarName { get; set; }

    }
}
