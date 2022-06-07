using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApp.Data;

namespace WebApp.Controllers
{
    public class StudentNewController : Controller
    {
        private readonly ApplicationDbContext db;

        public StudentNewController(ApplicationDbContext db)
        {
            this.db = db;
        }

        public IActionResult Index()
        {
            var data = db.Student.Include(s => s.Classes);
            return View(data);
        }
    }
}