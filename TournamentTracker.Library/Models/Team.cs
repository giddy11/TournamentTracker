using System.ComponentModel.DataAnnotations;

namespace TournamentTracker.Library.Models;

public class Team
{
    /// <summary>
    /// A unique Identifier for the Team
    /// </summary>
    [Key]
    public int Id { get; set; }

    /// <summary>
    /// The name of the Team.
    /// </summary>
    public string TeamName { get; set; }

    /// <summary>
    /// The set of team members in this tournament.
    /// </summary>
    public List<Person> TeamMembers { get; set; }
}
