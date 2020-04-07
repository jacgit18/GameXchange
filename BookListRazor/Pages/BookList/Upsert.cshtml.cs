using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookListRazor.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace BookListRazor.Pages.BookList
{
    public class UpsertModel : PageModel
    {
        private ApplicationDbContext _db;

        public UpsertModel(ApplicationDbContext db)
        {
            _db = db;
        }

        [BindProperty]
        public AccountDbGenerator AccountDbGenerator { get; set; }

        public async Task<IActionResult> OnGet(int? id)
        {
            AccountDbGenerator = new AccountDbGenerator();
            if (id == null)
            {
                //create
                return Page();
            }

            //update
            AccountDbGenerator = await _db.AccountDbGenerator.FirstOrDefaultAsync(u => u.Id == id);
            if (AccountDbGenerator == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {

                if (AccountDbGenerator.Id == 0)
                {
                    _db.AccountDbGenerator.Add(AccountDbGenerator);
                }
                else
                {
                    _db.AccountDbGenerator.Update(AccountDbGenerator);
                }

                await _db.SaveChangesAsync();

                return RedirectToPage("Index");
            }
            return RedirectToPage();
        }

    }
}