using System.ComponentModel.DataAnnotations;

namespace practice_TrekCompany.Models.spares.sparesWheelset
{
    public class Tire
    {
        //Модель для таблицы sparesWheelset.Tire
        [Key]
        public int tireId { get; set; }
        public string tireName { get; set; }
        public string tireDescription { get; set; }
        public int tireQuantity { get; set; }
    }
}
