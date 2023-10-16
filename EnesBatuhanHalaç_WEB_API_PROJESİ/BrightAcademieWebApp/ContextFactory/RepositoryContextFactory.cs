using BrightApp.Data.Concrete.EFCore.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace BrightAcademieWebApp.ContextFactory
{
    public class RepositoryContextFactory : IDesignTimeDbContextFactory<BrightAcademieContext>
    {
        public BrightAcademieContext CreateDbContext(string[] args)
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json").Build();

            var builder = new DbContextOptionsBuilder<BrightAcademieContext>()
                .UseSqlite(configuration.GetConnectionString("sqlconnection"),
                prj=> prj.MigrationsAssembly("BrightAcademieWebApp"));

            return new BrightAcademieContext(builder.Options); 
        }
    }
}
