using System.ComponentModel.DataAnnotations;

namespace CW.Models
{
    public class CarsModel
    {
        [Key]
        public int CarId { get; set; }

        [Display(Name ="CarModel")]
        public string Model{ get; set; }

        [Display(Name = "CarPicture")]
        public string Picture { get; set; }

        [Display(Name = "CarCondition")]
        public string Condition { get; set; }

        [Display(Name = "CarAvailability")]
        public string Availability {  get; set; }

        [Display(Name = "CarPrice")]
        public int RentPrice { get; set; }
        public virtual ICollection<RentRequestModel> RentRequests { get; set; }
    }
}
