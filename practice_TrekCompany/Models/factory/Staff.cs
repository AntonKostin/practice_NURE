using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace practice_TrekCompany.Models.factory
{
    public class Staff
    {
        //Модель для таблицы factory.Staff
        [Key]
        public int staffId { get; set; }
        public string firstName { get; set; }
        public string secondName { get; set; }
        //Подключение модели
        [ForeignKey("Factory")]
        public int factoryId { get; set; }
        public Factory Factory { get; set; }
        //Подключение модели
        [ForeignKey("JobTitle")]
        public int jobTitleId { get; set; }
        public JobTitle JobTitle { get; set; }
    }
}
