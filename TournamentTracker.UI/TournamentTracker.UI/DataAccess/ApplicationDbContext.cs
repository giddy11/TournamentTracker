using Microsoft.EntityFrameworkCore;
using TournamentTracker.UI.Models;

namespace TournamentTracker.UI.DataAccess;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
        
    }

    public DbSet<GameWeek> GameWeeks { get; set; }
    public DbSet<Record> Records { get; set; }
    public DbSet<Person> Persons { get; set; }
    public DbSet<Team> Teams { get; set; }
    public DbSet<Tournament> Tournaments { get; set; }
    public DbSet<User> Users { get; set; }
}
