using System.ComponentModel.DataAnnotations;

namespace practice_TrekCompany.Models.sparesWheelset
{
    public class Rim
    {
        //Модель для таблицы sparesWheelset.Rim
        [Key]
        public int rimId { get; set; }
        public string rimName { get; set; }
        public string rimDescription { get; set;}
        public int rimQuantity { get; set; }
    }
}
