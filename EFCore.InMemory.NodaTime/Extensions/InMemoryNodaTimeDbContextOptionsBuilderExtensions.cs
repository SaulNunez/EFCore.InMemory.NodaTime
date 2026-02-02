using System;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.InMemory.Infrastructure.Internal;

// ReSharper disable once CheckNamespace
namespace Microsoft.EntityFrameworkCore;

public static class InMemoryNodaTimeDbContextOptionsBuilderExtensions
{
    public static InMemoryDbContextOptionsBuilder UseNodaTime(this InMemoryDbContextOptionsBuilder builder)
    {
        ArgumentNullException.ThrowIfNull(builder);

        var coreBuilder = ((IInfrastructure<DbContextOptionsBuilder>)builder).Instance;

        var extension = coreBuilder.Options.FindExtension<InMemoryNodaTimeOptionsExtension>()
                        ?? new InMemoryNodaTimeOptionsExtension();

        ((IDbContextOptionsBuilderInfrastructure)coreBuilder).AddOrUpdateExtension(extension);

        return builder;
    }
}