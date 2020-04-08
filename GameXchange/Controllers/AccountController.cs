using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GameXchange.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GameXchange.Controllers
{
    [Route("api/Account")]
    [ApiController]
    public class AccountController : Controller
    {
        private readonly ApplicationDbContext _db;

        public AccountController(ApplicationDbContext db)
        {
            _db = db;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Json(new { data =await _db.AccountDbGenerator.ToListAsync() });
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            var accountFromDb = await _db.AccountDbGenerator.FirstOrDefaultAsync(u => u.Id == id);
            if (accountFromDb == null)
            {
                return Json(new { success = false, message = "Error while Deleting" });
            }
            _db.AccountDbGenerator.Remove(accountFromDb);
            await _db.SaveChangesAsync();
            return Json(new { success = true, message = "Delete successful" });
        }
    }
}