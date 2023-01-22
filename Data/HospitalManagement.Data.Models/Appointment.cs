namespace HospitalManagement.Data.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class Appointment
    {
        public int AppointmentId { get; set; }

        [Required]
        public int PatientId { get; set; }

        [Required]
        public int DoctorId { get; set; }

        [Required]
        public DateTime Date { get; set; }

        [Required]
        public DateTime Time { get; set; }

        [StringLength(50)]
        public string Room { get; set; }

        [StringLength(500)]
        public string Notes { get; set; }

        public bool Confirmed { get; set; }

        public DateTime ArrivalTime { get; set; }

        public DateTime DepartureTime { get; set; }

        public Patient Patient { get; set; }

        public Doctor Doctor { get; set; }
    }
}
