using System.ComponentModel.DataAnnotations;

namespace practice_TrekCompany.Models.sparesFrameset
{
    public class Frame
    {
        //Модель для таблицы sparesFrameset.Frame
        [Key]
        public int frameId { get; set; }
        public string frameName { get; set; }
        public string frameDescription { get; set; }
        public int frameQuantity { get; set; }
    }
}
