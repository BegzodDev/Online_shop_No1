using Application.Abstractions;
using Infrostructure.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Infrostructure
{
    public static class DependancyInjection 
    {
        public static IServiceCollection AddInfrostructureLayer(this IServiceCollection services,IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(options => options.UseNpgsql(configuration.GetConnectionString("DefaltConnection")));
            services.AddScoped<IApplicationDbContext, ApplicationDbContext>();
            return services;


        }


    }
}
