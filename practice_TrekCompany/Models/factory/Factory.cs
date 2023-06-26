using System.ComponentModel.DataAnnotations;

namespace practice_TrekCompany.Models.factory
{
    public class Factory
    {
        //Модель для таблицы factory.Factory
        [Key]
        public int FactoryId { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public int ZipCode { get; set; }
    }
}
