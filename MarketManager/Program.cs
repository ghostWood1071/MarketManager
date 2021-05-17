using System;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;
using MarketManager.Views;
using MarketManager.Models;
using SQLHelper.Interface;
using MarketManager.Interface;
using MarketManager.DataAcess;
using MarketManager.Bussiness;
using System.Collections.Generic;
namespace MarketManager
{
    static class ServiceConfig
    {
        internal static ServiceCollection services = new ServiceCollection();
        
    }
    static class Program
    {
        internal static string conn ="data source=ADMIN;initial catalog=MiniMarket;persist security info=True;user id=sa;password=111";

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
           
          
            ServiceCollection services = new ServiceCollection();
            ConfigureService(services);

            ServiceProvider provider = services.BuildServiceProvider();
            var formLogin = provider.GetService<FrmOrderManger>();

            Application.Run(formLogin);

        }

        static void ConfigureService(ServiceCollection services)
        {
            //form and entities service
            services.AddScoped<FrmLogin>();
            services.AddScoped<FrmMangeProduct>();
            services.AddScoped<FrmOrderManger>();
            services.AddScoped<FrmOrderDetailManager>();
            services.AddSingleton<Dictionary<string, object>>();

            //data acess service
            services.AddSingleton<MarketEntities>();
            services.AddSingleton<ICRUD<Staff>, StaffDataAcess>();
            services.AddSingleton<ICRUD<Category>, CategoryDataAcess>();
            services.AddSingleton<ICRUD<Brand>, BrandDataAcess>();
            services.AddSingleton<IProductAcessible, ProductDataAcess>();
            services.AddSingleton<ICRUD<Customer>, CustomerDataAcess>();
            services.AddSingleton<IDetailAcessible, OrderDetailDataAcess>();
            services.AddSingleton<IOrderAcessible, OrderDataAcess>();
            services.AddSingleton<ICRUD<Price>, PriceDataAcess>();
            
            // bussiness service
            services.AddScoped<ILoginable, LoginBussiness>();
            services.AddScoped<IProductManagable, ProductManagerBussiness>();
            services.AddScoped<ISellable, SellBussiness>();

        }
    }
}
