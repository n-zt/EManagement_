using EManagement_BusinessEngine.Contracts;
using EManagement_BusinessEngine.Implementation;
using EManagement_Common.Mappings;
using EManagement_Data.Contracts;
using EManagement_Data.Implementation;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using EManagement_Data.DataContext;
using Microsoft.EntityFrameworkCore;
using EManagement_Data.DbModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;
using EManagement_Common.ConstantsModels;

namespace EManagement_.UI
{
    public class Startup
    {
        public IConfiguration Configuration { get; }
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRazorPages();
            services.AddDbContext<EManagement_Context>(options => options.UseSqlServer(Configuration.GetConnectionString("IdentityConnection")));
            services.AddScoped<IEmployeeLeaveTypeBusinessEngine, EmployeeLeaveTypeBusinessEngine>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddAutoMapper(typeof(Maps));
            services.AddControllersWithViews().AddRazorRuntimeCompilation();
            //services.AddDefaultIdentity<IdentityUser>().AddEntityFrameworkStores<EManagement_Context>();
            services.AddIdentity<Employee, IdentityRole>().AddDefaultTokenProviders().AddEntityFrameworkStores<EManagement_Context>();
            services.AddSession();


            //services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env,UserManager<Employee>userManager,RoleManager<IdentityRole>roleManager)
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

            SeedData.Seed(userManager, roleManager);

            app.UseRouting();

			app.UseAuthentication();
			app.UseAuthorization();
           
            app.UseSession();

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
