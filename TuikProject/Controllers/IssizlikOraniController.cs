using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TuikProject.Data;

namespace TuikProject.Controllers
{
    public class IssizlikOraniController : Controller
    {
        private readonly ApplicationDbContext _context;

        public IssizlikOraniController(ApplicationDbContext context)
        {
            _context = context;
        }

        //public async Task<IActionResult> Index()
        //{
        //    return View(await _context.IssizlikOraniTablo1.ToListAsync());
        //}

        //public async Task<IActionResult> Details(int? id, string searchString)
        //{
        //    ViewData["CurrentFilter"] = searchString;

        //    var issizlikOrani = from s in _context.IssizlikOraniTablo1 select s;
        //    //if (!String.IsNullOrEmpty(searchString))
        //    //{
        //    //    issizlikOrani = issizlikOrani.Where(s => s.Aciklama.Contains(searchString)
        //    //                               || s.Toplam2019.ToString().Contains(searchString)
        //    //                               || s.Toplam2020.ToString().Contains(searchString)
        //    //                               || s.Erkek2019.ToString().Contains(searchString)
        //    //                               || s.Erkek2020.ToString().Contains(searchString)
        //    //                               || s.Kadın2019.ToString().Contains(searchString)
        //    //                               || s.Kadın2020.ToString().Contains(searchString)
        //    //                               || s.ToplamOran2019.ToString().Contains(searchString)
        //    //                               || s.ToplamOran2020.ToString().Contains(searchString)
        //    //                               || s.ErkekOran2019.ToString().Contains(searchString)
        //    //                               || s.ErkekOran2020.ToString().Contains(searchString)
        //    //                               || s.KadınOran2019.ToString().Contains(searchString)
        //    //                               || s.KadınOran2020.ToString().Contains(searchString));
        //    //}
            
        //    return View(await issizlikOrani.AsNoTracking().ToListAsync());
        //}


    }
}
