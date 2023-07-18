using System.ComponentModel.DataAnnotations;

using TournamentTracker.UI.Models;

public class Team
{
    [Key]
    public int Id { get; set; }
    [Required]
    public string? TeamName { get; set; }
    public string CellNumber { get; set; }
    public int Point { get; set; }
}
