using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TuikProject.Data;
using TuikProject.Models;

namespace TuikProject.Controllers
{
    public class IssizlikOraniT2Controller : Controller
    {
        private readonly ApplicationDbContext _context;

        public IssizlikOraniT2Controller(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: IssizlikOraniT2
        public async Task<IActionResult> Index()
        {
            return View(await _context.IssizlikOraniTablo2.ToListAsync());
        }

        // GET: IssizlikOraniT2/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var issizlikOraniT2 = await _context.IssizlikOraniTablo2
                .FirstOrDefaultAsync(m => m.Id == id);
            if (issizlikOraniT2 == null)
            {
                return NotFound();
            }

            return View(issizlikOraniT2);
        }

    }
}
