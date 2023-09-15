namespace TennisCourtBooking.Domain.Models
{
    public class TennisCourtResponse
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public TennisCourt TennisCourt { get; set; } // You can customize this property based on your needs
    }
}
