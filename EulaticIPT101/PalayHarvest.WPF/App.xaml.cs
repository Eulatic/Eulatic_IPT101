using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PalayHarvest.Framework.Data;
using PalayHarvest.Framework.Repositories;
using PalayHarvest.Framework.Services;
using PalayHarvest.WPF.ViewModels;
using PalayHarvest.WPF.Views;
using System;
using System.IO;
using System.Windows;

namespace PalayHarvest.WPF
{
    public partial class App : Application
    {
        public static ServiceProvider Services { get; private set; }

        public App()
        {
            var services = new ServiceCollection();

            services.AddDbContext<AppDbContext>(options =>
                options.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=PalayHarvestDB;Trusted_Connection=True;"));

            services.AddScoped<IFarmerRepository, FarmerRepository>();
            services.AddScoped<IFarmerService, FarmerService>();

            services.AddScoped<FarmerViewModel>();
            services.AddScoped<FarmerView>();  // ✅ THIS WAS MISSING

            Services = services.BuildServiceProvider();
        }


        protected override void OnStartup(StartupEventArgs e)
        {
            var farmerWindow = Services.GetRequiredService<FarmerView>();
            farmerWindow.Show();
            base.OnStartup(e);
        }


    }

}
