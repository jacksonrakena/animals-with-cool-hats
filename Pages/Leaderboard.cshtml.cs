using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Awch.Site.Pages;

public class Leaderboard : PageModel
{
    private readonly AwchDatabaseContext _context;
    private readonly StatisticsService _stats;
    
    public Leaderboard(AwchDatabaseContext context, StatisticsService stats)
    {
        _context = context;
        _stats = stats;
    }
    public List<TopSubmitter> TopSubmitters = new();
    
    public async Task<IActionResult> OnGetAsync()
    {
        TopSubmitters = await _stats.GetTopSubmittersAsync();
        return Page();
    }
}