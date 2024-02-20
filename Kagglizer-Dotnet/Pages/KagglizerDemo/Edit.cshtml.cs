using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Kagglizer_Dotnet.Data;
using Kagglizer_Dotnet.Models;

namespace Kagglizer_Dotnet.Pages.KagglizerDemo
{
    public class EditModel : PageModel
    {
        private readonly Kagglizer_Dotnet.Data.SbSqlContext _context;

        public EditModel(Kagglizer_Dotnet.Data.SbSqlContext context)
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

            var storyline =  await _context.StoryLines.FirstOrDefaultAsync(m => m.Id == id);
            if (storyline == null)
            {
                return NotFound();
            }
            StoryLine = storyline;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(StoryLine).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!StoryLineExists(StoryLine.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool StoryLineExists(int id)
        {
            return _context.StoryLines.Any(e => e.Id == id);
        }
    }
}
