using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using vrmninkosesi.Data;
using Microsoft.EntityFrameworkCore;

namespace vrmninkosesi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(
        builder.Configuration.GetConnectionString("DefaultConnection")));

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                // app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }


            app.UseHttpsRedirection();
            app.UseStaticFiles(); 
            app.UseRouting();


            app.UseAuthorization();

            app.MapControllerRoute(
                        name: "default",
                        pattern: "{controller=Posts}/{action=Index}/{id?}");


            app.Run();
        }
    }
}
