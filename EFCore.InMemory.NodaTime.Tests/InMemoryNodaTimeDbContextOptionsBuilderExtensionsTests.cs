using System;
using Xunit;

namespace Microsoft.EntityFrameworkCore.InMemory;

public class InMemoryNodaTimeDbContextOptionsBuilderExtensionsTests
{
    [Fact]
    public static void CallingExtensionMethodWithNullThrows()
    {
        var ex = Assert.Throws<ArgumentNullException>(() =>
            InMemoryNodaTimeDbContextOptionsBuilderExtensions.UseNodaTime(null!));
        Assert.Equal("builder", ex.ParamName);
    }
}