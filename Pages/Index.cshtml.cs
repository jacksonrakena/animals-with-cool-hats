using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Awch.Site.Pages;

public class Index : PageModel
{
    public string ImageUrl { get; set; }
    public string Uploader { get; set; }

    private readonly AwchDatabaseContext _context;
    
    public Index(AwchDatabaseContext context)
    {
        _context = context;
    }

    public async Task OnGet()
    {
        var record = await _context.ImageRecords.OrderBy(r => Guid.NewGuid()).FirstOrDefaultAsync();
        ImageUrl = record?.Url;
        Uploader = record?.Author;
    }
}