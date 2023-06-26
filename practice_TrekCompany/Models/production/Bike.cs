using practice_TrekCompany.Models.spares.sparesEquipment;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace practice_TrekCompany.Models.production
{
    public class Bike
    {
        [Key]
        public int BikeId { get; set; }
        public string BikeName { get; set; }
        public string BikeImage { get; set; }
        public string BikeDescription { get; set; }
        public int BikePrice { get; set; }
        public float BikeWeight { get; set; }
        [ForeignKey("Frameset")]
        public int FramesetId { get; set; }
        public Frameset Frameset { get; set; }
        [ForeignKey("Wheelset")]
        public int WheelsetId { get; set; }
        public Wheelset Wheelset { get; set; }
        [ForeignKey("Groopset")]
        public int GroopsetId { get; set; }
        public Groopset Groopset { get; set; }
        [ForeignKey("Equipment")]
        public int EquipmentId { get; set; }
        public Equipment Equipment { get; set; }
        [ForeignKey("TypeOfBike")]
        public int TypeOfBikeId { get; set; }
        public TypeOfBike TypeOfBike { get; set; }
    }
}
