using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using SignalRAwsService.Contexts;
using SignalRAwsService.Hubs;
using SignalRAwsService.SignalR.hubs;

namespace SignalRAwsService
{
    /// <summary>
    /// 
    /// </summary>
    public class Startup
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="configuration"></param>
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy", builder =>
                    builder
                    .WithOrigins(
                        "http://localhost", 
                        "http://aspnetcorereactreduxtemplate-env.eba-mcv635ym.eu-west-1.elasticbeanstalk.com"
                    )
                    .AllowAnyMethod()
                    .AllowAnyHeader()
                    .AllowCredentials()
                    );
            });
            services.AddControllers();
            services.AddSignalR();

            #region EFCore
            services.AddDbContext<ProjectDetailContext>(options =>  options.UseNpgsql
                (Configuration.GetConnectionString("DefaultConnection"))
            );
            #endregion
        }

        /// <summary>
        /// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        /// </summary>
        /// <param name="app"></param>
        /// <param name="env"></param>
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            //app.UseHttpsRedirection();

            app.UseRouting();
            app.UseAuthorization();
            app.UseCors("CorsPolicy");
           

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
                endpoints.MapHub<ViewHub>("/hubs/view");
                endpoints.MapHub<ProjectDetailHub>("/hubs/project");
            });
        }
    }
}
