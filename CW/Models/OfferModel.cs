using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CW.Models
{
    public class OfferModel
    {
        [Key]
        public int OfferId { get; set; }

        [ForeignKey("StaffId")]
        public int StaffId { get; set; }

        public string OfferName { get; set; }

        public string OfferDesc { get; set; }

        public int Discount { get; set; }   

        public DateTime StartDate { get; set; } 

        public DateTime EndDate { get; set; }

        public virtual StaffModel Staff { get; set; }
    }
}
