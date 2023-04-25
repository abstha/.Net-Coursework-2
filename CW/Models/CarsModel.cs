using System.ComponentModel.DataAnnotations;

namespace CW.Models
{
    public class CarsModel
    {
        [Key]
        public int CarId { get; set; }
        public string Model{ get; set; }

        public string Picture { get; set; }

        public string Condition { get; set; }  

        public string Availability {  get; set; }

        public int RentPrice { get; set; }
        public virtual ICollection<RentRequestModel> RentRequests { get; set; }
    }
}
