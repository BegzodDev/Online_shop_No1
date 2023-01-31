using Application.Abstractions;
using Domain.Enums;
using Infrostructure.Abstractions;
using Infrostructure.Persistence;
using Infrostructure.Providers;
using Infrostructure.Service;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace Infrostructure
{
    public static class DependancyInjection 
    {
        public static IServiceCollection AddInfrostructureLayer(this IServiceCollection services,
            IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(options => options.UseNpgsql(configuration.GetConnectionString("DefaultConnection")));

            services.AddScoped<IApplicationDbContext, ApplicationDbContext>();

            services.AddScoped<IApplicationDbContext, ApplicationDbContext>();
            services.AddScoped<ITokenServiceInterface1, JWTservice>();
            services.AddScoped<IAuthService, AuthService>();
            services.AddScoped<IHashProvider, HashProvider>();

            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                .AddJwtBearer(options =>
                {
                    options.TokenValidationParameters = new TokenValidationParameters
                    {
                        ValidateIssuer = true,
                        ValidateAudience = true,
                        ValidateLifetime = true,
                        ValidateIssuerSigningKey = true,
                        ValidAudience = configuration["JWT:ValidAudience"],
                        ValidIssuer = configuration["JWT:ValidIssuer"],
                        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["JWT:Secret"]))
                    };
                });

            services.AddAuthorization(options =>
            {
                options.AddPolicy("AdminActions", policy =>
                {
                    policy.RequireClaim("Role", UserRole.Admin.ToString());
                });
            });



            return services;
        }


    }
}
