using Admin.Services.Tournaments;
using Admin.Services.Tournaments.CreateTournaments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TournamentTracker.UI.DataAccess;

namespace TournamentTracker.Infrastructure.Admin.Tournaments
{
    internal class TournamentService : ITournamentService
    {
        public TournamentService(ApplicationDbContext context)
        {
            _context = context;
        }
        public Task<Guid> CreateTournamentAsync(CreateTournamentCommand command)
        {
            throw new NotImplementedException();
        }

        private readonly ApplicationDbContext _context;

    }
}
