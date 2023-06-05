using System.ComponentModel.DataAnnotations;

namespace practice_TrekCompany.Models.spares.sparesGroopset
{
    public class Pedals
    {
        //Модель для таблицы sparesGroopset.Pedals
        [Key]
        public int pedalsId { get; set; }
        public string pedalsName { get; set; }
        public int pedalsQuantity { get; set; }
    }
}
