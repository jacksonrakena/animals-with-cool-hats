using System.ComponentModel.DataAnnotations;
using System.Net.Mime;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

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
    
    [BindProperty]
    public InputModel Input { get; set; }

    public class InputModel
    {
        [Required]
        public string Url { get; set; }
        
        [Required]
        public string Submitter { get; set; }
    }
    
    public async Task<IActionResult> OnPostAsync()
    {
        if (!ModelState.IsValid) return Page();
        
        try
        {
            if (await Context.ImageRecords.AnyAsync(e => e.Url == Input.Url))
            {
                ModelState.AddModelError("Url", "This is already in the database.");
                return Page();
            }
            Context.ImageRecords.Add(new ImageRecord
            {
                Author = Input.Submitter,
                Url = Input.Url
            });
            await Context.SaveChangesAsync();
            ModelState.Clear();
        }
        catch (Exception e)
        {
            ModelState.AddModelError("db", e.Message);
        }

        // If we got this far, something failed, redisplay form
        return Page();
    }
    
}