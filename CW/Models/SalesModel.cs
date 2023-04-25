using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CW.Models
{
    public class SalesModel
    {
        [Key]
        public int SalesId { get; set; }

        [ForeignKey("StaffId")]
        public int StaffId { get; set; }

        [ForeignKey("RequestId")]
        public int RequestId { get; set; }

        public int TotalCost { get; set; }

        public virtual RentRequestModel Request { get; set; }

        public virtual StaffModel Staff { get; set; }
    }
}
