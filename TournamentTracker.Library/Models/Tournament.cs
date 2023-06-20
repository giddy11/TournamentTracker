using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace TournamentTracker.Library.Models;

public class Tournament
{
    /// <summary>
    /// A unique Identifier for the Tournament
    /// </summary>
    [Key]
    public int Id { get; set; }

    public string TournamentName { get; set; }

    public decimal EntryFee { get; set; }

    public List<Team> EnteredTeams { get; set; }


    public List<Prize> Prizes { get; set; }

    public List<List<Matchup>> Rounds { get; set; }

}
