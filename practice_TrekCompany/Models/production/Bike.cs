using practice_TrekCompany.Models.spares.sparesEquipment;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace practice_TrekCompany.Models.production
{
    public class Bike
    {
        [Key]
        public int bikeId { get; set; }
        public string bikeName { get; set; }
        public string bikeImage { get; set; }
        public string bikeDescription { get; set; }
        public int bikePrice { get; set; }
        public float bikeWeight { get; set; }
        [ForeignKey("Frameset")]
        public int framesetId { get; set; }
        public Frameset Frameset { get; set; }
        [ForeignKey("Wheelset")]
        public int wheelsetId { get; set; }
        public Wheelset Wheelset { get; set; }
        [ForeignKey("Groopset")]
        public int groopsetId { get; set; }
        public Groopset Groopset { get; set; }
        [ForeignKey("Equipment")]
        public int equipmentId { get; set; }
        public Equipment Equipment { get; set; }
        [ForeignKey("TypeOfBike")]
        public int typeOfBikeId { get; set; }
        public TypeOfBike TypeOfBike { get; set; }
    }
}
