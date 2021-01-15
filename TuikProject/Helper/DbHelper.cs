using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
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
    public class DbHelper : IDisposable
    {
        private readonly ApplicationDbContext _context;
        private bool disposedValue;

        public DbHelper(ApplicationDbContext context)
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

        public IEnumerable<İştekiDurumVeEkonomikFaaliyet> getİştekiDurumVeEkonomikFaaliyet()
        {
            return _context.İştekiDurumVeEkonomikFaaliyet.ToList();
        }

        public IEnumerable<İştekiDurumVeEkonomikFaaliyet> getİştekiDurumVeEkonomikFaaliyet(string searchString)
        {
            return _context.İştekiDurumVeEkonomikFaaliyet.Where(s => s.Aciklama.Contains(searchString)).ToList();
        }

        public IEnumerable<SosyalGüvenlikKuruluşunaKayitlilik> getSosyalGüvenlikKuruluşunaKayitlilik()
        {
            return _context.SosyalGüvenlikKuruluşunaKayitlilik.ToList();
        }
        public IEnumerable<SosyalGüvenlikKuruluşunaKayitlilik> getSosyalGüvenlikKuruluşunaKayitlilik(string searchString)
        {
            return _context.SosyalGüvenlikKuruluşunaKayitlilik.Where(s => s.Aciklama.Contains(searchString)).ToList();
        }

        public IEnumerable<İstatistikiBolgeBirimleriSiniflamasi> getİstatistikiBolgeBirimleriSiniflamasi()
        {
            return _context.İstatistikiBolgeBirimleriSiniflamasi.ToList();
        }
        public IEnumerable<İstatistikiBolgeBirimleriSiniflamasi> getİstatistikiBolgeBirimleriSiniflamasi(string searchString)
        {
            return _context.İstatistikiBolgeBirimleriSiniflamasi.Where(s => s.Aciklama.Contains(searchString)).ToList();
        }
        public IEnumerable<AnaHarcamaGruplari> getAnaHarcamaGruplari()
        {
            return _context.AnaHarcamaGruplari.ToList();
        }
        public IEnumerable<AnaHarcamaGruplari> getAnaHarcamaGruplari(string searchString)
        {
            return _context.AnaHarcamaGruplari.Where(s => s.HarcamaGruplari.Contains(searchString)).ToList();
        }
        public IEnumerable<TüketiciFiyatEndeksiVeDeğişimOranları> getTüketiciFiyatEndeksiVeDeğişimOranları()
        {
            return _context.TüketiciFiyatEndeksiVeDeğişimOranları.ToList();
        }
        public IEnumerable<TüketiciFiyatEndeksiVeDeğişimOranları> getTüketiciFiyatEndeksiVeDeğişimOranları(string searchString)
        {
            return _context.TüketiciFiyatEndeksiVeDeğişimOranları.Where(s => s.Aciklama.Contains(searchString)).ToList();
        }


        public IEnumerable<CezaInfazKurumlarıSayıKapasiteBilgileri> getCezaInfazKurumlarıSayıKapasiteBilgileri(string searchString)
        {
            return _context.CezaInfazKurumlarıSayıKapasiteBilgileri.Where(s => s.Aciklama.Contains(searchString)).ToList();
        }
        public IEnumerable<CezaInfazKurumuCinsiyetStatuUyluk> getCezaInfazKurumuCinsiyetStatuUyluk(string searchString)
        {
            return _context.CezaInfazKurumuCinsiyetStatuUyluk.Where(s => s.Aciklama.Contains(searchString)).ToList();
        }
        public IEnumerable<CezaInfazKurumunaGirdigiAndakiYasGrubunaGore> getCezaInfazKurumunaGirdigiAndakiYasGrubunaGore(string searchString)
        {
            return _context.CezaInfazKurumunaGirdigiAndakiYasGrubunaGore.Where(s => s.Aciklama.Contains(searchString)).ToList();
        }
        public IEnumerable<EgitimDurumunaGoreGirenHukumluler> getEgitimDurumunaGoreGirenHukumluler(string searchString)
        {
            return _context.EgitimDurumunaGoreGirenHukumluler.Where(s => s.Aciklama.Contains(searchString)).ToList();
        }
        public IEnumerable<MedeniDurumaGoreGirenHukumluler> getMedeniDurumaGoreGirenHukumluler(string searchString)
        {
            return _context.MedeniDurumaGoreGirenHukumluler.Where(s => s.Aciklama.Contains(searchString)).ToList();
        }
        public IEnumerable<SucIslenenYasGrubunaGoreGirenHukumluler> getSucIslenenYasGrubunaGoreGirenHukumluler(string searchString)
        {
            return _context.SucIslenenYasGrubunaGoreGirenHukumluler.Where(s => s.Aciklama.Contains(searchString)).ToList();
        }
        public IEnumerable<SucTuruneGoreGirenHukumluler> getSucTuruneGoreGirenHukumluler(string searchString)
        {
            return _context.SucTuruneGoreGirenHukumluler.Where(s => s.Aciklama.Contains(searchString)).ToList();
        }
        public IEnumerable<SucTuruVeEgitimDurumunaGoreGirenHukumluler> getSucTuruVeEgitimDurumunaGoreGirenHukumluler(string searchString)
        {
            return _context.SucTuruVeEgitimDurumunaGoreGirenHukumluler.Where(s => s.Aciklama.Contains(searchString)).ToList();
        }
        public IEnumerable<YılIcindeGirenVeCikanHukumluler> getYılIcindeGirenVeCikanHukumluler(string searchString)
        {
            return _context.YılIcindeGirenVeCikanHukumluler.Where(s => s.Aciklama.Contains(searchString)).ToList();
        }
        public IEnumerable<YuzBinNufusaDusenCezaInfazKurumuNufusu> getYuzBinNufusaDusenCezaInfazKurumuNufusu(string searchString)
        {
            return _context.YuzBinNufusaDusenCezaInfazKurumuNufusu.Where(s => s.Aciklama.Contains(searchString)).ToList();
        }

        public IEnumerable<CezaInfazKurumlarıSayıKapasiteBilgileri> getCezaInfazKurumlarıSayıKapasiteBilgileri()
        {
            return _context.CezaInfazKurumlarıSayıKapasiteBilgileri.ToList();
        }
        public IEnumerable<CezaInfazKurumuCinsiyetStatuUyluk> getCezaInfazKurumuCinsiyetStatuUyluk()
        {
            return _context.CezaInfazKurumuCinsiyetStatuUyluk.ToList();
        }
        public IEnumerable<CezaInfazKurumunaGirdigiAndakiYasGrubunaGore> getCezaInfazKurumunaGirdigiAndakiYasGrubunaGore()
        {
            return _context.CezaInfazKurumunaGirdigiAndakiYasGrubunaGore.ToList();
        }
        public IEnumerable<EgitimDurumunaGoreGirenHukumluler> getEgitimDurumunaGoreGirenHukumluler()
        {
            return _context.EgitimDurumunaGoreGirenHukumluler.ToList();
        }
        public IEnumerable<MedeniDurumaGoreGirenHukumluler> getMedeniDurumaGoreGirenHukumluler()
        {
            return _context.MedeniDurumaGoreGirenHukumluler.ToList();
        }
        public IEnumerable<SucIslenenYasGrubunaGoreGirenHukumluler> getSucIslenenYasGrubunaGoreGirenHukumluler()
        {
            return _context.SucIslenenYasGrubunaGoreGirenHukumluler.ToList();
        }
        public IEnumerable<SucTuruneGoreGirenHukumluler> getSucTuruneGoreGirenHukumluler()
        {
            return _context.SucTuruneGoreGirenHukumluler.ToList();
        }
        public IEnumerable<SucTuruVeEgitimDurumunaGoreGirenHukumluler> getSucTuruVeEgitimDurumunaGoreGirenHukumluler()
        {
            return _context.SucTuruVeEgitimDurumunaGoreGirenHukumluler.ToList();
        }
        public IEnumerable<YılIcindeGirenVeCikanHukumluler> getYılIcindeGirenVeCikanHukumluler()
        {
            return _context.YılIcindeGirenVeCikanHukumluler.ToList();
        }
        public IEnumerable<YuzBinNufusaDusenCezaInfazKurumuNufusu> getYuzBinNufusaDusenCezaInfazKurumuNufusu()
        {
            return _context.YuzBinNufusaDusenCezaInfazKurumuNufusu.ToList();
        }




        public IEnumerable<HarcamaTurlerineGoreHanehalkininHarcamalari> getHarcamaTurlerineGoreHanehalkininHarcamalari(string searchString)//
        {
            return _context.HarcamaTurlerineGoreHanehalkininHarcamalari.Where(s => s.HarcamaTuru.Contains(searchString)).ToList();
        }
        public IEnumerable<KulturelAlanlaraGoreGenelDevletHarcamasi> getKulturelAlanlaraGoreGenelDevletHarcamasi(string searchString)
        {
            return _context.KulturelAlanlaraGoreGenelDevletHarcamasi.Where(s => s.KulturelAlanlar.Contains(searchString)).ToList();
        }
        public IEnumerable<KulturelAlanlaraGoreMahalliIdarelerHarcamasi> getKulturelAlanlaraGoreMahalliIdarelerHarcamasi(string searchString)
        {
            return _context.KulturelAlanlaraGoreMahalliIdarelerHarcamasi.Where(s => s.KulturelAlanlar.Contains(searchString)).ToList();
        }
        public IEnumerable<KulturelAlanlaraGoreMalIhracatVeIthalati> getKulturelAlanlaraGoreMalIhracatVeIthalati(string searchString)
        {
            return _context.KulturelAlanlaraGoreMalIhracatVeIthalati.Where(s => s.Aciklama.Contains(searchString)).ToList();
        }
        public IEnumerable<KulturelAlanlaraGoreMerkeziDevletHarcamasi> getKulturelAlanlaraGoreMerkeziDevletHarcamasi(string searchString)
        {
            return _context.KulturelAlanlaraGoreMerkeziDevletHarcamasi.Where(s => s.KulturelAlanlar.Contains(searchString)).ToList();
        }
        public IEnumerable<KulturelMalDisTicaretiVeDegisimOrani> getKulturelMalDisTicaretiVeDegisimOrani(string searchString)
        {
            return _context.KulturelMalDisTicaretiVeDegisimOrani.Where(s => s.Yil.Contains(searchString)).ToList();
        }
        public IEnumerable<KulturelSektorlereGoreBaziTemelGostergeler> getKulturelSektorlereGoreBaziTemelGostergeler(string searchString)
        {
            return _context.KulturelSektorlereGoreBaziTemelGostergeler.Where(s => s.KulturelSektorler.Contains(searchString)).ToList();
        }
        public IEnumerable<KulturHarcamalari> getKulturHarcamalari(string searchString)
        {
            return _context.KulturHarcamalari.Where(s => s.Aciklama.Contains(searchString)).ToList();
        }//
        public IEnumerable<HarcamaTurlerineGoreHanehalkininHarcamalari> getHarcamaTurlerineGoreHanehalkininHarcamalari()
        {
            return _context.HarcamaTurlerineGoreHanehalkininHarcamalari.ToList();
        }
        public IEnumerable<KulturelAlanlaraGoreGenelDevletHarcamasi> getKulturelAlanlaraGoreGenelDevletHarcamasi()
        {
            return _context.KulturelAlanlaraGoreGenelDevletHarcamasi.ToList();
        }
        public IEnumerable<KulturelAlanlaraGoreMahalliIdarelerHarcamasi> getKulturelAlanlaraGoreMahalliIdarelerHarcamasi()
        {
            return _context.KulturelAlanlaraGoreMahalliIdarelerHarcamasi.ToList();
        }
        public IEnumerable<KulturelAlanlaraGoreMalIhracatVeIthalati> getKulturelAlanlaraGoreMalIhracatVeIthalati()
        {
            return _context.KulturelAlanlaraGoreMalIhracatVeIthalati.ToList();
        }
        public IEnumerable<KulturelAlanlaraGoreMerkeziDevletHarcamasi> getKulturelAlanlaraGoreMerkeziDevletHarcamasi()
        {
            return _context.KulturelAlanlaraGoreMerkeziDevletHarcamasi.ToList();
        }
        public IEnumerable<KulturelMalDisTicaretiVeDegisimOrani> getKulturelMalDisTicaretiVeDegisimOrani()
        {
            return _context.KulturelMalDisTicaretiVeDegisimOrani.ToList();
        }
        public IEnumerable<KulturelSektorlereGoreBaziTemelGostergeler> getKulturelSektorlereGoreBaziTemelGostergeler()
        {
            return _context.KulturelSektorlereGoreBaziTemelGostergeler.ToList();
        }
        public IEnumerable<KulturHarcamalari> getKulturHarcamalari()
        {
            return _context.KulturHarcamalari.ToList();
        }







        public IEnumerable<SaglikHarcamalarininGenelToplamDagilimi> getSaglikHarcamalarininGenelToplamDagilimi(string searchString)
        {
            return _context.SaglikHarcamalarininGenelToplamDagilimi.Where(s => s.Aciklama.Contains(searchString)).ToList();
        }
        public IEnumerable<SaglikHizmetiSunucularinaGoreHarcamalar> getSaglikHizmetiSunucularinaGoreHarcamalar(string searchString)
        {
            return _context.SaglikHizmetiSunucularinaGoreHarcamalar.Where(s => s.Aciklama.Contains(searchString)).ToList();
        }
        public IEnumerable<SaglikHarcamalarininGenelToplamDagilimi> getSaglikHarcamalarininGenelToplamDagilimi()
        {
            return _context.SaglikHarcamalarininGenelToplamDagilimi.ToList();
        }
        public IEnumerable<SaglikHizmetiSunucularinaGoreHarcamalar> getSaglikHizmetiSunucularinaGoreHarcamalar()
        {
            return _context.SaglikHizmetiSunucularinaGoreHarcamalar.ToList();
        }


        public IEnumerable<AyniVeNakdiYardimlarinGruplaraGoreDagilimi> getAyniVeNakdiYardimlarinGruplaraGoreDagilimi(string searchString)
        {
            return _context.AyniVeNakdiYardimlarinGruplaraGoreDagilimi.Where(s => s.Aciklama.Contains(searchString)).ToList();
        }
        public IEnumerable<GruplaraGoreBrutVeNetSosyalKorumaHarcamaları> getGruplaraGoreBrutVeNetSosyalKorumaHarcamaları(string searchString)
        {
            return _context.GruplaraGoreBrutVeNetSosyalKorumaHarcamaları.Where(s => s.Aciklama.Contains(searchString)).ToList();
        }
        public IEnumerable<SartliVeSartsizYardimlarinGruplaraGoreDagilimi> getSartliVeSartsizYardimlarinGruplaraGoreDagilimi(string searchString)
        {
            return _context.SartliVeSartsizYardimlarinGruplaraGoreDagilimi.Where(s => s.Aciklama.Contains(searchString)).ToList();
        }
        public IEnumerable<SosyalKorumaGelirlerininTurlerineGore> getSosyalKorumaGelirlerininTurlerineGore(string searchString)
        {
            return _context.SosyalKorumaGelirlerininTurlerineGore.Where(s => s.Aciklama.Contains(searchString)).ToList();
        }
        public IEnumerable<SosyalKorumaKapsamindaYardimAlanSayisi> getSosyalKorumaKapsamindaYardimAlanSayisi(string searchString)
        {
            return _context.SosyalKorumaKapsamindaYardimAlanSayisi.Where(s => s.Aciklama.Contains(searchString)).ToList();
        }

        public IEnumerable<AyniVeNakdiYardimlarinGruplaraGoreDagilimi> getAyniVeNakdiYardimlarinGruplaraGoreDagilimi()
        {
            return _context.AyniVeNakdiYardimlarinGruplaraGoreDagilimi.ToList();
        }
        public IEnumerable<GruplaraGoreBrutVeNetSosyalKorumaHarcamaları> getGruplaraGoreBrutVeNetSosyalKorumaHarcamaları()
        {
            return _context.GruplaraGoreBrutVeNetSosyalKorumaHarcamaları.ToList();
        }
        public IEnumerable<SartliVeSartsizYardimlarinGruplaraGoreDagilimi> getSartliVeSartsizYardimlarinGruplaraGoreDagilimi()
        {
            return _context.SartliVeSartsizYardimlarinGruplaraGoreDagilimi.ToList();
        }
        public IEnumerable<SosyalKorumaGelirlerininTurlerineGore> getSosyalKorumaGelirlerininTurlerineGore()
        {
            return _context.SosyalKorumaGelirlerininTurlerineGore.ToList();
        }
        public IEnumerable<SosyalKorumaKapsamindaYardimAlanSayisi> getSosyalKorumaKapsamindaYardimAlanSayisi()
        {
            return _context.SosyalKorumaKapsamindaYardimAlanSayisi.ToList();
        }


    }
}
