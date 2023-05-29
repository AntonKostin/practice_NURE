using practice_TrekCompany.Models.spares.sparesGroopset;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using practice_TrekCompany.Models.spares.sparesFrameset;

namespace practice_TrekCompany.Models.production
{
    public class Frameset
    {
        [Key]
        public int framesetId { get; set; }
        [ForeignKey("Frame")]
        public int frameId { get; set; }
        public Frame Frame { get; set; }
        [ForeignKey("Fork")]
        public int forkId { get; set; }
        public Fork Fork { get; set; }
    }
}
