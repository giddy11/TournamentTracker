namespace TournamentTracker.UI.Models;


public class User : Person
{
    public string Password { get; set; }
    public string ConfirmPassword { get; set; }
}
