using Microsoft.Extensions.DependencyInjection;
using System.Diagnostics.CodeAnalysis;

namespace ContactsManagement.Publisher.Domain.Extensions;

[ExcludeFromCodeCoverage]
public static class BusinessExtension
{
    public static IServiceCollection AddBusinessConfiguration(this IServiceCollection services)
    {
        return services;
    }
}
