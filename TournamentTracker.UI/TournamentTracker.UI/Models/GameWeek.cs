using System.ComponentModel.DataAnnotations;

namespace TournamentTracker.UI.Models;

public class GameWeek
{
    [Key]
    public int Id { get; set; }
    public Team? TeamName { get; set; }
    public Team? TeamPoint { get; set; }
}
