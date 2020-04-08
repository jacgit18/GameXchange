using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GameXchange.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GameXchange.Pages.BookList
{
    public class EditModel : PageModel
    {
        private ApplicationDbContext _db;

        public EditModel(ApplicationDbContext db)
        {
            _db = db;
        }

        [BindProperty]
        public AccountDbGenerator AccountDbGenerator { get; set; }

        public async Task OnGet(int id)
        {
            AccountDbGenerator = await _db.AccountDbGenerator.FindAsync(id);
        }

        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {
                var BookFromDb = await _db.AccountDbGenerator.FindAsync(AccountDbGenerator.Id);
                BookFromDb.UserName = AccountDbGenerator.UserName;
                BookFromDb.Password = AccountDbGenerator.Password;
                BookFromDb.AccountType = AccountDbGenerator.AccountType;
                BookFromDb.BillingAddress = AccountDbGenerator.BillingAddress;
                BookFromDb.PaymentInfo = AccountDbGenerator.PaymentInfo;
                BookFromDb.PhoneNumber = AccountDbGenerator.PhoneNumber;
                BookFromDb.RegisterDate = AccountDbGenerator.RegisterDate;

                await _db.SaveChangesAsync();

                return RedirectToPage("Index");
            }
            return RedirectToPage();
        }
    }
}