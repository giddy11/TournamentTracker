using System.ComponentModel.DataAnnotations;

namespace TournamentTracker.Library.Models;

public class Matchup
{
    /// <summary>
    /// A unique Identifier for the Matchup
    /// </summary>
    [Key]
    public int Id { get; set; }

    /// <summary>
    /// Which round this match is a part of.
    /// </summary>
    public int MatchupRound { get; set; }

    /// <summary>
    /// The winner of the match
    /// </summary>
    public Team Winner { get; set; }

    /// <summary>
    /// The set of teams that were involved in this match
    /// </summary>
    public List<MatchupEntry> Entries { get; set; }

}