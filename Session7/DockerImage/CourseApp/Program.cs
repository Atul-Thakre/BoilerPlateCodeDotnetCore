using CourseApp.Context;
using CourseApp.Repository;
using CourseApp.Service;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace CourseApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();
            string connection = builder.Configuration.GetConnectionString("localConnectionString");
            builder.Services.AddDbContext<CourseDbContext>(p=>p.UseSqlServer(connection));

            builder.Services.AddIdentity<IdentityUser, IdentityRole>().AddEntityFrameworkStores<CourseDbContext>();
            //Per request only one object is created
            builder.Services.AddScoped<ICourseRepository, CourseRepository>();
            builder.Services.AddScoped<IBookingRepository, BookingRepository>();
            builder.Services.AddScoped<IUserRepository, UserRepository>();

            //Add service layer dependency
            builder.Services.AddScoped<ICourseService, CourseService>();
            builder.Services.AddScoped<IBookingService, BookingService>();
            builder.Services.AddScoped<IUserService, UserService>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

          /* app.MapControllerRoute(
                name: "default",
               pattern: "Home/Index",
             defaults: new { controller = "Home", action = "Index" });*/

            //Controller which is defined first is routed first
            //Pattern-Conventional Routing

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");


            //Responsible for maping action method with controllers
           /* app.MapControllers();*/
            app.Run();
        }
    }
}