using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TuikProject.Data;
using TuikProject.Helper;
using TuikProject.Models.IssizlikOraniModels;
using TuikProject.Models.TüketiciFiyatEndeksiModels;

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
                var mymodelT1 = helper.getİştekiDurumVeEkonomikFaaliyet();
                var mymodelT2 = helper.getSosyalGüvenlikKuruluşunaKayitlilik();
                mymodel.İştekiDurumVeEkonomikFaaliyet = mymodelT1;
                mymodel.SosyalGüvenlikKuruluşunaKayitlilik = mymodelT2;
            }

            return View(mymodel);
        }

        public IActionResult TuketiciFiyatEndeksiYillik()
        {
            var mymodel = new TüketiciFiyatEndeksi();

            using (var helper = new DbHelper(_context))
            {
                var mymodelT1 = helper.getİstatistikiBolgeBirimleriSiniflamasi();
                var mymodelT2 = helper.getAnaHarcamaGruplari();
                var mymodelT3 = helper.getTüketiciFiyatEndeksiVeDeğişimOranları();
                mymodel.İstatistikiBolgeBirimleriSiniflamasi = mymodelT1;
                mymodel.AnaHarcamaGruplari = mymodelT2;
                mymodel.TüketiciFiyatEndeksiVeDeğişimOranları = mymodelT3;
            }
            return View(mymodel);
        }

    }
}
