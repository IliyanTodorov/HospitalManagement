namespace HospitalManagement.Data.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class Billing
    {
        public int BillingId { get; set; }

        [Required]
        public int PatientId { get; set; }

        [Required]
        public decimal Amount { get; set; }

        [StringLength(500)]
        public string Services { get; set; }

        [StringLength(50)]
        public string Insurance { get; set; }

        [Required]
        public DateTime Date { get; set; }

        [StringLength(50)]
        public string PaymentMethod { get; set; }

        [StringLength(50)]
        public string PaymentStatus { get; set; }

        public DateTime DueDate { get; set; }

        public DateTime Reminder { get; set; }

        public Patient Patient { get; set; }
    }
}
