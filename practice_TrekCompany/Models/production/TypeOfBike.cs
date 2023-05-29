using System.ComponentModel.DataAnnotations;

namespace practice_TrekCompany.Models.production
{
    public class TypeOfBike
    {
        [Key]
        public int typeOfBikeId { get; set; }
        public string typeName { get; set; }
    }
}
