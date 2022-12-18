using Inspire.Erp.Infrastructure.Database;
using Inspire.Erp.Infrastructure.Database.Repositoy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Inspire.Erp.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            var settings = configuration.GetSection("ApplicationSettings").Get<ApplicationSettings>();
            //user can able to get appsetting informations using dependency injection-- IOptions<ApplicationSettings>
            //services.Configure<ApplicationSettings>(settingsSection);
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddDbContext<InspireErpDBContext>(options => options.UseSqlServer(settings.ConnectionString));
            return services;
        }
    }
}

