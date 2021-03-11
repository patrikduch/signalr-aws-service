// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860
namespace NetCore_Dockerization.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using NetCore_Dockerization.Models;

    [Route("")]
    [ApiController]
    public class ProjectDetailController : ControllerBase
    {
        // GET: api/project
        [HttpGet]
        public ProjectDetail GetProjectDetail()
        {
            return new ProjectDetail
            {
                Id = 1,
                Name = "SignalR with RabbitMQ broker in .NETCore on AWS cloud platform",
                Author = "Patrik Duch"
            };
        }
    }
}
