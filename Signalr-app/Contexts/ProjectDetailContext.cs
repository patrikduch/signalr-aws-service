using Microsoft.EntityFrameworkCore;
using SignalRAwsService.Models;
using SignalRAwsService.Models.ModelsConfiguration;

namespace SignalRAwsService.Contexts
{
    public class ProjectDetailContext : DbContext
    {
        public ProjectDetailContext(DbContextOptions<ProjectDetailContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder){

            // Addd the Postgres Extension for UUID generation
            builder.HasPostgresExtension("uuid-ossp");

            builder.ApplyConfiguration(new ProjectDetailConfiguration());    
        }


        public DbSet<ProjectDetail> ProjectDetail { get; set;}
        
    }
}
