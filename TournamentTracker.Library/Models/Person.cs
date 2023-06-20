using System.ComponentModel.DataAnnotations;

namespace TournamentTracker.Library.Models;

public class Person
{
    /// <summary>
    /// A unique Identifier for the Person
    /// </summary>
    [Key]
    public int Id { get; set; }

    /// <summary>
    /// The first name of the person.
    /// </summary>
    public string FirstName { get; set; }

    /// <summary>
    /// The last name of the person.
    /// </summary>
    public string LastName { get; set; }

    /// <summary>
    /// The primary email address of the person.
    /// </summary>
    public string EmailAddress { get; set; }

    /// <summary>
    /// The primary cell phone number of the person.
    /// </summary>
    public string CellPhoneNumber { get; set; }

}