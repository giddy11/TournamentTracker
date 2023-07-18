using Microsoft.EntityFrameworkCore;
using TournamentTracker.UI.Models;

namespace TournamentTracker.UI.DataAccess;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
        
    }

    public DbSet<Team> Teams { get; set; }
    public DbSet<Tournament> Tournaments { get; set; }
}
