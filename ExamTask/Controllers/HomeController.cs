using ExamTask.DAL;
using ExamTask.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ExamTask.Controllers
{
    public class HomeController : Controller
    {
        private AppDbContext _context { get;}

        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            HomeVM homeVM = new HomeVM()
            {
                Services = await _context.Services.ToListAsync()
            };
            return View(homeVM);
        }

    }
}
