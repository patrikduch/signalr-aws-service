// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860
namespace SignalRAwsService.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.EntityFrameworkCore;
    using SignalRAwsService.Contexts;
    using SignalRAwsService.Models;
    using System.Linq;
    using System.Threading.Tasks;

    [Route("")]
    [ApiController]
    public class ProjectDetailController : ControllerBase
    {

        private readonly ProjectDetailContext _projectDetailContext;

        public ProjectDetailController(ProjectDetailContext projectDetailContext)
        {
            _projectDetailContext = projectDetailContext;
        }


        // GET: api/project
        [HttpGet]
        public async Task<ProjectDetail> GetProjectDetail()
        {
            return await _projectDetailContext.ProjectDetail.SingleOrDefaultAsync();
        }
    }
}
