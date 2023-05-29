using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace practice_TrekCompany.Models.factory
{
    public class Staff
    {
        [Key]
        public int staffId { get; set; }
        [ForeignKey("Factory")]
        public int factoryId { get; set; }
        public Factory Factory { get; set; }
        [ForeignKey("JobTitle")]
        public int jobTitleId { get; set; }
        public JobTitle JobTitle { get; set; }
    }
}
