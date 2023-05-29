using practice_TrekCompany.Models.spares.sparesGroopset;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace practice_TrekCompany.Models.production
{
    public class Groopset
    {
        [Key]
        public int groopsetId { get; set; }
        [ForeignKey("Transmition")]
        public int transmitionId { get; set; }
        public Transmition Transmition { get; set; }
        [ForeignKey("Carriage")]
        public int carriageId { get; set; }
        public Carriage Carriage { get; set; }
        [ForeignKey("Pedals")]
        public int pedalsId { get; set; }
        public Pedals Pedals { get; set; }
    }
}
