using System;
using Microsoft.Extensions.DependencyInjection;
using Xunit;

namespace Microsoft.EntityFrameworkCore.InMemory;

public class InMemoryNodaTimeServiceCollectionExtensionsTests
{
    [Fact]
    public static void CallingExtensionMethodWithNullThrows()
    {
        var ex = Assert.Throws<ArgumentNullException>(() =>
            InMemoryNodaTimeServiceCollectionExtensions.AddEntityFrameworkInMemoryNodaTime(null!));
        Assert.Equal("services", ex.ParamName);
    }
}