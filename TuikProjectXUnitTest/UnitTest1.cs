using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using TuikProject.Data;
using TuikProject.Helper;
using TuikProject.Models.CezaInfazKurumuIstatistikleriModels;
using TuikProject.Models.IssizlikOraniModels;
using TuikProject.Models.KulturEkonomisiModels;
using TuikProject.Models.SaglikHarcamalariIstatistikleriModels;
using TuikProject.Models.SosyalKorumaIstatistikleriModels;
using TuikProject.Models.TüketiciFiyatEndeksiModels;
using Xunit;

namespace TuikProjectXUnitTest
{
    public class UnitTest1
    {
        [Fact]
        public void CezaInfazKurumuIstatistikleri_CezaInfazKurumlarýSayýKapasiteBilgileri()
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>().UseInMemoryDatabase(databaseName: "TuikDb3").Options;

            using (var context = new ApplicationDbContext(options))
            {
                var controller = new DbHelper(context);

                var model = Enumerable.Range(1, 10)
                    .Select(i => new CezaInfazKurumlarýSayýKapasiteBilgileri { Id = i, Aciklama = $"ExampleData{i}" });
                context.CezaInfazKurumlarýSayýKapasiteBilgileri.AddRange(model);
                int changed = context.SaveChanges();

                // Act
                var result = controller.getCezaInfazKurumlarýSayýKapasiteBilgileri();
                var resultSearch = controller.getCezaInfazKurumlarýSayýKapasiteBilgileri("ExampleData");

                // Assert
                Assert.NotNull(result);
                Assert.False(result.Count().Equals(0));
                Assert.NotNull(resultSearch);
                Assert.True(resultSearch.Count().Equals(10));
            }

        }

        [Fact]
        public void CezaInfazKurumuIstatistikleri_CezaInfazKurumuCinsiyetStatuUyluk()
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>().UseInMemoryDatabase(databaseName: "TuikDb3").Options;

            using (var context = new ApplicationDbContext(options))
            {
                var controller = new DbHelper(context);

                var model = Enumerable.Range(1, 10)
                    .Select(i => new CezaInfazKurumuCinsiyetStatuUyluk { Id = i, Aciklama = $"ExampleData{i}" });
                context.CezaInfazKurumuCinsiyetStatuUyluk.AddRange(model);
                int changed = context.SaveChanges();

                // Act
                var result = controller.getCezaInfazKurumuCinsiyetStatuUyluk();
                var resultSearch = controller.getCezaInfazKurumuCinsiyetStatuUyluk("ExampleData");

                // Assert
                Assert.NotNull(result);
                Assert.False(result.Count().Equals(0));
                Assert.NotNull(resultSearch);
                Assert.True(resultSearch.Count().Equals(10));
            }

        }




        [Fact]
        public void IssizlikOrani_GetÝþtekiDurumVeEkonomikFaaliyet()
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>().UseInMemoryDatabase(databaseName: "TuikDb3").Options;

            using (var context = new ApplicationDbContext(options))
            {
                var controller = new DbHelper(context);

                var ÝþtekiDurumVeEkonomikFaaliyet = Enumerable.Range(1, 10)
                    .Select(i => new ÝþtekiDurumVeEkonomikFaaliyet { Id = i, Aciklama = $"ExampleData{i}" });
                context.ÝþtekiDurumVeEkonomikFaaliyet.AddRange(ÝþtekiDurumVeEkonomikFaaliyet);
                int changed = context.SaveChanges();

                // Act
                var result = controller.getÝþtekiDurumVeEkonomikFaaliyet();
                var resultSearch = controller.getÝþtekiDurumVeEkonomikFaaliyet("ExampleData");

                // Assert
                Assert.NotNull(result);
                Assert.False(result.Count().Equals(0));
                Assert.NotNull(resultSearch);
                Assert.True(resultSearch.Count().Equals(10));
            }

        }

        [Fact]
        public void IssizlikOrani_GetSosyalGüvenlikKuruluþunaKayitlilik()
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>().UseInMemoryDatabase(databaseName: "TuikDb3").Options;

            using (var context = new ApplicationDbContext(options))
            {
                var controller = new DbHelper(context);

                var SosyalGüvenlikKuruluþunaKayitlilik = Enumerable.Range(1, 10)
                    .Select(i => new SosyalGüvenlikKuruluþunaKayitlilik { Id = i, Aciklama = $"ExampleData{i}" });
                context.SosyalGüvenlikKuruluþunaKayitlilik.AddRange(SosyalGüvenlikKuruluþunaKayitlilik);
                int changed = context.SaveChanges();

                // Act
                var result = controller.getSosyalGüvenlikKuruluþunaKayitlilik();
                var resultSearch = controller.getSosyalGüvenlikKuruluþunaKayitlilik("ExampleData");

                // Assert
                Assert.NotNull(result);
                Assert.False(result.Count().Equals(0));
                Assert.NotNull(resultSearch);
                Assert.True(resultSearch.Count().Equals(10));
            }

        }




        [Fact]
        public void KulturEkonomisi_HarcamaTurlerineGoreHanehalkininHarcamalari()
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>().UseInMemoryDatabase(databaseName: "TuikDb3").Options;

            using (var context = new ApplicationDbContext(options))
            {
                var controller = new DbHelper(context);

                var model = Enumerable.Range(1, 10)
                    .Select(i => new HarcamaTurlerineGoreHanehalkininHarcamalari { Id = i, HarcamaTuru = $"ExampleData{i}" });
                context.HarcamaTurlerineGoreHanehalkininHarcamalari.AddRange(model);
                int changed = context.SaveChanges();

                // Act
                var result = controller.getHarcamaTurlerineGoreHanehalkininHarcamalari();
                var resultSearch = controller.getHarcamaTurlerineGoreHanehalkininHarcamalari("ExampleData");

                // Assert
                Assert.NotNull(result);
                Assert.False(result.Count().Equals(0));
                Assert.NotNull(resultSearch);
                Assert.True(resultSearch.Count().Equals(10));
            }

        }

        [Fact]
        public void KulturEkonomisi_KulturelAlanlaraGoreGenelDevletHarcamasi()
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>().UseInMemoryDatabase(databaseName: "TuikDb3").Options;

            using (var context = new ApplicationDbContext(options))
            {
                var controller = new DbHelper(context);

                var model = Enumerable.Range(1, 10)
                    .Select(i => new KulturelAlanlaraGoreGenelDevletHarcamasi { Id = i, KulturelAlanlar = $"ExampleData{i}" });
                context.KulturelAlanlaraGoreGenelDevletHarcamasi.AddRange(model);
                int changed = context.SaveChanges();

                // Act
                var result = controller.getKulturelAlanlaraGoreGenelDevletHarcamasi();
                var resultSearch = controller.getKulturelAlanlaraGoreGenelDevletHarcamasi("ExampleData");

                // Assert
                Assert.NotNull(result);
                Assert.False(result.Count().Equals(0));
                Assert.NotNull(resultSearch);
                Assert.True(resultSearch.Count().Equals(10));
            }

        }




        [Fact]
        public void SaglikHarcamalariIstatistikleri_SaglikHarcamalarininGenelToplamDagilimi()
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>().UseInMemoryDatabase(databaseName: "TuikDb3").Options;

            using (var context = new ApplicationDbContext(options))
            {
                var controller = new DbHelper(context);

                var model = Enumerable.Range(1, 10)
                    .Select(i => new SaglikHarcamalarininGenelToplamDagilimi { Id = i, Aciklama = $"ExampleData{i}" });
                context.SaglikHarcamalarininGenelToplamDagilimi.AddRange(model);
                int changed = context.SaveChanges();

                // Act
                var result = controller.getSaglikHarcamalarininGenelToplamDagilimi();
                var resultSearch = controller.getSaglikHarcamalarininGenelToplamDagilimi("ExampleData");

                // Assert
                Assert.NotNull(result);
                Assert.False(result.Count().Equals(0));
                Assert.NotNull(resultSearch);
                Assert.True(resultSearch.Count().Equals(10));
            }

        }

        [Fact]
        public void SaglikHarcamalariIstatistikleri_SaglikHizmetiSunucularinaGoreHarcamalar()
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>().UseInMemoryDatabase(databaseName: "TuikDb3").Options;

            using (var context = new ApplicationDbContext(options))
            {
                var controller = new DbHelper(context);

                var model = Enumerable.Range(1, 10)
                    .Select(i => new SaglikHizmetiSunucularinaGoreHarcamalar { Id = i, Aciklama = $"ExampleData{i}" });
                context.SaglikHizmetiSunucularinaGoreHarcamalar.AddRange(model);
                int changed = context.SaveChanges();

                // Act
                var result = controller.getSaglikHizmetiSunucularinaGoreHarcamalar();
                var resultSearch = controller.getSaglikHizmetiSunucularinaGoreHarcamalar("ExampleData");

                // Assert
                Assert.NotNull(result);
                Assert.False(result.Count().Equals(0));
                Assert.NotNull(resultSearch);
                Assert.True(resultSearch.Count().Equals(10));
            }

        }




        [Fact]
        public void SosyalKorumaIstatistikleri_AyniVeNakdiYardimlarinGruplaraGoreDagilimi()
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>().UseInMemoryDatabase(databaseName: "TuikDb3").Options;

            using (var context = new ApplicationDbContext(options))
            {
                var controller = new DbHelper(context);

                var model = Enumerable.Range(1, 10)
                    .Select(i => new AyniVeNakdiYardimlarinGruplaraGoreDagilimi { Id = i, Aciklama = $"ExampleData{i}" });
                context.AyniVeNakdiYardimlarinGruplaraGoreDagilimi.AddRange(model);
                int changed = context.SaveChanges();

                // Act
                var result = controller.getAyniVeNakdiYardimlarinGruplaraGoreDagilimi();
                var resultSearch = controller.getAyniVeNakdiYardimlarinGruplaraGoreDagilimi("ExampleData");

                // Assert
                Assert.NotNull(result);
                Assert.False(result.Count().Equals(0));
                Assert.NotNull(resultSearch);
                Assert.True(resultSearch.Count().Equals(10));
            }

        }

        [Fact]
        public void SosyalKorumaIstatistikleri_GruplaraGoreBrutVeNetSosyalKorumaHarcamalarý()
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>().UseInMemoryDatabase(databaseName: "TuikDb3").Options;

            using (var context = new ApplicationDbContext(options))
            {
                var controller = new DbHelper(context);

                var model = Enumerable.Range(1, 10)
                    .Select(i => new GruplaraGoreBrutVeNetSosyalKorumaHarcamalarý { Id = i, Aciklama = $"ExampleData{i}" });
                context.GruplaraGoreBrutVeNetSosyalKorumaHarcamalarý.AddRange(model);
                int changed = context.SaveChanges();

                // Act
                var result = controller.getGruplaraGoreBrutVeNetSosyalKorumaHarcamalarý();
                var resultSearch = controller.getGruplaraGoreBrutVeNetSosyalKorumaHarcamalarý("ExampleData");

                // Assert
                Assert.NotNull(result);
                Assert.False(result.Count().Equals(0));
                Assert.NotNull(resultSearch);
                Assert.True(resultSearch.Count().Equals(10));
            }

        }




        [Fact]
        public void TüketiciFiyatEndeksi_ÝstatistikiBolgeBirimleriSiniflamasi()
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>().UseInMemoryDatabase(databaseName: "TuikDb3").Options;

            using (var context = new ApplicationDbContext(options))
            {
                var controller = new DbHelper(context);

                var istatistikiBolgeBirimleriSiniflamasi = Enumerable.Range(1, 10)
                    .Select(i => new ÝstatistikiBolgeBirimleriSiniflamasi { Id = i, Aciklama = $"ExampleData{i}" });
                context.ÝstatistikiBolgeBirimleriSiniflamasi.AddRange(istatistikiBolgeBirimleriSiniflamasi);
                int changed = context.SaveChanges();

                // Act
                var result = controller.getÝstatistikiBolgeBirimleriSiniflamasi();
                var resultSearch = controller.getÝstatistikiBolgeBirimleriSiniflamasi("ExampleData");

                // Assert
                Assert.NotNull(result);
                Assert.False(result.Count().Equals(0));
                Assert.NotNull(resultSearch);
                Assert.True(resultSearch.Count().Equals(10));
            }

        }

        [Fact]
        public void TüketiciFiyatEndeksi_AnaHarcamaGruplari()
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>().UseInMemoryDatabase(databaseName: "TuikDb3").Options;

            using (var context = new ApplicationDbContext(options))
            {
                var controller = new DbHelper(context);

                var anaHarcamaGruplari = Enumerable.Range(1, 10)
                    .Select(i => new AnaHarcamaGruplari { Id = i, HarcamaGruplari = $"ExampleData{i}" });
                context.AnaHarcamaGruplari.AddRange(anaHarcamaGruplari);
                int changed = context.SaveChanges();

                // Act
                var result = controller.getAnaHarcamaGruplari();
                var resultSearch = controller.getAnaHarcamaGruplari("ExampleData");

                // Assert
                Assert.NotNull(result);
                Assert.False(result.Count().Equals(0));
                Assert.NotNull(resultSearch);
                Assert.True(resultSearch.Count().Equals(10));
            }

        }

        [Fact]
        public void TüketiciFiyatEndeksi_TüketiciFiyatEndeksiVeDeðiþimOranlarý()
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>().UseInMemoryDatabase(databaseName: "TuikDb3").Options;

            using (var context = new ApplicationDbContext(options))
            {
                var controller = new DbHelper(context);

                var tüketiciFiyatEndeksiVeDeðiþimOranlarý = Enumerable.Range(1, 10)
                    .Select(i => new TüketiciFiyatEndeksiVeDeðiþimOranlarý { Id = i, Aciklama = $"ExampleData{i}" });
                context.TüketiciFiyatEndeksiVeDeðiþimOranlarý.AddRange(tüketiciFiyatEndeksiVeDeðiþimOranlarý);
                int changed = context.SaveChanges();

                // Act
                var result = controller.getTüketiciFiyatEndeksiVeDeðiþimOranlarý();
                var resultSearch = controller.getTüketiciFiyatEndeksiVeDeðiþimOranlarý("ExampleData");

                // Assert
                Assert.NotNull(result);
                Assert.False(result.Count().Equals(0));
                Assert.NotNull(resultSearch);
                Assert.True(resultSearch.Count().Equals(10));
            }
        }
    }
}
