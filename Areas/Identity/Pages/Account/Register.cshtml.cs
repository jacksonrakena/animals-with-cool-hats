// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
#nullable disable

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Awch.Site.Areas.Identity.Pages.Account
{
    public class RegisterModel : PageModel
    {
        public async Task<IActionResult> OnGetAsync(string returnUrl = null)
        {
            return RedirectToPage("Login");
        }

        public async Task<IActionResult> OnPostAsync(string returnUrl = null)
        {
            return RedirectToPage("Login");
        }
    }
}
