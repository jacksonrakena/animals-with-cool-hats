using Abyssal.Common;
using Microsoft.EntityFrameworkCore;

namespace Awch.Site;

public record TopSubmitter(string Name, int NumberOfSubmissions);

public class StatisticsService
{
    private readonly IServiceProvider _services;
    public StatisticsService(IServiceProvider services)
    {
        _services = services;
    }

    public DateTimeOffset GetLastUpdated() => _topSubmitters.LastUpdated;
    
    private readonly Cachable<List<TopSubmitter>> _topSubmitters =
        new(null, DateTimeOffset.Now, TimeSpan.FromHours(1));

    public async Task<List<TopSubmitter>> GetTopSubmittersAsync()
    {
        if (!_topSubmitters.IsExpired()) return _topSubmitters.Value;
        using var scope = _services.CreateScope();
        _topSubmitters.Set(
            (await scope.ServiceProvider.GetRequiredService<AwchDatabaseContext>().ImageRecords.ToListAsync())
            .GroupBy(e => e.Author)
            .OrderByDescending(d => d.Count())
            .Take(5)
            .Select(e => new TopSubmitter(e.Key, e.Count()))
            .ToList());
        return _topSubmitters.Value!;
    }
}