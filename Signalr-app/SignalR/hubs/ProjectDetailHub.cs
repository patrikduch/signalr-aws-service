using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using SignalRAwsService.Contexts;
using System.Threading.Tasks;

namespace SignalRAwsService.SignalR.hubs
{
    /// <summary>
    /// SignalR hub for real-time fetching of project detail details.
    /// </summary>
    public class ProjectDetailHub : Hub
    {
        private readonly ProjectDetailContext _projectDetailContext;

        public ProjectDetailHub(ProjectDetailContext projectDetailContext)
        {
            _projectDetailContext = projectDetailContext;
        }


        public async Task NotifyWatching()
        {
            // notify EVERYONE about new view count
            await Clients.All.SendAsync("viewProjectDetailUpdate", await _projectDetailContext.ProjectDetail.SingleOrDefaultAsync());
        }

    }
}
