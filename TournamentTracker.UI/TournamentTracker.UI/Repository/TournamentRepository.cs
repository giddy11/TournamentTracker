using Microsoft.EntityFrameworkCore;
using TournamentTracker.UI.DataAccess;
using TournamentTracker.UI.Interfaces;
using TournamentTracker.UI.Models;

namespace TournamentTracker.UI.Repository
{
    public class TournamentRepository : ITournamentRepository
    {
        public TournamentRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public bool Add(Tournament tournament)
        {
           _context.Add(tournament);
            return Save();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Tournament>> GetAll()
        {
            return await _context.Tournaments.ToListAsync();
        }

        public async Task<Tournament> GetByIdAsync(int id)
        {
            return await _context.Tournaments.FirstOrDefaultAsync(i => i.Id == id);
        }

        public bool Save()
        {
            var saved = _context.SaveChanges();
            return saved > 0 ? true : false;
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

        private readonly ApplicationDbContext _context;
    }
}
