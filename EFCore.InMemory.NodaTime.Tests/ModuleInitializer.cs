using System.Runtime.CompilerServices;
using VerifyTests;

namespace Microsoft.EntityFrameworkCore.InMemory;

public static class ModuleInitializer
{
    [ModuleInitializer]
    public static void Initialize()
    {
        VerifyEntityFramework.Initialize();
        VerifierSettings.DontScrubDateTimes();
    }
}