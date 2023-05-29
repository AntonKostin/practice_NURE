using System.ComponentModel.DataAnnotations;

namespace practice_TrekCompany.Models.sparesFrameset
{
    public class Fork
    {
        //Модель для таблицы sparesFrameset.Fork
        [Key]
        public int forkId { get; set; }
        public string forkName { get; set; }
        public string forkDescription { get; set; }
        public int forkQuantity { get; set; }
    }
}
