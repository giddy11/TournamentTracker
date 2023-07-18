using Microsoft.AspNetCore.SignalR;
using TournamentTracker.UI.Models;

namespace TournamentTracker.UI.Hubs
{
    //public class TournamentHub : Hub
    //{
    //    public async Task SendNotification(Tournament newTournament)
    //    {
    //        await Clients.All.SendAsync("NewTournamentReceived", newTournament);
    //    }
    //}



    public class TournamentHub : Hub
    {
        public async Task SendNotification(Tournament newTournament)
        {
            await Clients.All.SendAsync("NewTournamentReceived", newTournament);
        }
    }


}
