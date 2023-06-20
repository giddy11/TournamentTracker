﻿namespace TournamentTracker.Library.Models;

public class Person
{
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