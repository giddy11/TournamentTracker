using Microsoft.EntityFrameworkCore;
using TournamentTracker.Library.Models;

namespace TournamentTracker.Library.DataAccess;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
        
    }

    public DbSet<Matchup> Matchups { get; set; }
    public DbSet<MatchupEntry> MatchupEntries { get; set; }
    public DbSet<Person> Persons { get; set; }
    public DbSet<Prize> Prizes { get; set; }
    public DbSet<Team> Teams { get; set; }
    public DbSet<Tournament> Tournaments { get; set; }

}
