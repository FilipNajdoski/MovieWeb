using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MovieWeb.Data;
using MovieWeb.Repository;
using MovieWeb.Repository.IRepository;
using MovieWeb.Services;
using MovieWeb.Services.IServices;
using System;

namespace MovieWeb
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddDbContext<MovieContext>(options => options.UseSqlServer(Configuration.GetConnectionString("MovieConnection")));
            services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                .AddRoles<IdentityRole>()
                .AddEntityFrameworkStores<MovieContext>();
            services.AddControllersWithViews();
            services.AddRazorPages();
            services
             .AddMvc()
             .SetCompatibilityVersion(CompatibilityVersion.Version_3_0)
             .AddRazorPagesOptions(options =>
             {
                 //options.AllowAreas = true;
                 options.Conventions.AuthorizeAreaFolder("Identity", "/Account/Manage");
                 options.Conventions.AuthorizeAreaPage("Identity", "/Account/Logout");
             });

            services.AddTransient<IMoviesRepository, MoviesRepository>();
            services.AddTransient<IMoviesApiRepository, MoviesApiRepository>();
            services.AddTransient<IGenresRepository, GenresRepository>();
            services.AddTransient<IPeopleRepository, PeopleRepository>();

            services.AddTransient<IMoviesService, MoviesService>();
            services.AddTransient<IMoviesApiService, MoviesApiService>();
            services.AddTransient<IGenresService, GenresService>();
            services.AddTransient<IPeopleService, PeopleService>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
                endpoints.MapRazorPages();
            });
        }
    }
}
