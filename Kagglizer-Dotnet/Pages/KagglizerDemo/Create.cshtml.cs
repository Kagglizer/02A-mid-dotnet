using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Kagglizer_Dotnet.Data;
using Kagglizer_Dotnet.Models;

namespace Kagglizer_Dotnet.Pages.KagglizerDemo
{
    public class CreateModel : PageModel
    {
        private readonly Kagglizer_Dotnet.Data.SbSqlContext _context;

        public CreateModel(Kagglizer_Dotnet.Data.SbSqlContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public StoryLine StoryLine { get; set; } = default!;

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.StoryLines.Add(StoryLine);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
