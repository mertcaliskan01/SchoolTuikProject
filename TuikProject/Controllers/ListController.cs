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

            using (var helper = new DbHelper(_context))
            {
                var mymodelT1 = helper.getIssizlikOraniT1();
                var mymodelT2 = helper.getIssizlikOraniT2();
                mymodel.IssizlikOraniT1 = mymodelT1;
                mymodel.IssizlikOraniT2 = mymodelT2;
            }

            return View(mymodel);
        }

    }
}
