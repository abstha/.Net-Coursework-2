using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CW.Models
{
    public class RentRequestModel
    {
        [Key]
        public string RequestId { get; set; }

        [ForeignKey("UserId")]
        public string UserId { get; set; }

        [ForeignKey("CarId")]
        public string CarId { get; set; }

        public DateOnly StartDate { get; set; }

        public DateOnly EndDate { get; set; }

        public virtual UsersModel User { get; set; }

        public virtual CarsModel Car { get; set; }
    }
}
