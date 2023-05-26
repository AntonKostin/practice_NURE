using System.ComponentModel.DataAnnotations;

namespace practice_TrekCompany.Models.sparesTransmition
{
    public class Switch
    {
        //Модель для таблицы sparesTransmition.Switch
        [Key]
        public int switchId { get; set; }
        public string switchName { get; set; }
    }
}
