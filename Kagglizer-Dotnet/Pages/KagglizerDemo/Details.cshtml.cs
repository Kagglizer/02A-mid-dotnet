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
    public class DetailsModel : PageModel
    {
        private readonly Kagglizer_Dotnet.Data.SbSqlContext _context;

        public DetailsModel(Kagglizer_Dotnet.Data.SbSqlContext context)
        {
            _context = context;
        }

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
    }
}
