using ContactsManagement.Publisher.Infra.Configurations;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ContactsManagement.Publisher.Infra.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddInfra(this IServiceCollection services)
    {
        using var provider = services.BuildServiceProvider();
        using var scope = provider.CreateScope();
        var configuration = scope.ServiceProvider.GetRequiredService<IConfiguration>();

        services.AddSingleton(configuration
            .GetSection(nameof(RabbitMQConfiguration))
            .Get<RabbitMQConfiguration>()!);

        return services;
    }
}
