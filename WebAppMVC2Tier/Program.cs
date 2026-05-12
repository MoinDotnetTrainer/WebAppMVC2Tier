using DAlayer.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace WebAppMVC2Tier
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            builder.Services.AddDbContext<AppDb>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("constr")));

            builder.Services.AddScoped<DAlayer.IRepos.IUsers, DAlayer.Repos.UsersBl>();
            builder.Services.AddScoped<DAlayer.IRepos.IProducts, DAlayer.Repos.ProductsBl>();
            builder.Services.AddScoped<DAlayer.IRepos.Ibooks, DAlayer.Repos.BooksBl>();
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
                pattern: "{controller=usersops}/{action=Authenticate}/{id?}");

            app.Run();
        }
    }
}
