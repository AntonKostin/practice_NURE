using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using practice_TrekCompany.Models.sparesTransmition;

namespace practice_TrekCompany.Models.sparesGroopset
{
    public class Transmition
    {
        //Модель для таблицы sparesGroopset.Transmition
        [Key]
        public int transmitionId { get; set; }
        //Подключение модели
        [ForeignKey("Cassette")]
        public int cassetteId { get; set; }
        public Cassette Cassette { get; set; }
        //Подключение модели
        [ForeignKey("Switch")]
        public int switchId { get; set; }
        public Switch Switch { get; set; }
        //Подключение модели
        [ForeignKey("Shifter")]
        public int shifterId { get; set; }
        public Shifter Shifter { get; set; }
        public int transmitionQuantity { get; set; }
    }
}
