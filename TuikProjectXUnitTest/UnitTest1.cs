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
using TuikProject.Models.T�keticiFiyatEndeksiModels;
using Xunit;

namespace TuikProjectXUnitTest
{
    public class UnitTest1
    {
        [Fact]
        public void CezaInfazKurumuIstatistikleri_CezaInfazKurumlar�Say�KapasiteBilgileri()
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>().UseInMemoryDatabase(databaseName: "TuikDb3").Options;

            using (var context = new ApplicationDbContext(options))
            {
                var controller = new DbHelper(context);

                var model = Enumerable.Range(1, 10)
                    .Select(i => new CezaInfazKurumlar�Say�KapasiteBilgileri { Id = i, Aciklama = $"ExampleData{i}" });
                context.CezaInfazKurumlar�Say�KapasiteBilgileri.AddRange(model);
                int changed = context.SaveChanges();

                // Act
                var result = controller.getCezaInfazKurumlar�Say�KapasiteBilgileri();
                var resultSearch = controller.getCezaInfazKurumlar�Say�KapasiteBilgileri("ExampleData");

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
        public void IssizlikOrani_Get��tekiDurumVeEkonomikFaaliyet()
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>().UseInMemoryDatabase(databaseName: "TuikDb3").Options;

            using (var context = new ApplicationDbContext(options))
            {
                var controller = new DbHelper(context);

                var ��tekiDurumVeEkonomikFaaliyet = Enumerable.Range(1, 10)
                    .Select(i => new ��tekiDurumVeEkonomikFaaliyet { Id = i, Aciklama = $"ExampleData{i}" });
                context.��tekiDurumVeEkonomikFaaliyet.AddRange(��tekiDurumVeEkonomikFaaliyet);
                int changed = context.SaveChanges();

                // Act
                var result = controller.get��tekiDurumVeEkonomikFaaliyet();
                var resultSearch = controller.get��tekiDurumVeEkonomikFaaliyet("ExampleData");

                // Assert
                Assert.NotNull(result);
                Assert.False(result.Count().Equals(0));
                Assert.NotNull(resultSearch);
                Assert.True(resultSearch.Count().Equals(10));
            }

        }

        [Fact]
        public void IssizlikOrani_GetSosyalG�venlikKurulu�unaKayitlilik()
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>().UseInMemoryDatabase(databaseName: "TuikDb3").Options;

            using (var context = new ApplicationDbContext(options))
            {
                var controller = new DbHelper(context);

                var SosyalG�venlikKurulu�unaKayitlilik = Enumerable.Range(1, 10)
                    .Select(i => new SosyalG�venlikKurulu�unaKayitlilik { Id = i, Aciklama = $"ExampleData{i}" });
                context.SosyalG�venlikKurulu�unaKayitlilik.AddRange(SosyalG�venlikKurulu�unaKayitlilik);
                int changed = context.SaveChanges();

                // Act
                var result = controller.getSosyalG�venlikKurulu�unaKayitlilik();
                var resultSearch = controller.getSosyalG�venlikKurulu�unaKayitlilik("ExampleData");

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
        public void SosyalKorumaIstatistikleri_GruplaraGoreBrutVeNetSosyalKorumaHarcamalar�()
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>().UseInMemoryDatabase(databaseName: "TuikDb3").Options;

            using (var context = new ApplicationDbContext(options))
            {
                var controller = new DbHelper(context);

                var model = Enumerable.Range(1, 10)
                    .Select(i => new GruplaraGoreBrutVeNetSosyalKorumaHarcamalar� { Id = i, Aciklama = $"ExampleData{i}" });
                context.GruplaraGoreBrutVeNetSosyalKorumaHarcamalar�.AddRange(model);
                int changed = context.SaveChanges();

                // Act
                var result = controller.getGruplaraGoreBrutVeNetSosyalKorumaHarcamalar�();
                var resultSearch = controller.getGruplaraGoreBrutVeNetSosyalKorumaHarcamalar�("ExampleData");

                // Assert
                Assert.NotNull(result);
                Assert.False(result.Count().Equals(0));
                Assert.NotNull(resultSearch);
                Assert.True(resultSearch.Count().Equals(10));
            }

        }




        [Fact]
        public void T�keticiFiyatEndeksi_�statistikiBolgeBirimleriSiniflamasi()
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>().UseInMemoryDatabase(databaseName: "TuikDb3").Options;

            using (var context = new ApplicationDbContext(options))
            {
                var controller = new DbHelper(context);

                var istatistikiBolgeBirimleriSiniflamasi = Enumerable.Range(1, 10)
                    .Select(i => new �statistikiBolgeBirimleriSiniflamasi { Id = i, Aciklama = $"ExampleData{i}" });
                context.�statistikiBolgeBirimleriSiniflamasi.AddRange(istatistikiBolgeBirimleriSiniflamasi);
                int changed = context.SaveChanges();

                // Act
                var result = controller.get�statistikiBolgeBirimleriSiniflamasi();
                var resultSearch = controller.get�statistikiBolgeBirimleriSiniflamasi("ExampleData");

                // Assert
                Assert.NotNull(result);
                Assert.False(result.Count().Equals(0));
                Assert.NotNull(resultSearch);
                Assert.True(resultSearch.Count().Equals(10));
            }

        }

        [Fact]
        public void T�keticiFiyatEndeksi_AnaHarcamaGruplari()
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
        public void T�keticiFiyatEndeksi_T�keticiFiyatEndeksiVeDe�i�imOranlar�()
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>().UseInMemoryDatabase(databaseName: "TuikDb3").Options;

            using (var context = new ApplicationDbContext(options))
            {
                var controller = new DbHelper(context);

                var t�keticiFiyatEndeksiVeDe�i�imOranlar� = Enumerable.Range(1, 10)
                    .Select(i => new T�keticiFiyatEndeksiVeDe�i�imOranlar� { Id = i, Aciklama = $"ExampleData{i}" });
                context.T�keticiFiyatEndeksiVeDe�i�imOranlar�.AddRange(t�keticiFiyatEndeksiVeDe�i�imOranlar�);
                int changed = context.SaveChanges();

                // Act
                var result = controller.getT�keticiFiyatEndeksiVeDe�i�imOranlar�();
                var resultSearch = controller.getT�keticiFiyatEndeksiVeDe�i�imOranlar�("ExampleData");

                // Assert
                Assert.NotNull(result);
                Assert.False(result.Count().Equals(0));
                Assert.NotNull(resultSearch);
                Assert.True(resultSearch.Count().Equals(10));
            }
        }
    }
}
