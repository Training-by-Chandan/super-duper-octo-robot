using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApp.Data;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class StudentNewController : Controller
    {
        private readonly ApplicationDbContext db;

        public StudentNewController(ApplicationDbContext db)
        {
            this.db = db;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var data = db.Student.Include(s => s.Classes);
            return View(data);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Student model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    //check if there is dupicate record
                    var existing = db.Student.FirstOrDefault(p => p.FirstName == model.FirstName && p.LastName == model.LastName && p.Email == model.Email && p.Phone == model.Phone);
                    
                    if (existing == null)
                    {
                        //create
                        db.Student.Add(model);
                        db.SaveChanges();
                        //post create functionalities, write it by yourself

                        return RedirectToAction("Index");
                    }
                    else
                    {
                        ModelState.AddModelError("summary", "Record with the same firstname, lastname, email, and phone number already exists");
                        return View();
                    }
                }
                catch (Exception ex)
                {
                    return View();
                }
            }
            return View();
        }
    }
}