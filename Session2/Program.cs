using Microsoft.EntityFrameworkCore;
using Session2.Configration;
using Session2.Context;
using Session2.Repository;
using Session2.Service;

namespace Session2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();
            string dataConnection = builder.Configuration.GetConnectionString("localConnection");
            builder.Services.AddDbContext<PersonApplicationDbContext>(p => p.UseSqlServer(dataConnection));
            builder.Services.AddScoped<IPersonRepository,PersonRepository>();
            builder.Services.AddScoped<IPersonService,PersonService>();
            builder.Services.AddAutoMapper(typeof(MappingProfile));
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

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}