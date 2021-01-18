using System;
using System.Net.Http;
using AutoMapper;
using EmbeddedBlazorContent;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Plana.Web.Services;


namespace Plana.Web
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddAuthentication("Identity.Application")
                .AddCookie();
            //services.AddHttpClient();
            services.AddRazorPages();
            services.AddServerSideBlazor();
            //services.AddAutoMapper(typeof(LecturerProfile));
            services.AddScoped<HttpClient>();
           

            services.AddHttpClient<ILecturerService,LecturerService>(client =>
                {
                    client.BaseAddress = new Uri("https://localhost:44399/");
                });
            services.AddHttpClient<ILecturersModulesService, LecturersModulesService>(client =>
            {
                client.BaseAddress = new Uri("https://localhost:44399/");
            });
            services.AddHttpClient<ISemesterService, SemesterService>(client =>
            {
                client.BaseAddress = new Uri("https://localhost:44399");
            });
            services.AddHttpClient<IModuleRunService, ModuleRunService>(client =>
            {
                client.BaseAddress = new Uri("https://localhost:44399");
            });
            services.AddHttpClient<IPlanService, PlanService>(client =>
            {
                client.BaseAddress = new Uri("https://localhost:44399");
            }
            );
            services.AddHttpClient<IModuleService, ModuleService>(client =>
            {
                client.BaseAddress = new Uri("https://localhost:44399");
            });
            services.AddHttpClient<IPlanLecturerService, PlanLecturerService>(client =>
            {
                client.BaseAddress = new Uri("https://localhost:44399");
            });
            services.AddHttpClient<ILecturerModuleRunService, LecturerModuleRunService>(client =>
            {
                client.BaseAddress = new Uri("https://localhost:44399");
            });
            services.AddHttpClient<IAdditionalAssignmentService, AdditionalAssignmentService>(client =>
            {
                client.BaseAddress = new Uri("https://localhost:44399");
            });
            services.AddHttpClient<IModuleRunLecturerGroupService, ModuleRunLecturerGroupService>(client =>
            {
                client.BaseAddress = new Uri("https://localhost:44399");
            });
            services.AddHttpClient<ILecturerLecturerGroupService, LecturerLecturerGroupService>(client =>
            {
                client.BaseAddress = new Uri("https://localhost:44399");
            });
            services.AddHttpClient<ILecturerGroupService, LecturerGroupService>(client =>
            {
                client.BaseAddress = new Uri("https://localhost:44399");
            });



        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEmbeddedBlazorContent(typeof(MatBlazor.BaseMatComponent).Assembly);

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapBlazorHub();
                endpoints.MapFallbackToPage("/_Host");
            });
        }
    }
}
