using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace NetCore_Dockerization.Hubs
{
    public class ViewHub : Hub
    {
        public static int ViewCount { get; set; } = 0;

        public async Task NotifyWatching()
        {
            ViewCount++;

            // notify EVERYONE about new view count
            await Clients.All.SendAsync("viewCountUpdate", ViewCount);
        }
    }
}
