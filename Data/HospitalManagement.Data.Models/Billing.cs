namespace HospitalManagement.Data.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using HospitalManagement.Data.Common.Models;
    using Microsoft.EntityFrameworkCore.Metadata.Internal;

    public class Billing : BaseDeletableModel<int>
    {
        [Required]
        public int PatientId { get; set; }

        [Required]
        [Column(TypeName = "decimal(18,2)")]
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
