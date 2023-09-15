using System;
using System.ComponentModel.DataAnnotations;

namespace TennisCourtBooking.Domain.Models
{
    public class TennisCourtModel
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(255)]
        public string Name { get; set; }

        [Required]
        public string Location { get; set; }

        [Required]
        public int Capacity { get; set; }

        [Required]
        public decimal HourlyRate { get; set; }

        // You can add more properties as needed for your application

        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
