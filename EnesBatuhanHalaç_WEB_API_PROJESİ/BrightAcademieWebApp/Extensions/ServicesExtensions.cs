using BrightApp.Data.Abstract;
using BrightApp.Data.Concrete.EFCore.Context;
using BrightApp.Data.Concrete.EFCore.Repositories;
using Microsoft.EntityFrameworkCore;
using Services;
using Services.Contracts;

namespace BrightAcademieWebApp.Extensions
{
    public static class ServicesExtensions
    {
        public static void ConfigureSqlContext(this IServiceCollection services,IConfiguration configuration)
        => services.AddDbContext<BrightAcademieContext>(options => 
            options.UseSqlite(configuration.GetConnectionString("sqlconnection")));

        public static void ConfigureRepositoryManager(this IServiceCollection services)=>
            services.AddScoped<IRepositoryManager, RepositoryManager>();

        public static void ConfigureServiceManager(this IServiceCollection services) =>
            services.AddScoped<IServiceManager, ServiceManager>();

        public static void ConfigureLoggerService(this IServiceCollection services)
            => services.AddSingleton<ILoggerService, LoggerManager>();

    }
}
