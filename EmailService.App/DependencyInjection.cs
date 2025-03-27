using Microsoft.Extensions.DependencyInjection;

namespace EmailService.App;

public static class DependencyInjection
{
    public static IServiceCollection AddEmailService (this IServiceCollection services)
    {
        return services;
    }
}
