using System.ComponentModel.DataAnnotations;

namespace practice_TrekCompany.Models.production
{
    public class TypeOfBike
    {
        [Key]
        public int TypeOfBikeId { get; set; }
        public string TypeName { get; set; }
    }
}
