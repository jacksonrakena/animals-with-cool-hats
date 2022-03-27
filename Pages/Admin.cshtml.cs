using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Awch.Site.Pages;

public class Admin : PageModel
{
    public void OnGet()
    {
        if (!User.IsInRole("Administrator")) RedirectToPage("/Login");
    }
}