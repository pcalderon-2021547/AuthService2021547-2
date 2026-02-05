using AuthService2021547.Domain.Interfaces;
using AuthService2021547.Persistence.Data;
using AuthService2021547.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;
using AuthService2021547.Application.Interface;
using AuthService2021547.Application.Services;

namespace AuthService2021547.Api.Extensions;

public static class ServiceCollectionsExtensions
{
    public static IServiceCollection AddApplicationService(this IServiceCollection service, IConfiguration configuration)
    {
        service.AddDbContext<ApplicationDbContext>(FileOptions =>
            options.UseNpgsql(configuration.GetConnectionString("DefaultConnection"))
                .UseSnakecaseNamingConvention());

        services.AddScoped<IUserRepository, UserRepository>();
        services.AddScoped<IRoleRepository, RoleRepository>();

        service.AddHelthChecks();

        return service;
    }

    public static IServiceCollection AddApiDocumentation(this IServiceCollection services)
    {
        services.AddEndpointsApiExplore();
        services.AddSwaggerGen();

        return services;
    }

    
}