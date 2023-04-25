using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CW.Models
{
    public class VerificationModel
    {
        [Key]
        public int VerificationId { get; set; }

        [Required]
        [MaxLength(50)]
        public string Type { get; set; } 

        [Required]
        [MaxLength(100)]
        public string FileName { get; set; } 

        [Required]
        [MaxLength(100)]
        public string ContentType { get; set; } 

        [Required]
        public byte[] Data { get; set; }

        [ForeignKey("UserId")]
        public virtual UsersModel User { get; set; }

        public int UserId { get; set; }
    }
}
