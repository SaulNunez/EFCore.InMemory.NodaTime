using System;
using Microsoft.EntityFrameworkCore.Infrastructure;

// ReSharper disable once CheckNamespace
namespace Microsoft.Extensions.DependencyInjection;

public static class InMemoryNodaTimeServiceCollectionExtensions
{
    public static IServiceCollection AddEntityFrameworkInMemoryNodaTime(this IServiceCollection services)
    {
        ArgumentNullException.ThrowIfNull(services);

        new EntityFrameworkServicesBuilder(services)
            .TryAddProviderSpecificServices(
                services => 
                {
                    // No specific services needed for InMemory NodaTime support currently
                    // as InMemory generally handles unknown types by storing them as is.
                });

        return services;
    }
}