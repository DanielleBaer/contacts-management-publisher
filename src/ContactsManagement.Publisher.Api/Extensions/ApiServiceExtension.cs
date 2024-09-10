using System.Diagnostics.CodeAnalysis;
using ContactsManagement.Publisher.Ioc;

namespace ContactsManagement.Publisher.Api.Extensions;

[ExcludeFromCodeCoverage]
public static class ApiServiceExtension
{
    public static IServiceCollection AddApiConfig(this IServiceCollection services) =>
        services
            .ConfigSwagger()
            .AddIocConfig();
}
