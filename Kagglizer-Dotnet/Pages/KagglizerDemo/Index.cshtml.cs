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
    public class IndexModel : PageModel
    {
        private readonly Kagglizer_Dotnet.Data.SbSqlContext _context;

        public IndexModel(Kagglizer_Dotnet.Data.SbSqlContext context)
        {
            _context = context;
        }

        public IList<StoryLine> StoryLine { get;set; } = default!;

        public async Task OnGetAsync()
        {
            StoryLine = await _context.StoryLines.ToListAsync();
        }
    }
}
