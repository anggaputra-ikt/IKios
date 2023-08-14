using Application.Penyewa;
using Application.Penyewa.Dtos;
using AutoMapper;
using Domain.Entities;
using Infrastructure.Contexts;
using Infrastructure.Penyewa;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using Web.Pages.ViewModels;

namespace Web
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddDbContext<ApplicationDbContext>(context => context.UseSqlServer(builder.Configuration.GetConnectionString("LocalDb")));
            var mapperConfig = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<PenyewaViewModel, PenyewaDto>();
                cfg.CreateMap<PenyewaDto, Penyewa>();
            });
            var mapper = mapperConfig.CreateMapper();
            builder.Services.AddSingleton(mapper);
            builder.Services.AddScoped<IPenyewaService, PenyewaService>();
            builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));

            builder.Services.AddRazorPages();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

			app.MapControllerRoute(
				name: "default",
				pattern: "{controller}/{action=Index}/{id?}");

			app.MapRazorPages();

            app.Run();
        }
    }
}