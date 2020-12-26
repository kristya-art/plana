
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Plana.Api.Models;
using Plana.Api.Repositories;
using Plana.Api.Services;

namespace Plana.Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        public IConfiguration Configuration { get; set; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<AppDbContext>(options =>
                options.UseLazyLoadingProxies()
                       .UseSqlServer(Configuration.GetConnectionString("DbConnection")));

            services.AddScoped<IModuleRepository, ModuleRepository>();
            services.AddScoped<IModuleGroupRepository, ModuleGroupRepository>();
            services.AddScoped<IModuleRunRepository, ModuleRunRepository>();
            
            services.AddScoped<ISemesterRepository, SemesterRepository>();
            services.AddScoped<IStudyBranchRepository, StudyBranchRepository>();
            services.AddScoped<IAdditionalAssignmentRepository, AdditionalAssignmentRepository>();

            services.AddScoped<ILecturersModulesRepository, LecturersModulesRepository>();
            services.AddScoped<ILecturerSemesterRepository, LecturerSemesterRepository>();
            services.AddScoped<ILecturerRepository, LecturerRepository>();
            services.AddScoped<ILecturerGroupModuleGroupRepository, LecturerGroupModuleGroupRepository>();
            services.AddScoped<ILecturerGroupRepository, LecturerGroupRepository>();
            services.AddScoped<ILecturerLecturerGroupRepository, LecturerLecturerGroupRepository>();
            services.AddScoped<ILecturerModuleGroupRepository, LecturerModuleGroupRepository>();
            services.AddScoped<ILecturerModuleRunRepository, LecturerModuleRunRepository>();

            services.AddScoped<IPlanService, PlanService>();
            services.AddScoped<IModuleRunService, ModuleRunService>();
            services.AddScoped<IPlanLecturerService, PlanLecturerService>();

            services.AddControllers();
            services.AddControllers().AddNewtonsoftJson(options =>
                options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore);
        }

        public void Configure(IApplicationBuilder app, AppDbContext context)
        {
            app.UseDeveloperExceptionPage();
            app.UseHttpsRedirection();
            app.UseRouting();
            app.UseAuthorization();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            SeedData.SeedDatabase(context);
        }
    }
}