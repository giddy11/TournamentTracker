using System.ComponentModel.DataAnnotations;

using TournamentTracker.UI.Models;

public class Team
{
    [Key]
    public int Id { get; set; }
    [Required]
    public Person? TeamName { get; set; }
    public int Point { get; set; }
}
