using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SignalRAwsService.Contexts;
using SignalRAwsService.Models;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860
namespace SignalRAwsService.Controllers
{
    /// <summary>
    /// REST API controller for managing detail about project.
    /// </summary>
    [ApiController]
    [Route("")]
    public class ProjectDetailController : ControllerBase
    {

        private readonly ProjectDetailContext _projectDetailContext;

        /// <summary>
        /// Default constructor of a ProjectDetailController.
        /// </summary>
        /// <param name="projectDetailContext"></param>
        public ProjectDetailController(ProjectDetailContext projectDetailContext)
        {
            _projectDetailContext = projectDetailContext;
        }

        // GET: api/project
        [HttpGet]
        public async Task<ActionResult<ProjectDetail>> GetProjectDetail()
        {
            return Ok(await _projectDetailContext.ProjectDetail.SingleOrDefaultAsync());
        }
    }
}
