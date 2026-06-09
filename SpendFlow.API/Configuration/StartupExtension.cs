using SpendFlow.Application;
using SpendFlow.Infrastructure;
using SpendFlow.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace SpendFlow.API.Configuration
{
    public static class StartupExtension
    {
        public static void ConfigureServices(this IServiceCollection services, IConfiguration configuration)
        {
            // Add Entity Framework
            services.AddDbContext<AppDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

            // Add Infrastructure services
            services.AddInfrastructureServices();

            // Add Application services (includes MediatR)
            services.AddApplicationServices();
        }
    }
} 