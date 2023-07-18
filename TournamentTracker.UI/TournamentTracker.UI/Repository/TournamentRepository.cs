using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using TournamentTracker.UI.DataAccess;
using TournamentTracker.UI.Interfaces;
using TournamentTracker.UI.Models;

namespace TournamentTracker.UI.Repository
{
    public class TournamentRepository : ITournamentRepository
    {
        public TournamentRepository(ApplicationDbContext context, IHubContext<TournamentHub> hubContext)
        {
            _context = context;
            _hubContext = hubContext;
        }
        //public bool Add(Tournament tournament)
        //{
        //   _context.Add(tournament);
        //    return Save();
        //}

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Tournament>> GetAll()
        {
            return await _context.Tournaments.ToListAsync();
        }

        public async Task<Tournament?> GetByIdAsync(int id)
        {
            return await _context.Tournaments.FindAsync(id);
        }

        public bool Save()
        {
            return _context.SaveChanges() > 0;
        }

        public bool Update(Tournament tournament)
        {
            _context.Update(tournament);
            return Save();
        }

        public bool Delete1(Tournament tournament)
        {
            _context.Remove(tournament);
            return Save();
        }

        public async Task Create(Tournament tournament)
        {
            _context.Tournaments.Add(tournament);

            await _context.SaveChangesAsync();
        }

        private readonly ApplicationDbContext _context;
        private readonly IHubContext<TournamentHub> _hubContext;

    }
}
