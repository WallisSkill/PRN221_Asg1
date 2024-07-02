using DataAccess;
using DataAccess.DAO;
using DataAccess.Models;
using DataAccess.Repository;
using DataAccess.Repository.Interface;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using System.Configuration;
using System.Data;
using System.Windows;

namespace SalesWPFApp
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public IServiceProvider ServiceProvider { get; private set; }

        protected override void OnStartup(StartupEventArgs e)
        {
            var serviceCollection = new ServiceCollection();
            ConfigureServices(serviceCollection);
            ServiceProvider = serviceCollection.BuildServiceProvider();

            var mainWindow = ServiceProvider.GetRequiredService<MainWindow>();
            mainWindow.Show();
        }

        private void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<PRN221_asg1Context>(options =>
            {
                options.UseSqlServer("server=WiS;database=PRN221_asg1;user=sa;password=123456;TrustServerCertificate=True");
            }
            );


            services.AddAutoMapper(typeof(MappingProfile));
            services.AddSingleton<IMemberRepository, MemberRepository>();
            services.AddSingleton<IProductRepository, ProductRepository>();
            services.AddSingleton<IOrderRepository, OrderRepository>();
            services.AddSingleton<IOrderDetailRepository, OrderDetailRepository>();
            services.AddSingleton<OrderDAO>();
            services.AddSingleton<MainWindow>();
        }
    }

}
