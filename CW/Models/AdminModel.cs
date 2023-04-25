using System.ComponentModel.DataAnnotations;

namespace CW.Models
{
    public class AdminModel
    {
        [Key]
        public int AdminId { get; set; }

        public string Name { get; set; }   

        public string Password { get; set; }    

        public string Phone { get; set; }   
    }
}
