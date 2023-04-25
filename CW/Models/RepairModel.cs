using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CW.Models
{
    public class RepairModel
    {
        [Key]
        public int RepairId { get; set; }

        [ForeignKey("CarId")]
        public int CarId { get; set; }

        [ForeignKey("UserId")]
        public int UserId { get; set; }

        public DateTime DateDamaged { get; set; }

        public string DamageDesc { get; set; }

        public virtual CarsModel Car { get; set; }

        public virtual UsersModel User { get; set; }
    }
}
