using System;
using System.Collections.Generic;
using System.Linq;
using GameXchange.Model;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;


namespace GameXchange.Pages.Forms
{
    public class AccountLoginModel : PageModel
    {
        private readonly ApplicationDbContext _db;

        public AccountLoginModel(ApplicationDbContext db)
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
            var account = await _db.AccountDbGenerator.FindAsync(id);
            if (account == null)
            {
                return NotFound();
            }
            _db.AccountDbGenerator.Remove(account);
            await _db.SaveChangesAsync();

            return RedirectToPage("Index");
        }
    }
}