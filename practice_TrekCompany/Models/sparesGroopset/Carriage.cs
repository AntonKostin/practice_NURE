using System.ComponentModel.DataAnnotations;

namespace practice_TrekCompany.Models.sparesGroopset
{
    public class Carriage
    {
        //Модель для таблицы sparesGroopset.Carriage
        [Key]
        public int carriageId { get; set; }
        public string carriageName { get; set; }
        public int carriageQuantity { get; set; }
    }
}
