using BitVentureWebApp.Data;
using BitVentureWebApp.Data.Repositories;
using BitVentureWebApp.Helpers;
using BitVentureWebApp.Interfaces;
using Microsoft.EntityFrameworkCore;
using AutoMapper;

namespace BitVentureWebApp.Extensions
{
    public static class ApplicationServiceExtensions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration config)
        {
            services.AddScoped<IPaymentRepository, PaymentRepository>();
            services.AddAutoMapper(typeof(AutoMapperProfiles).Assembly);
            var connectionString = config.GetConnectionString("DefaultConnection");
            services.AddDbContextFactory<DataContext>(options => options.UseSqlServer(
                connectionString, sqlServerOptionsAction: sqlOptions =>
                {
                    sqlOptions.EnableRetryOnFailure();

                }), ServiceLifetime.Transient);
            return services;
        }

    }
}
