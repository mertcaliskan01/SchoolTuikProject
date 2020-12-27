using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TuikProject.Data;
using TuikProject.Helper;
using TuikProject.Models;

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
            var mymodel = new IssizlikOrani();
            //using (var helper = new DbHelper(_context))
            //{
            //    mymodel.IssizlikOraniT1 = helper.getIssizlikOraniT1();
            //    mymodel.IssizlikOraniT2 = helper.getIssizlikOraniT2();
            //}
            var mymodelT1 = _context.IssizlikOraniT1.ToList();
            var mymodelT2 = _context.IssizlikOraniT2.ToList();
            mymodel.IssizlikOraniT1 = mymodelT1;
            mymodel.IssizlikOraniT2 = mymodelT2;


            return View(mymodel);
        }

        public async Task<IActionResult> Details(int? id, string searchString)
        {
            ViewData["CurrentFilter"] = searchString;

            var issizlikOrani = from s in _context.IssizlikOrani select s;
            //if (!String.IsNullOrEmpty(searchString))
            //{
            //    issizlikOrani = issizlikOrani.Where(s => s.Aciklama.Contains(searchString)
            //                               || s.Toplam2019.ToString().Contains(searchString)
            //                               || s.Toplam2020.ToString().Contains(searchString)
            //                               || s.Erkek2019.ToString().Contains(searchString)
            //                               || s.Erkek2020.ToString().Contains(searchString)
            //                               || s.Kadın2019.ToString().Contains(searchString)
            //                               || s.Kadın2020.ToString().Contains(searchString)
            //                               || s.ToplamOran2019.ToString().Contains(searchString)
            //                               || s.ToplamOran2020.ToString().Contains(searchString)
            //                               || s.ErkekOran2019.ToString().Contains(searchString)
            //                               || s.ErkekOran2020.ToString().Contains(searchString)
            //                               || s.KadınOran2019.ToString().Contains(searchString)
            //                               || s.KadınOran2020.ToString().Contains(searchString));
            //}

            return View(await issizlikOrani.AsNoTracking().ToListAsync());
        }
    }
}
