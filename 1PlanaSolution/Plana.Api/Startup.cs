
using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
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
            // https://github.com/aspnet/Announcements/issues/432
            services.AddDatabaseDeveloperPageExceptionFilter();

            services.AddDbContext<AppDbContext>(options =>
                options.UseLazyLoadingProxies()
                       .UseSqlServer(Configuration.GetConnectionString("DbConnection")));

            services.AddAutoMapper(typeof(AutoMapperProfile));

            services.AddScoped<IModuleRepository, ModuleRepository>();
            services.AddScoped<IModuleGroupRepository, ModuleGroupRepository>();
            services.AddScoped<IModuleRunService, ModuleRunService>();
            
            services.AddScoped<IStudyBranchRepository, StudyBranchRepository>();
            services.AddScoped<IAdditionalAssignmentRepository, AdditionalAssignmentRepository>();

            services.AddScoped<ILecturersModulesRepository, LecturersModulesRepository>();
            services.AddScoped<ILecturerSemesterRepository, LecturerSemesterRepository>();
            
            services.AddScoped<ILecturerGroupModuleGroupRepository, LecturerGroupModuleGroupRepository>();
            services.AddScoped<ILecturerGroupRepository, LecturerGroupRepository>();
            services.AddScoped<ILecturerLecturerGroupRepository, LecturerLecturerGroupRepository>();
            services.AddScoped<ILecturerModuleGroupRepository, LecturerModuleGroupRepository>();
            services.AddScoped<ILecturerModuleRunRepository, LecturerModuleRunRepository>();

            services.AddScoped<ILecturerService, LecturerService>();
            services.AddScoped<IPlanService, PlanService>();
            services.AddScoped<IModuleRunService, ModuleRunService>();
            services.AddScoped<IPlanLecturerService, PlanLecturerService>();
            services.AddScoped<ISemesterService, SemesterService>();

            services.AddControllers().AddNewtonsoftJson(options =>
                options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore);
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env,  AppDbContext context)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();

                // https://github.com/aspnet/Announcements/issues/432
                app.UseMigrationsEndPoint();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                app.UseHttpsRedirection();
            }

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