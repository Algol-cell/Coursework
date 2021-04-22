using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PracticTeh.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PracticTeh.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationContext db;
        public HomeController(ApplicationContext context)
        {
            db = context;
        }

        //Добавление новых объектов в базу и вывод из неё
        public async Task<IActionResult> Index()
        {
            return View(await db.Users.ToListAsync()); //получение объектов из бд
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(User user)
        {
            db.Users.Add(user);         //формируется sql-выражение INSERT
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

    }
}
