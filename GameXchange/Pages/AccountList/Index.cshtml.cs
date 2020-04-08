using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GameXchange.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace GameXchange.Pages.AccountList
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _db;

        public IndexModel(ApplicationDbContext db)
        {
            _db = db;
        }

        public IEnumerable<AccountDbGenerator> AccountDbGenerators { get; set; }

        public async Task OnGet()
        {
            AccountDbGenerators = await _db.AccountDbGenerator.ToListAsync();
        }

        public async Task<IActionResult> OnPostDelete(int id)
        {
            var book = await _db.AccountDbGenerator.FindAsync(id);
            if (book == null)
            {
                return NotFound();
            }
            _db.AccountDbGenerator.Remove(book);
            await _db.SaveChangesAsync();

            return RedirectToPage("Index");
        }
    }
}