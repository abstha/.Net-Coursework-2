using System.ComponentModel.DataAnnotations;

namespace CW.Models
{
    public class StaffModel
    {
        [Key]
        public int StaffId { get; set; }

        public string Name { get; set; }

        public string Password { get; set; }    

        public string Phone { get; set; }

    }
}
