using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TuikProject.Models;
using TuikProject.Models.CezaInfazKurumuIstatistikleriModels;
using TuikProject.Models.EgitimHarcamaIstatistikleriModels;
using TuikProject.Models.IssizlikOraniModels;
using TuikProject.Models.KulturEkonomisiModels;
using TuikProject.Models.SaglikHarcamalariIstatistikleriModels;
using TuikProject.Models.SosyalKorumaIstatistikleriModels;
using TuikProject.Models.TüketiciFiyatEndeksiModels;

namespace TuikProject.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<İştekiDurumVeEkonomikFaaliyet> İştekiDurumVeEkonomikFaaliyet { get; set; }
        public DbSet<SosyalGüvenlikKuruluşunaKayitlilik> SosyalGüvenlikKuruluşunaKayitlilik { get; set; }

        public DbSet<İstatistikiBolgeBirimleriSiniflamasi> İstatistikiBolgeBirimleriSiniflamasi { get; set; }
        public DbSet<AnaHarcamaGruplari> AnaHarcamaGruplari { get; set; }
        public DbSet<TüketiciFiyatEndeksiVeDeğişimOranları> TüketiciFiyatEndeksiVeDeğişimOranları { get; set; }


        public DbSet<CezaInfazKurumlarıSayıKapasiteBilgileri> CezaInfazKurumlarıSayıKapasiteBilgileri { get; set; }
        public DbSet<CezaInfazKurumuCinsiyetStatuUyluk> CezaInfazKurumuCinsiyetStatuUyluk { get; set; }
        public DbSet<CezaInfazKurumunaGirdigiAndakiYasGrubunaGore> CezaInfazKurumunaGirdigiAndakiYasGrubunaGore { get; set; }
        public DbSet<EgitimDurumunaGoreGirenHukumluler> EgitimDurumunaGoreGirenHukumluler { get; set; }
        public DbSet<MedeniDurumaGoreGirenHukumluler> MedeniDurumaGoreGirenHukumluler { get; set; }
        public DbSet<SucIslenenYasGrubunaGoreGirenHukumluler> SucIslenenYasGrubunaGoreGirenHukumluler { get; set; }
        public DbSet<SucTuruneGoreGirenHukumluler> SucTuruneGoreGirenHukumluler { get; set; }
        public DbSet<SucTuruVeEgitimDurumunaGoreGirenHukumluler> SucTuruVeEgitimDurumunaGoreGirenHukumluler { get; set; }
        public DbSet<YılIcindeGirenVeCikanHukumluler> YılIcindeGirenVeCikanHukumluler { get; set; }
        public DbSet<YuzBinNufusaDusenCezaInfazKurumuNufusu> YuzBinNufusaDusenCezaInfazKurumuNufusu { get; set; }




        public DbSet<EgitimDuzeylerineGoreOgrenciBasina> EgitimDuzeylerineGoreOgrenciBasina { get; set; }
        public DbSet<FinansKaynagiVeEgitimDuzeylerineGore> FinansKaynagiVeEgitimDuzeylerineGore { get; set; }
        public DbSet<HizmetSunuculariVeEgitimDuzeylerineGore> HizmetSunuculariVeEgitimDuzeylerineGore { get; set; }




        public DbSet<HarcamaTurlerineGoreHanehalkininHarcamalari> HarcamaTurlerineGoreHanehalkininHarcamalari { get; set; }
        public DbSet<KulturelAlanlaraGoreGenelDevletHarcamasi> KulturelAlanlaraGoreGenelDevletHarcamasi { get; set; }
        public DbSet<KulturelAlanlaraGoreMahalliIdarelerHarcamasi> KulturelAlanlaraGoreMahalliIdarelerHarcamasi { get; set; }
        public DbSet<KulturelAlanlaraGoreMalIhracatVeIthalati> KulturelAlanlaraGoreMalIhracatVeIthalati { get; set; }
        public DbSet<KulturelAlanlaraGoreMerkeziDevletHarcamasi> KulturelAlanlaraGoreMerkeziDevletHarcamasi { get; set; }
        public DbSet<KulturelMalDisTicaretiVeDegisimOrani> KulturelMalDisTicaretiVeDegisimOrani { get; set; }
        public DbSet<KulturelSektorlereGoreBaziTemelGostergeler> KulturelSektorlereGoreBaziTemelGostergeler { get; set; }
        public DbSet<KulturHarcamalari> KulturHarcamalari { get; set; }




        public DbSet<SaglikHarcamalarininGenelToplamDagilimi> SaglikHarcamalarininGenelToplamDagilimi { get; set; }
        public DbSet<SaglikHizmetiSunucularinaGoreHarcamalar> SaglikHizmetiSunucularinaGoreHarcamalar { get; set; }


        public DbSet<AyniVeNakdiYardimlarinGruplaraGoreDagilimi> AyniVeNakdiYardimlarinGruplaraGoreDagilimi { get; set; }
        public DbSet<GruplaraGoreBrutVeNetSosyalKorumaHarcamaları> GruplaraGoreBrutVeNetSosyalKorumaHarcamaları { get; set; }
        public DbSet<SartliVeSartsizYardimlarinGruplaraGoreDagilimi> SartliVeSartsizYardimlarinGruplaraGoreDagilimi { get; set; }
        public DbSet<SosyalKorumaGelirlerininTurlerineGore> SosyalKorumaGelirlerininTurlerineGore { get; set; }
        public DbSet<SosyalKorumaKapsamindaYardimAlanSayisi> SosyalKorumaKapsamindaYardimAlanSayisi { get; set; }


    }
}
