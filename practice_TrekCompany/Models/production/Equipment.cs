using practice_TrekCompany.Models.spares.sparesGroopset;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using practice_TrekCompany.Models.spares.sparesEquipment;

namespace practice_TrekCompany.Models.production
{
    public class Equipment
    {
        [Key]
        public int equipmentId { get; set; }
        [ForeignKey("Brake")]
        public int brakeId { get; set; }
        public Brake Brake { get; set; }
        [ForeignKey("Saddle")]
        public int saddleId { get; set; }
        public Saddle Saddle { get; set; }
        [ForeignKey("SeatPost")]
        public int seatPostId { get; set; }
        public SeatPost SeatPost { get; set; }
        [ForeignKey("Stem")]
        public int stemId { get; set; }
        public Stem Stem { get; set; }
        [ForeignKey("Handlebar")]
        public int handlebarId { get; set; }
        public Handlebar Handlebar { get; set; }
        [ForeignKey("Grips")]
        public int gripsId { get; set; }
        public Grips Grips { get; set; }
        [ForeignKey("Steering")]
        public int steeringId { get; set; }
        public Steering Steering { get; set; }
    }
}
