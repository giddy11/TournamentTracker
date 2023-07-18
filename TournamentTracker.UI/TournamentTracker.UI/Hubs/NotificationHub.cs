using Microsoft.AspNetCore.SignalR;

namespace TournamentTracker.UI.Hubs
{
    public class NotificationHUb : Hub
    {
        public async Task SendNotification(string message)
        {
            await Clients.All.SendAsync("ReceiveNotification", message);
        }
    }
}
