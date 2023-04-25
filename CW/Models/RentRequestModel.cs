using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CW.Models
{
    public class RentRequestModel
    {
        [Key]
        public int RequestId { get; set; }

        [ForeignKey("UserId")]
        public int UserId { get; set; }

        [ForeignKey("CarId")]
        public int CarId { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public virtual UsersModel User { get; set; }

        public virtual CarsModel Car { get; set; }
    }
}
