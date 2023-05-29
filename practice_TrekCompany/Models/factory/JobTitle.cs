using System.ComponentModel.DataAnnotations;

namespace practice_TrekCompany.Models.factory
{
    public class JobTitle
    {
        [Key]
        public int jobTitleId { get; set; }
        public string jobTitle { get; set; }
    }
}
