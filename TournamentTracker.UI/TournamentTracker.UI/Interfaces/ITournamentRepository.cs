using TournamentTracker.UI.Models;

namespace TournamentTracker.UI.Interfaces
{
    public interface ITournamentRepository
    {
        Task<IEnumerable<Tournament>> GetAll();
        Task<Tournament?> GetByIdAsync(int id);
        //bool Add(Tournament tournament);
        Task Create(Tournament tournament);
        bool Update(Tournament tournament);
        bool Delete(int id);
        bool Delete1(Tournament tournament);

        bool Save();
    }
}
