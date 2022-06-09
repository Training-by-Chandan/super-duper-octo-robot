using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
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

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var existing = db.Student.Find(id);
            if (existing == null)
            {
                ViewBag.message = "Record not found";
            }
            return View(existing);
        }

        [HttpPost]
        public IActionResult Edit(Student model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    //check if there is dupicate record
                    var existing = db.Student.Find(model.Id);

                    if (existing == null)
                    {
                        ViewBag.message = "Record not found";
                        return View();
                    }
                    else
                    {
                        existing.FirstName = model.FirstName;
                        existing.LastName = model.LastName;
                        existing.Phone = model.Phone;
                        existing.Email = model.Email;
                        existing.ClassId = model.ClassId;
                        db.Student.Update(existing);
                        db.SaveChanges();
                        return RedirectToAction("Index");
                    }
                }
                catch (Exception ex)
                {
                    return View(model);
                }
            }
            return View(model);
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var existing = db.Student.Find(id);
            if (existing == null)
            {
                ViewBag.message = "Record not found";
            }
            return View(existing);
        }

        [HttpPost]
        public IActionResult Delete(Student model)
        {
            try
            {
                //check if there is existing record
                var existing = db.Student.Find(model.Id);

                if (existing == null)
                {
                    ViewBag.message = "Record not found";
                    return View();
                }
                else
                {
                    db.Student.Remove(existing);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
            }
            catch (Exception ex)
            {
                return RedirectToAction("Index");
            }
        }
    }
}