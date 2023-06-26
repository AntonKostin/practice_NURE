using System.ComponentModel.DataAnnotations;

namespace practice_TrekCompany.Models.factory
{
    public class JobTitle
    {
        //Модель для таблицы factory.JobTitle
        [Key]
        public int JobTitleId { get; set; }
        public string JobTitle { get; set; }
    }
}
