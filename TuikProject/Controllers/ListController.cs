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
using TuikProject.Models.CezaInfazKurumuIstatistikleriModels;
using TuikProject.Models.IssizlikOraniModels;
using TuikProject.Models.KulturEkonomisiModels;
using TuikProject.Models.SaglikHarcamalariIstatistikleriModels;
using TuikProject.Models.SosyalKorumaIstatistikleriModels;
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
            IssizlikOrani issizlikOraniModel = new IssizlikOrani();
            using (var helper = new ControllerHelper(_context))
            {
                issizlikOraniModel = helper.getIssizlikOrani(searchString);
            }
            return View(issizlikOraniModel);
        }

        public IActionResult TuketiciFiyatEndeksiYillik(string searchString)
        {
            ViewData["CurrentFilter"] = searchString;
            TüketiciFiyatEndeksi tüketiciFiyatEndeksiModel = new TüketiciFiyatEndeksi();
            using (var helper = new ControllerHelper(_context))
            {
                tüketiciFiyatEndeksiModel = helper.getTuketiciFiyatEndeksiYillik(searchString);
            }
            return View(tüketiciFiyatEndeksiModel);
        }

        public IActionResult CezaInfazKurumuIstatistikleri(string searchString)
        {
            ViewData["CurrentFilter"] = searchString;
            CezaInfazKurumuIstatistikleri model = new CezaInfazKurumuIstatistikleri();
            using (var helper = new ControllerHelper(_context))
            {
                model = helper.getCezaInfazKurumuIstatistikleri(searchString);
            }
            return View(model);
        }

        public IActionResult KulturEkonomisi(string searchString)
        {
            ViewData["CurrentFilter"] = searchString;
            KulturEkonomisi model = new KulturEkonomisi();
            using (var helper = new ControllerHelper(_context))
            {
                model = helper.getKulturEkonomisi(searchString);
            }
            return View(model);
        }

        public IActionResult SaglikHarcamalariIstatistikleri(string searchString)
        {
            ViewData["CurrentFilter"] = searchString;
            SaglikHarcamalariIstatistikleri model = new SaglikHarcamalariIstatistikleri();
            using (var helper = new ControllerHelper(_context))
            {
                model = helper.getSaglikHarcamalariIstatistikleri(searchString);
            }
            return View(model);
        }

        public IActionResult SosyalKorumaIstatistikleri(string searchString)
        {
            ViewData["CurrentFilter"] = searchString;
            SosyalKorumaIstatistikleri model = new SosyalKorumaIstatistikleri();
            using (var helper = new ControllerHelper(_context))
            {
                model = helper.getSosyalKorumaIstatistikleri(searchString);
            }
            return View(model);
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

                    row.CreateCell(0).SetCellValue("İşsizlik Oranı");

                    if (issizlikOraniModel.İştekiDurumVeEkonomikFaaliyet.Count() > 0)
                    {
                        i += 5;
                        row = excelSheet.CreateRow(i);

                        row.CreateCell(0).SetCellValue("İşteki durum ve ekonomik faaliyete göre istihdam edilenler");

                        i += 2;

                        row = excelSheet.CreateRow(i);

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

                    }

                    if (issizlikOraniModel.SosyalGüvenlikKuruluşunaKayitlilik.Count() > 0)
                    {
                        i += 5;
                        row = excelSheet.CreateRow(i);

                        row.CreateCell(0).SetCellValue("İstihdam edilenlerin sosyal güvenlik kuruluşuna kayıtlılık durumu");

                        i += 2;
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
                        row.CreateCell(17).SetCellValue("Oran (%) Kadın Kayıt dışı 2019");
                        row.CreateCell(18).SetCellValue("Oran (%) Kadın Kayıt dışı 2020");

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

        public async Task<IActionResult> TuketiciFiyatEndeksiYillikExport(string searchString)
        {
            var memory = new MemoryStream();
            string sFileName = @"TuketiciFiyatEndeksiYillik.xlsx";
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

                    TüketiciFiyatEndeksi tüketiciFiyatEndeksiModel = new TüketiciFiyatEndeksi();
                    using (var helper = new ControllerHelper(_context))
                    {
                        tüketiciFiyatEndeksiModel = helper.getTuketiciFiyatEndeksiYillik(searchString);
                    }

                    IRow row = excelSheet.CreateRow(i);

                    row.CreateCell(0).SetCellValue("Tüketici Fiyat Endeksi Yıllık");

                    if (tüketiciFiyatEndeksiModel.İstatistikiBolgeBirimleriSiniflamasi.Count() > 0)
                    {
                        i += 5;
                        row = excelSheet.CreateRow(i);

                        row.CreateCell(0).SetCellValue("İstatistiki Bölge Birimleri Sınıflamasına göre tüketici fiyat endeksi ve değişim oranları");

                        i += 2;

                        row = excelSheet.CreateRow(i);

                        row.CreateCell(0).SetCellValue("Açıklama");
                        row.CreateCell(1).SetCellValue("Bir onceki aya gore degisim orani	");
                        row.CreateCell(2).SetCellValue("Bir onceki yilin Aralik ayina gore degisim orani	");
                        row.CreateCell(3).SetCellValue("Onceki yilin ayni ayina gore degisim orani	");
                        row.CreateCell(4).SetCellValue("On iki aylik ortalamalara gore degisim orani	");
                        row.CreateCell(5).SetCellValue("Endeks");

                        foreach (var item in tüketiciFiyatEndeksiModel.İstatistikiBolgeBirimleriSiniflamasi)
                        {
                            i++;
                            row = excelSheet.CreateRow(i);
                            row.CreateCell(0).SetCellValue(item.Aciklama);
                            row.CreateCell(1).SetCellValue(item.AylikDegisim);
                            row.CreateCell(2).SetCellValue(item.AralikDegisim);
                            row.CreateCell(3).SetCellValue(item.YillikDegisim);
                            row.CreateCell(4).SetCellValue(item.OrtalamayaGoreDegisim);
                            row.CreateCell(5).SetCellValue(item.Endeks);
                        }

                    }

                    if (tüketiciFiyatEndeksiModel.AnaHarcamaGruplari.Count() > 0)
                    {
                        i += 5;
                        row = excelSheet.CreateRow(i);
                        row.CreateCell(0).SetCellValue("Ana harcama gruplarına göre tüketici fiyat endeksi ve değişim oranları");

                        i += 2;
                        row = excelSheet.CreateRow(i);

                        row.CreateCell(0).SetCellValue("Ana harcama gruplari	");
                        row.CreateCell(1).SetCellValue("Harcama grubu agirliklari	");
                        row.CreateCell(2).SetCellValue("Bir onceki aya gore degisim orani	");
                        row.CreateCell(3).SetCellValue("Bir onceki yilin Aralik ayina gore degisim orani	");
                        row.CreateCell(4).SetCellValue("Bir onceki yilin ayni ayina gore degisim orani	");
                        row.CreateCell(5).SetCellValue("On iki aylik ortalamalara gore degisim orani	");
                        row.CreateCell(6).SetCellValue("Endeks	");

                        foreach (var item in tüketiciFiyatEndeksiModel.AnaHarcamaGruplari)
                        {
                            i++;
                            row = excelSheet.CreateRow(i);
                            row.CreateCell(0).SetCellValue(item.HarcamaGruplari);
                            row.CreateCell(1).SetCellValue(item.Agirliklari);
                            row.CreateCell(2).SetCellValue(item.AylikDegisim);
                            row.CreateCell(3).SetCellValue(item.AralikDegisim);
                            row.CreateCell(4).SetCellValue(item.YillikDegisim);
                            row.CreateCell(5).SetCellValue(item.OrtalamayaGoreDegisim);
                            row.CreateCell(6).SetCellValue(item.Endeks);
                        }
                    }
                    
                    if(tüketiciFiyatEndeksiModel.TüketiciFiyatEndeksiVeDeğişimOranları.Count() > 0)
                    {
                        i += 5;
                        row = excelSheet.CreateRow(i);

                        row.CreateCell(0).SetCellValue("Tüketici fiyat endeksi ve değişim oranları");

                        i += 2;
                        row = excelSheet.CreateRow(i);

                        row.CreateCell(0).SetCellValue("Açıklama");
                        row.CreateCell(1).SetCellValue("Yıl");
                        row.CreateCell(2).SetCellValue("Ocak");
                        row.CreateCell(3).SetCellValue("Subat");
                        row.CreateCell(4).SetCellValue("Mart");
                        row.CreateCell(5).SetCellValue("Nisan");
                        row.CreateCell(6).SetCellValue("Mayis");
                        row.CreateCell(7).SetCellValue("Haziran");
                        row.CreateCell(8).SetCellValue("Temmuz");
                        row.CreateCell(9).SetCellValue("Agustos");
                        row.CreateCell(10).SetCellValue("Eylul");
                        row.CreateCell(11).SetCellValue("Ekim");
                        row.CreateCell(12).SetCellValue("Kasim");
                        row.CreateCell(13).SetCellValue("Aralik");

                        foreach (var item in tüketiciFiyatEndeksiModel.TüketiciFiyatEndeksiVeDeğişimOranları)
                        {
                            i++;
                            row = excelSheet.CreateRow(i);
                            row.CreateCell(0).SetCellValue(item.Aciklama);
                            row.CreateCell(1).SetCellValue(item.Yil);
                            row.CreateCell(2).SetCellValue(item.Ocak);
                            row.CreateCell(3).SetCellValue(item.Subat);
                            row.CreateCell(4).SetCellValue(item.Mart);
                            row.CreateCell(5).SetCellValue(item.Nisan);
                            row.CreateCell(6).SetCellValue(item.Mayis);
                            row.CreateCell(7).SetCellValue(item.Haziran);
                            row.CreateCell(8).SetCellValue(item.Temmuz);
                            row.CreateCell(9).SetCellValue(item.Agustos);
                            row.CreateCell(10).SetCellValue(item.Eylul);
                            row.CreateCell(11).SetCellValue(item.Ekim);
                            row.CreateCell(12).SetCellValue(item.Kasim);
                            row.CreateCell(13).SetCellValue(item.Aralik);
                        }
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
