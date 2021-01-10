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

        public IActionResult IssizlikOrani(string searchString)
        {
            ViewData["CurrentFilter"] = searchString;
            var mymodel = new IssizlikOrani();
            using (var helper = new DbHelper(_context))
            {
                if (!string.IsNullOrEmpty(searchString))
                {
                    mymodel.İştekiDurumVeEkonomikFaaliyet = helper.getİştekiDurumVeEkonomikFaaliyet(searchString);
                    mymodel.SosyalGüvenlikKuruluşunaKayitlilik = helper.getSosyalGüvenlikKuruluşunaKayitlilik(searchString);
                }
                else
                {
                    mymodel.İştekiDurumVeEkonomikFaaliyet = helper.getİştekiDurumVeEkonomikFaaliyet();
                    mymodel.SosyalGüvenlikKuruluşunaKayitlilik = helper.getSosyalGüvenlikKuruluşunaKayitlilik();
                }
            }
            return View(mymodel);
        }

        public IActionResult TuketiciFiyatEndeksiYillik(string searchString)
        {
            var mymodel = new TüketiciFiyatEndeksi();

            using (var helper = new DbHelper(_context))
            {
                if (!string.IsNullOrEmpty(searchString))
                {
                    mymodel.İstatistikiBolgeBirimleriSiniflamasi = helper.getİstatistikiBolgeBirimleriSiniflamasi(searchString);
                    mymodel.AnaHarcamaGruplari = helper.getAnaHarcamaGruplari(searchString);
                    mymodel.TüketiciFiyatEndeksiVeDeğişimOranları = helper.getTüketiciFiyatEndeksiVeDeğişimOranları(searchString);
                }
                else
                {
                    mymodel.İstatistikiBolgeBirimleriSiniflamasi = helper.getİstatistikiBolgeBirimleriSiniflamasi();
                    mymodel.AnaHarcamaGruplari = helper.getAnaHarcamaGruplari();
                    mymodel.TüketiciFiyatEndeksiVeDeğişimOranları = helper.getTüketiciFiyatEndeksiVeDeğişimOranları();
                }


            }
            return View(mymodel);
        }

    }
}
