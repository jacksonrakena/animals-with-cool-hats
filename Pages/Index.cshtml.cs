using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Awch.Site.Pages;

public class Index : PageModel
{
    public ImageRecord Record { get; set; }

    private readonly AwchDatabaseContext _context;
    
    public Index(AwchDatabaseContext context)
    {
        _context = context;
    }

    public async Task<IActionResult> OnGet()
    {
        if (RouteData.Values.TryGetValue("id", out var value) && value != null && int.TryParse(value.ToString(), out var valueInt))
        {
            Record = await _context.ImageRecords.FindAsync(valueInt);
        }
        Record ??= await _context.ImageRecords.OrderBy(r => Guid.NewGuid()).FirstOrDefaultAsync();
        
        return Page();
    }
}