using System;
using System.ComponentModel.DataAnnotations;

public class BookingModel
{
    public int Id { get; set; }

    [Required]
    public int UserId { get; set; }

    [Required]
    public int TennisCourtId { get; set; }

    [Required]
    [DataType(DataType.DateTime)]
    public DateTime BookingDateTime { get; set; }

    [Required]
    [Range(1, int.MaxValue, ErrorMessage = "Duration must be a positive number.")]
    public int DurationInMinutes { get; set; }

    // Add any additional properties relevant to booking details.
}
