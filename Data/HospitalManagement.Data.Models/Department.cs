namespace HospitalManagement.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Department
    {
        public int DepartmentId { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(50)]
        public string Head { get; set; }

        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$")]
        public string Phone { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        [StringLength(50)]
        public string Location { get; set; }

        [StringLength(500)]
        public string Description { get; set; }

        public bool Active { get; set; }

        public ICollection<Doctor> Doctors { get; set; }
    }
}
