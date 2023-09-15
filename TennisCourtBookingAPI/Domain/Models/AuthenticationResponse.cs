public class AuthenticationResponse
{
    public bool Success { get; set; }
    public string Token { get; set; }
    public IEnumerable<string> Errors { get; set; }
   

    public AuthenticationResponse()
    {
        Errors = new List<string>();
    }
}
