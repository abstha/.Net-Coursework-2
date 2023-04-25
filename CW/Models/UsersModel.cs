using System.ComponentModel.DataAnnotations;

namespace CW.Models
{
    public class UsersModel
    {
        [Key]
        public int UserId { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public string Address { get; set; }

        public virtual ICollection<RentRequestModel> RentRequests { get; set; }
    }
}
