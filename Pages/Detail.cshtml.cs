using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Smileys.Data.Models;
using System.Linq;

namespace Smileys.Pages
{
    public class DetailModel : PageModel
    {
        private SmileyDbContext _context;
        public DetailModel(SmileyDbContext context)
        {
            _context = context;
        }

        public Company Company { get; set; }

        public void OnGet(int id)
        {
            Company = _context.Companies.FirstOrDefault(x => x.Id == id);
        }
    }
}
