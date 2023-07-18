using System.ComponentModel.DataAnnotations;

namespace TournamentTracker.UI.Models;


public class Tournament
{
    //[Key]
    //public int Id { get; set; }
    [Required]
    public string? TournamentName { get; set; }
    public string? Description { get; set; }
}
