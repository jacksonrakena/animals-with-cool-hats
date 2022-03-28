using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Awch.Site.Pages;

public class Admin : PageModel
{
    public AwchDatabaseContext Context { get; set; }
    public StatisticsService Stats { get; set; }
    public Admin(AwchDatabaseContext context, StatisticsService stats)
    {
        Stats = stats;
        Context = context;
    }
    
    public IActionResult OnGet()
    {
        if (!User.IsInRole("Administrator")) return RedirectToPage("/Login");
        return Page();
    }
}