using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace TournamentTracker.UI.Models;


public class Tournament
{
    [Key]
    public int Id { get; set; }

    [Required]
    [DisplayName("Tournament Name")]
    public string? TournamentName { get; set; }

    [DisplayName("Tournament Type")]
    public TournamentType TournamentType { get; set; }
    //public string ImageUrl { get; set; }
    //public List<Team>? Teams { get; set; }
    public string? Description { get; set; }
    //public Record? Record { get; set; }
}
