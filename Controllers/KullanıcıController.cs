using System.Security.Cryptography;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TarifApp.Data;

namespace TarifApp.Controllers
{
    public class KullanıcıController : Controller{
        private readonly DataContext _context;
         public KullanıcıController(DataContext context){
            _context= context;
         }
        public IActionResult Index()
        {
            var Kullanıcılar = _context.Kullanıcılar.ToListAsync();
            return View();

        }
        [HttpPost]
            public async Task<IActionResult> Create(Kullanıcı model){
                _context.Kullanıcılar.Add(model);
                await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        
    }
}
