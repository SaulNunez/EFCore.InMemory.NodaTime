using System;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using VerifyTests;

namespace Microsoft.EntityFrameworkCore.InMemory;

public sealed class NodaTimeContext : DbContext
{
    public NodaTimeContext(DbContextOptions<NodaTimeContext> options) : base(options)
    {
    }

    public DbSet<NodaTimeTypes> NodaTimeTypes { get; set; } = null!;

    public static NodaTimeContext Create()
    {
        var builder = new DbContextOptionsBuilder<NodaTimeContext>()
            .UseInMemoryDatabase(Guid.NewGuid().ToString(), x => x.UseNodaTime())
            .EnableSensitiveDataLogging();

        builder.EnableRecording();

        var context = new NodaTimeContext(builder.Options);
        context.Database.EnsureCreated();
        return context;
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<NodaTimeTypes>()
            .HasData(new NodaTimeTypes
            {
                LocalDateTime = LocalDateTimeQueryTests.Value,
                LocalDate = LocalDateQueryTests.Value,
                LocalTime = LocalTimeQueryTests.Value,
                Instant = InstantQueryTests.Value,
                Id = 1,
            });

        var model = modelBuilder.Model;

        model.RemoveAnnotation(CoreAnnotationNames.ProductVersion);
    }
}