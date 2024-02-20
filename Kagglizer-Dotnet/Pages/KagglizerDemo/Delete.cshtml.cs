using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Kagglizer_Dotnet.Data;
using Kagglizer_Dotnet.Models;

namespace Kagglizer_Dotnet.Pages.KagglizerDemo
{
    public class DeleteModel : PageModel
    {
        private readonly Kagglizer_Dotnet.Data.SbSqlContext _context;

        public DeleteModel(Kagglizer_Dotnet.Data.SbSqlContext context)
        {
            _context = context;
        }

        [BindProperty]
        public StoryLine StoryLine { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var storyline = await _context.StoryLines.FirstOrDefaultAsync(m => m.Id == id);

            if (storyline == null)
            {
                return NotFound();
            }
            else
            {
                StoryLine = storyline;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var storyline = await _context.StoryLines.FindAsync(id);
            if (storyline != null)
            {
                StoryLine = storyline;
                _context.StoryLines.Remove(StoryLine);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
