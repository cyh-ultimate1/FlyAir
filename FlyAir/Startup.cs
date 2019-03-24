using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FlyAir.Data;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Identity.Dapper.SqlServer.Connections;
using Identity.Dapper;
using Identity.Dapper.Models;
using FlyAir.Models.IdentityEntities;
using Identity.Dapper.SqlServer.Models;
using FlyAir.Services;
using FlyAir.Data.IRepositories;
using FlyAir.Data.Repositories;
using FlyAir.Hubs;
using FlyAir.Models;
using System.Data.SqlClient;
using Microsoft.AspNetCore.SignalR;

namespace FlyAir
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
            //============== added for Dapper Identity=============
            services.ConfigureDapperConnectionProvider<SqlServerConnectionProvider>(Configuration.GetSection("DapperIdentity"))
                    .ConfigureDapperIdentityCryptography(Configuration.GetSection("DapperIdentityCryptography"))
                    .ConfigureDapperIdentityOptions(new DapperIdentityOptions { UseTransactionalBehavior = false }); //Change to True to use Transactions in all operations

            services.AddIdentity<CustomUser, CustomRole>(x =>
            {
                x.Password.RequireDigit = false;
                x.Password.RequiredLength = 1;
                x.Password.RequireLowercase = false;
                x.Password.RequireNonAlphanumeric = false;
                x.Password.RequireUppercase = false;
            })
                    .AddDapperIdentityFor<SqlServerConfiguration>()
                    .AddDefaultTokenProviders();

            //services.AddIdentity<DapperIdentityUser, DapperIdentityRole<int>>()
            //    .AddDapperIdentityFor<SqlServerConfiguration>()
            //    .AddDefaultTokenProviders();

            //============== end: added for Dapper Identity=============

            //========================== init SqlDependency===========
            //SqlDependency.Start(Configuration.GetConnectionString(commonName.defaultConn));

            //change redirect login path here
            services.ConfigureApplicationCookie(options =>
            {
                options.LoginPath = "/Account/LoginRegister";
                options.AccessDeniedPath = "/Account/RedirectAccessDenied";
                //options.ExpireTimeSpan = TimeSpan.FromMinutes(30);
            });

            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => false;  //set true to comply GDPR. may need to set false for TempData to work.
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("DefaultConnection")));
            //services.AddDefaultIdentity<IdentityUser>()
            //    .AddEntityFrameworkStores<ApplicationDbContext>();

            services.AddMvc()
                .SetCompatibilityVersion(CompatibilityVersion.Version_2_1)
                .AddSessionStateTempDataProvider()
                //.AddJsonOptions(options =>
                //{
                //    options.SerializerSettings.DateFormatString = "dd/MM/yyyy HH:mm:ss";
                //})
                ;
            services.AddSession(options =>
            {
                // Set a short timeout for easy testing.
                options.IdleTimeout = TimeSpan.FromMinutes(10);
                options.Cookie.HttpOnly = true;
            });

            //me: add signalR
            services.AddSignalR();

            //me: add scoped services
            //services.AddScoped<IEmployeeRepo, EmployeeRepo>();
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddTransient<IEmailSender, AuthMessageSender>();
            services.AddTransient<ISmsSender, AuthMessageSender>();
            services.AddTransient<IdummyRepo, dummyRepo>();
            services.AddTransient<ICountryRepo, CountryRepo>();
            services.AddTransient<IFlightRepo, FlightRepo>();
            services.AddTransient<IBookingRepo, BookingRepo>();
            services.AddTransient<IGlobalRepo, GlobalRepo>();
            services.AddTransient<IAdminRepo, AdminRepo>();
            services.AddTransient<IStaffRepo, StaffRepo>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseStatusCodePages("text/plain", "Status code pagelalla, status code: {0}");
                app.UseDatabaseErrorPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();

            app.UseAuthentication();
            //me: added use session
            app.UseSession();

            //me: add signalR
            app.UseSignalR(routes =>
            {
                routes.MapHub<ChatHub>("/chatHub");
                routes.MapHub<dummyHub>("/dummyHub");
                routes.MapHub<BookingHub>("/bookingHub");
            });

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");

                routes.MapRoute(
                    name: "Admin",
                    template: "FlyAirAdmin/{controller=Home}/{action=Index}/{id?}");
            });

            //app.UseSqlTableDependency(Configuration.GetConnectionString("DefaultConnection"));
        }
    }
}
