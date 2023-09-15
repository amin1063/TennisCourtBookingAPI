public class RegistrationResponse
{
    public bool Success { get; set; }
    public IEnumerable<string> Errors { get; set; }
    public RegistrationResponse()
    {
        Errors = new List<string>();
    }
}
