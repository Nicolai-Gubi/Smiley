using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Smileys.Data.Models;

namespace Smileys.Pages
{
    public class IndexModel : PageModel
    {
        private SmileyDbContext _context;
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger, SmileyDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public List<Company> Companies { get; set; }

        public void OnGet()
        {
            Companies = _context.Companies.ToList();
        }
    }
}
