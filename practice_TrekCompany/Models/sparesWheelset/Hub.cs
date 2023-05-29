using System.ComponentModel.DataAnnotations;

namespace practice_TrekCompany.Models.sparesWheelset
{
    public class Hub
    {
        //Модель для таблицы sparesWheelset.Hub
        [Key]
        public int hubId { get; set; }
        public string hubName { get; set; }
        public string hubDescription { get; set; }
        public int hubQuantity { get; set; }
    }
}
