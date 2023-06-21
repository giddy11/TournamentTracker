using System.ComponentModel.DataAnnotations;

namespace TournamentTracker.UI.Models;

public class Record
{
    [Key]
    public int Id { get; set; }
    public Team? TeamName { get; set; }
    public int GameweekPoint { get; set; }
    public int MonthlyPoint { get; set; }
}
