namespace HospitalManagement.Data.Models
{
    using HospitalManagement.Data.Common.Models;
    using System;
    using System.ComponentModel.DataAnnotations;

    public class Patient : BaseDeletableModel<int>
    {
        [Required]
        public string Name { get; set; }

        public string Address { get; set; }

        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Invalid Phone number")]
        public string Phone { get; set; }

        [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", ErrorMessage = "Invalid Email")]
        public string Email { get; set; }

        public string Insurance { get; set; }

        public string MedicalHistory { get; set; }

        public string EmergencyContactName { get; set; }

        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Invalid Phone number")]
        public string EmergencyContactPhone { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string Gender { get; set; }

        public string BloodType { get; set; }

        public string Allergies { get; set; }

        public bool Active { get; set; }
    }
}
