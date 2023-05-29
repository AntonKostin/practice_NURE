using System.ComponentModel.DataAnnotations;

namespace practice_TrekCompany.Models.factory
{
    public class Factory
    {
        //Модель для таблицы factory.Factory
        [Key]
        public int factoryId { get; set; }
        public string city { get; set; }
        public string street { get; set; }
        public int zipCode { get; set; }
    }
}
