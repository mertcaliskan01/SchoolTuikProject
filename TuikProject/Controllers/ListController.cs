using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using System;
using System.Collections.Generic;
using System.IO;
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
        private IWebHostEnvironment _hostEnvironment;


        public ListController(ApplicationDbContext context, IWebHostEnvironment hostEnvironment)
        {
            _hostEnvironment = hostEnvironment;

            _context = context;
        }

        public IActionResult IssizlikOrani(string searchString)
        {
            ViewData["CurrentFilter"] = searchString;
            var mymodel = new IssizlikOrani();
            using (var helper = new ControllerHelper(_context))
            {
                mymodel = helper.getIssizlikOrani(searchString);
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


        public async Task<IActionResult> IssizlikOraniExport(string searchString)
        {
            var memory = new MemoryStream();
            string sFileName = @"IssizlikOrani.xlsx";
            try
            {
                string sWebRootFolder = _hostEnvironment.WebRootPath;
                string URL = string.Format("{0}://{1}/{2}", Request.Scheme, Request.Host, sFileName);
                FileInfo file = new FileInfo(Path.Combine(sWebRootFolder, sFileName));
                using (var fs = new FileStream(Path.Combine(sWebRootFolder, sFileName), FileMode.Create, FileAccess.Write))
                {
                    IWorkbook workbook;
                    workbook = new XSSFWorkbook();
                    ISheet excelSheet = workbook.CreateSheet("Excel");
                    int i = 0;

                    var issizlikOraniModel = new IssizlikOrani();
                    using (var helper = new ControllerHelper(_context))
                    {
                        issizlikOraniModel = helper.getIssizlikOrani(searchString);
                    }

                    IRow row = excelSheet.CreateRow(i);

                    row.CreateCell(0).SetCellValue("Açıklama");
                    row.CreateCell(1).SetCellValue("Toplam 2019");
                    row.CreateCell(2).SetCellValue("Toplam 2020");
                    row.CreateCell(3).SetCellValue("Erkek 2019");
                    row.CreateCell(4).SetCellValue("Erkek 2020");
                    row.CreateCell(5).SetCellValue("Kadın 2019");
                    row.CreateCell(6).SetCellValue("Kadın 2020");
                    row.CreateCell(7).SetCellValue("Toplam Oran 2019");
                    row.CreateCell(8).SetCellValue("Toplam Oran 2020");
                    row.CreateCell(9).SetCellValue("Erkek Oran 2019");
                    row.CreateCell(10).SetCellValue("Erkek Oran 2020");
                    row.CreateCell(11).SetCellValue("Kadın Oran 2019");
                    row.CreateCell(12).SetCellValue("Kadın Oran 2020");

                    foreach (var item in issizlikOraniModel.İştekiDurumVeEkonomikFaaliyet)
                    {
                        i++;
                        row = excelSheet.CreateRow(i);
                        row.CreateCell(0).SetCellValue(item.Aciklama);
                        row.CreateCell(1).SetCellValue(item.Toplam2019);
                        row.CreateCell(2).SetCellValue(item.Toplam2020);
                        row.CreateCell(3).SetCellValue(item.Erkek2019);
                        row.CreateCell(4).SetCellValue(item.Erkek2020);
                        row.CreateCell(5).SetCellValue(item.Kadin2019);
                        row.CreateCell(6).SetCellValue(item.Kadin2020);
                        row.CreateCell(7).SetCellValue(item.ToplamOran2019);
                        row.CreateCell(8).SetCellValue(item.ToplamOran2020);
                        row.CreateCell(9).SetCellValue(item.ErkekOran2019);
                        row.CreateCell(10).SetCellValue(item.ErkekOran2020);
                        row.CreateCell(11).SetCellValue(item.KadinOran2019);
                        row.CreateCell(12).SetCellValue(item.KadinOran2020);
                    }

                    i += 5;

                    row = excelSheet.CreateRow(i);

                    row.CreateCell(0).SetCellValue("Açıklama");
                    row.CreateCell(1).SetCellValue("İstihdam 2019");
                    row.CreateCell(2).SetCellValue("İstihdam 2020");
                    row.CreateCell(3).SetCellValue("Toplam Kayıt dışı 2019");
                    row.CreateCell(4).SetCellValue("Toplam Kayıt dışı 2020");
                    row.CreateCell(5).SetCellValue("Oran (%) Kayıt dışı 2019");
                    row.CreateCell(6).SetCellValue("Oran (%) Kayıt dışı 2020");
                    row.CreateCell(7).SetCellValue("Erkek İstihdam 2019");
                    row.CreateCell(8).SetCellValue("Erkek İstihdam 2020");
                    row.CreateCell(9).SetCellValue("Erkek Kayıt dışı 2019");
                    row.CreateCell(10).SetCellValue("Erkek Kayıt dışı 2020");
                    row.CreateCell(11).SetCellValue("Oran (%) Erkek Kayıt dışı 2019");
                    row.CreateCell(12).SetCellValue("Oran (%) Erkek Kayıt dışı 2020");
                    row.CreateCell(13).SetCellValue("Kadın İstihdam 2019");
                    row.CreateCell(14).SetCellValue("Kadın İstihdam 2020");
                    row.CreateCell(15).SetCellValue("Kadın Kayıt dışı 2019");
                    row.CreateCell(16).SetCellValue("Kadın Kayıt dışı 2020");
                    row.CreateCell(17).SetCellValue("Kadın (%) Erkek Kayıt dışı 2019");
                    row.CreateCell(18).SetCellValue("Kadın (%) Erkek Kayıt dışı2020");

                    foreach (var item in issizlikOraniModel.SosyalGüvenlikKuruluşunaKayitlilik)
                    {
                        i++;
                        row = excelSheet.CreateRow(i);
                        row.CreateCell(0).SetCellValue(item.Aciklama);
                        row.CreateCell(1).SetCellValue(item.ToplamIstihdam2019);
                        row.CreateCell(2).SetCellValue(item.ToplamIstihdam2020);
                        row.CreateCell(3).SetCellValue(item.ToplamKayitdisi2019);
                        row.CreateCell(4).SetCellValue(item.ToplamKayitdisi2020);
                        row.CreateCell(5).SetCellValue(item.ToplamKayitdisiOrani2019);
                        row.CreateCell(6).SetCellValue(item.ToplamKayitdisiOrani2020);
                        row.CreateCell(7).SetCellValue(item.ErkekIstihdam2019);
                        row.CreateCell(8).SetCellValue(item.ErkekIstihdam2020);
                        row.CreateCell(9).SetCellValue(item.ErkekKayitdisi2019);
                        row.CreateCell(10).SetCellValue(item.ErkekKayitdisi2020);
                        row.CreateCell(11).SetCellValue(item.ErkekKayitdisiOrani2019);
                        row.CreateCell(12).SetCellValue(item.ErkekKayitdisiOrani2020);
                        row.CreateCell(13).SetCellValue(item.KadinIstihdam2019);
                        row.CreateCell(14).SetCellValue(item.KadinIstihdam2020);
                        row.CreateCell(15).SetCellValue(item.KadinKayitdisi2019);
                        row.CreateCell(16).SetCellValue(item.KadinKayitdisi2020);
                        row.CreateCell(17).SetCellValue(item.KadinKayitdisiOrani2019);
                        row.CreateCell(18).SetCellValue(item.KadinKayitdisiOrani2020);
                    }


                    workbook.Write(fs);

                }
                using (var stream = new FileStream(Path.Combine(sWebRootFolder, sFileName), FileMode.Open))
                {
                    await stream.CopyToAsync(memory);
                }
                memory.Position = 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            return File(memory, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", sFileName);
        }

    }
}
