using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using TuikProject.Data;
using TuikProject.Models;
using TuikProject.Models.CezaInfazKurumuIstatistikleriModels;
using TuikProject.Models.IssizlikOraniModels;
using TuikProject.Models.KulturEkonomisiModels;
using TuikProject.Models.SaglikHarcamalariIstatistikleriModels;
using TuikProject.Models.SosyalKorumaIstatistikleriModels;
using TuikProject.Models.TüketiciFiyatEndeksiModels;

namespace TuikProject.Helper
{
    public class ControllerHelper : IDisposable
    {
        private readonly ApplicationDbContext _context;
        private bool disposedValue;
        IssizlikOrani issizlikOraniModel;
        TüketiciFiyatEndeksi tüketiciFiyatEndeksiModel;

        public ControllerHelper(ApplicationDbContext context)
        {
            _context = context;
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
                disposedValue = true;
            }
        }

        public void Dispose()
        {
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }

        public IssizlikOrani getIssizlikOrani(string searchString)
        {
            IssizlikOrani mymodel = new IssizlikOrani();
            try
            {
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
                issizlikOraniModel = mymodel;
            }catch(Exception ex)
            {
                Console.WriteLine("Hata :" + ex);
            }
            return mymodel;
        }


        public TüketiciFiyatEndeksi getTuketiciFiyatEndeksiYillik(string searchString)
        {
            TüketiciFiyatEndeksi mymodel = new TüketiciFiyatEndeksi();
            try
            {
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
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata :" + ex);
            }
            return mymodel;
        }


        public CezaInfazKurumuIstatistikleri getCezaInfazKurumuIstatistikleri(string searchString)
        {
            CezaInfazKurumuIstatistikleri mymodel = new CezaInfazKurumuIstatistikleri();
            try
            {
                using (var helper = new DbHelper(_context))
                {
                    if (!string.IsNullOrEmpty(searchString))
                    {
                        mymodel.CezaInfazKurumlarıSayıKapasiteBilgileri = helper.getCezaInfazKurumlarıSayıKapasiteBilgileri(searchString);
                        mymodel.CezaInfazKurumuCinsiyetStatuUyluk = helper.getCezaInfazKurumuCinsiyetStatuUyluk(searchString);
                        mymodel.CezaInfazKurumunaGirdigiAndakiYasGrubunaGore = helper.getCezaInfazKurumunaGirdigiAndakiYasGrubunaGore(searchString);
                        mymodel.EgitimDurumunaGoreGirenHukumluler = helper.getEgitimDurumunaGoreGirenHukumluler(searchString);
                        mymodel.MedeniDurumaGoreGirenHukumluler = helper.getMedeniDurumaGoreGirenHukumluler(searchString);
                        mymodel.SucIslenenYasGrubunaGoreGirenHukumluler = helper.getSucIslenenYasGrubunaGoreGirenHukumluler(searchString);
                        mymodel.SucTuruneGoreGirenHukumluler = helper.getSucTuruneGoreGirenHukumluler(searchString);
                        mymodel.SucTuruVeEgitimDurumunaGoreGirenHukumluler = helper.getSucTuruVeEgitimDurumunaGoreGirenHukumluler(searchString);
                        mymodel.YılIcindeGirenVeCikanHukumluler = helper.getYılIcindeGirenVeCikanHukumluler(searchString);
                        mymodel.YuzBinNufusaDusenCezaInfazKurumuNufusu = helper.getYuzBinNufusaDusenCezaInfazKurumuNufusu(searchString);
                    }
                    else
                    {
                        mymodel.CezaInfazKurumlarıSayıKapasiteBilgileri = helper.getCezaInfazKurumlarıSayıKapasiteBilgileri();
                        mymodel.CezaInfazKurumuCinsiyetStatuUyluk = helper.getCezaInfazKurumuCinsiyetStatuUyluk();
                        mymodel.CezaInfazKurumunaGirdigiAndakiYasGrubunaGore = helper.getCezaInfazKurumunaGirdigiAndakiYasGrubunaGore();
                        mymodel.EgitimDurumunaGoreGirenHukumluler = helper.getEgitimDurumunaGoreGirenHukumluler();
                        mymodel.MedeniDurumaGoreGirenHukumluler = helper.getMedeniDurumaGoreGirenHukumluler();
                        mymodel.SucIslenenYasGrubunaGoreGirenHukumluler = helper.getSucIslenenYasGrubunaGoreGirenHukumluler();
                        mymodel.SucTuruneGoreGirenHukumluler = helper.getSucTuruneGoreGirenHukumluler();
                        mymodel.SucTuruVeEgitimDurumunaGoreGirenHukumluler = helper.getSucTuruVeEgitimDurumunaGoreGirenHukumluler();
                        mymodel.YılIcindeGirenVeCikanHukumluler = helper.getYılIcindeGirenVeCikanHukumluler();
                        mymodel.YuzBinNufusaDusenCezaInfazKurumuNufusu = helper.getYuzBinNufusaDusenCezaInfazKurumuNufusu();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata :" + ex);
            }
            return mymodel;
        }


        public KulturEkonomisi getKulturEkonomisi(string searchString)
        {
            KulturEkonomisi mymodel = new KulturEkonomisi();
            try
            {
                using (var helper = new DbHelper(_context))
                {
                    if (!string.IsNullOrEmpty(searchString))
                    {
                        mymodel.HarcamaTurlerineGoreHanehalkininHarcamalari = helper.getHarcamaTurlerineGoreHanehalkininHarcamalari(searchString);
                        mymodel.KulturelAlanlaraGoreGenelDevletHarcamasi = helper.getKulturelAlanlaraGoreGenelDevletHarcamasi(searchString);
                        mymodel.KulturelAlanlaraGoreMahalliIdarelerHarcamasi = helper.getKulturelAlanlaraGoreMahalliIdarelerHarcamasi(searchString);
                        mymodel.KulturelAlanlaraGoreMalIhracatVeIthalati = helper.getKulturelAlanlaraGoreMalIhracatVeIthalati(searchString);
                        mymodel.KulturelAlanlaraGoreMerkeziDevletHarcamasi = helper.getKulturelAlanlaraGoreMerkeziDevletHarcamasi(searchString);
                        mymodel.KulturelMalDisTicaretiVeDegisimOrani = helper.getKulturelMalDisTicaretiVeDegisimOrani(searchString);
                        mymodel.KulturelSektorlereGoreBaziTemelGostergeler = helper.getKulturelSektorlereGoreBaziTemelGostergeler(searchString);
                        mymodel.KulturHarcamalari = helper.getKulturHarcamalari(searchString);
                    }
                    else
                    {
                        mymodel.HarcamaTurlerineGoreHanehalkininHarcamalari = helper.getHarcamaTurlerineGoreHanehalkininHarcamalari();
                        mymodel.KulturelAlanlaraGoreGenelDevletHarcamasi = helper.getKulturelAlanlaraGoreGenelDevletHarcamasi();
                        mymodel.KulturelAlanlaraGoreMahalliIdarelerHarcamasi = helper.getKulturelAlanlaraGoreMahalliIdarelerHarcamasi();
                        mymodel.KulturelAlanlaraGoreMalIhracatVeIthalati = helper.getKulturelAlanlaraGoreMalIhracatVeIthalati();
                        mymodel.KulturelAlanlaraGoreMerkeziDevletHarcamasi = helper.getKulturelAlanlaraGoreMerkeziDevletHarcamasi();
                        mymodel.KulturelMalDisTicaretiVeDegisimOrani = helper.getKulturelMalDisTicaretiVeDegisimOrani();
                        mymodel.KulturelSektorlereGoreBaziTemelGostergeler = helper.getKulturelSektorlereGoreBaziTemelGostergeler();
                        mymodel.KulturHarcamalari = helper.getKulturHarcamalari();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata :" + ex);
            }
            return mymodel;
        }



        public SaglikHarcamalariIstatistikleri getSaglikHarcamalariIstatistikleri(string searchString)
        {
            SaglikHarcamalariIstatistikleri mymodel = new SaglikHarcamalariIstatistikleri();
            try
            {
                using (var helper = new DbHelper(_context))
                {
                    if (!string.IsNullOrEmpty(searchString))
                    {
                        mymodel.SaglikHarcamalarininGenelToplamDagilimi = helper.getSaglikHarcamalarininGenelToplamDagilimi(searchString);
                        mymodel.SaglikHizmetiSunucularinaGoreHarcamalar = helper.getSaglikHizmetiSunucularinaGoreHarcamalar(searchString);
                    }
                    else
                    {
                        mymodel.SaglikHarcamalarininGenelToplamDagilimi = helper.getSaglikHarcamalarininGenelToplamDagilimi();
                        mymodel.SaglikHizmetiSunucularinaGoreHarcamalar = helper.getSaglikHizmetiSunucularinaGoreHarcamalar();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata :" + ex);
            }
            return mymodel;
        }

        public SosyalKorumaIstatistikleri getSosyalKorumaIstatistikleri(string searchString)
        {
            SosyalKorumaIstatistikleri mymodel = new SosyalKorumaIstatistikleri();
            try
            {
                using (var helper = new DbHelper(_context))
                {
                    if (!string.IsNullOrEmpty(searchString))
                    {
                        mymodel.AyniVeNakdiYardimlarinGruplaraGoreDagilimi = helper.getAyniVeNakdiYardimlarinGruplaraGoreDagilimi(searchString);
                        mymodel.GruplaraGoreBrutVeNetSosyalKorumaHarcamaları = helper.getGruplaraGoreBrutVeNetSosyalKorumaHarcamaları(searchString);
                        mymodel.SartliVeSartsizYardimlarinGruplaraGoreDagilimi = helper.getSartliVeSartsizYardimlarinGruplaraGoreDagilimi(searchString);
                        mymodel.SosyalKorumaGelirlerininTurlerineGore = helper.getSosyalKorumaGelirlerininTurlerineGore(searchString);
                        mymodel.SosyalKorumaKapsamindaYardimAlanSayisi = helper.getSosyalKorumaKapsamindaYardimAlanSayisi(searchString);
                    }
                    else
                    {
                        mymodel.AyniVeNakdiYardimlarinGruplaraGoreDagilimi = helper.getAyniVeNakdiYardimlarinGruplaraGoreDagilimi();
                        mymodel.GruplaraGoreBrutVeNetSosyalKorumaHarcamaları = helper.getGruplaraGoreBrutVeNetSosyalKorumaHarcamaları();
                        mymodel.SartliVeSartsizYardimlarinGruplaraGoreDagilimi = helper.getSartliVeSartsizYardimlarinGruplaraGoreDagilimi();
                        mymodel.SosyalKorumaGelirlerininTurlerineGore = helper.getSosyalKorumaGelirlerininTurlerineGore();
                        mymodel.SosyalKorumaKapsamindaYardimAlanSayisi = helper.getSosyalKorumaKapsamindaYardimAlanSayisi();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata :" + ex);
            }
            return mymodel;
        }


    }
}
