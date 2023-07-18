using Admin.Services.Tournaments.CreateTournaments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Admin.Services.Tournaments
{
    public interface ITournamentService
    {
        Task<Guid> CreateTournamentAsync(CreateTournamentCommand command);
    }
}
