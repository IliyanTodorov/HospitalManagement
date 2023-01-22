namespace HospitalManagement.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Room
    {
        public int RoomId { get; set; }

        [Required]
        [StringLength(50)]
        public string RoomNumber { get; set; }

        [Required]
        [StringLength(50)]
        public string Type { get; set; }

        public bool Available { get; set; }

        [Required]
        public int RoomCapacity { get; set; }

        [Required]
        public int Floor { get; set; }

        [Required]
        [StringLength(50)]
        public string Building { get; set; }

        [StringLength(500)]
        public string RoomDescription { get; set; }
    }
}
