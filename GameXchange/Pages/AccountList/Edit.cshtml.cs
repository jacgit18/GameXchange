using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GameXchange.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GameXchange.Pages.AccountList
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
                var AccountFromDb = await _db.AccountDbGenerator.FindAsync(AccountDbGenerator.Id);
                AccountFromDb.UserName = AccountDbGenerator.UserName;
                AccountFromDb.Password = AccountDbGenerator.Password;
                AccountFromDb.AccountType = AccountDbGenerator.AccountType;
                AccountFromDb.BillingAddress = AccountDbGenerator.BillingAddress;
                AccountFromDb.PaymentInfo = AccountDbGenerator.PaymentInfo;
                AccountFromDb.PhoneNumber = AccountDbGenerator.PhoneNumber;
                AccountFromDb.RegisterDate = AccountDbGenerator.RegisterDate;
                AccountFromDb.Version = AccountDbGenerator.Version;

                await _db.SaveChangesAsync();

                return RedirectToPage("Index");
            }
            return RedirectToPage();
        }
    }
}