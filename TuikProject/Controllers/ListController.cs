using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TuikProject.Data;

namespace TuikProject.Controllers
{
    public class ListController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ListController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult IssizlikOrani()
        {
            return View();
        }
    }
}
