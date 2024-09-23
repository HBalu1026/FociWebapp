using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.AspNetCore.Mvc.RazorPages;
using FociWebApplication.Models;

namespace FociWebApplication.Pages
{
    public class AdatokFeltolteseFajlbolModel : PageModel
    {
        private readonly IWebHostEnvironment _env;
        private readonly FociDbContext _dbContext;

        public AdatokFeltolteseFajlbolModel(IWebHostEnvironment env, FociDbContext dbContext)
        {
            _env = env;
            _dbContext = dbContext;
        }

        [BindProperty]
        public IFormFile Feltoltes { get; set; }

        public void OnGet()
        {
        }

      

        public async Task<IActionResult> OnPostAsync()
        {
            if (Feltoltes == null || Feltoltes.Length == 0)
            {
                ModelState.AddModelError("Feltoltes", "Adj meg egy állpmányt!");
                return Page();
            }
            var UploadDirPath = Path.Combine(_env.ContentRootPath, "uploads");
            var UploadFilePath = Path.Combine(UploadDirPath, Feltoltes.FileName);
            using (var stream = new FileStream(UploadFilePath, FileMode.Create))
            {
                await Feltoltes.CopyToAsync(stream);
            }

            StreamReader sr = new StreamReader(UploadFilePath);
            sr.ReadLine();
            while (!sr.EndOfStream)
            {
                var line = sr.ReadLine();
                var elemek = line.Split();
                Meccs ujMeccs = new Meccs(elemek);


                _dbContext.Meccsek.Add(ujMeccs);
            }
            sr.Close();
            _dbContext.SaveChanges();
            //System.IO.File.Delete(UploadFilePath);
            return Page();
        }
    }
}
