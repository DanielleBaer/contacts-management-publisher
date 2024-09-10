using Microsoft.Extensions.DependencyInjection;
using System.Diagnostics.CodeAnalysis;
using ContactsManagement.Publisher.Domain.Extensions;
using ContactsManagement.Publisher.Infra.Extensions;

namespace ContactsManagement.Publisher.Ioc;

[ExcludeFromCodeCoverage]
public static class Ioc
{
    public static IServiceCollection AddIocConfig(this IServiceCollection services) =>
        services
            .AddBusinessConfiguration()
            .AddInfra();
}
