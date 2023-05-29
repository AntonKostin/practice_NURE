using practice_TrekCompany.Models.spares.sparesGroopset;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using practice_TrekCompany.Models.spares.sparesWheelset;

namespace practice_TrekCompany.Models.production
{
    public class Wheelset
    {
        [Key]
        public int wheelsetId { get; set; }
        [ForeignKey("Hub")]
        public int hubId { get; set; }
        public Hub Hub { get; set; }
        [ForeignKey("Rim")]
        public int rimId { get; set; }
        public Rim Rim { get; set; }
        [ForeignKey("Tire")]
        public int tireId { get; set; }
        public Tire Tire { get; set; }
    }
}
