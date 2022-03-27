using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Awch.Site.Pages;

public class Admin : PageModel
{
    public IActionResult OnGet()
    {
        if (!User.IsInRole("Administrator")) return RedirectToPage("/Login");
        return Page();
    }
}