using System.ComponentModel.DataAnnotations;

namespace TournamentTracker.UI.Models;

public class Person
{
    [Key]
    public int Id { get; set; }
    [Required]
    public string? FirstName { get; set; }
    [Required]
    public string? LastName { get; set; }
    [Required]
    public string? EmailAddress { get; set; }
    [Required]
    public string? CellPhoneNumber { get; set; }
}