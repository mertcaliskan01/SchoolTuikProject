using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using TuikProject.Data;
using TuikProject.Helper;
using TuikProject.Models.IssizlikOraniModels;
using TuikProject.Models.TüketiciFiyatEndeksiModels;
using Xunit;

namespace TuikProjectXUnitTest
{
    public class UnitTest1
    {


        [Fact]
        public void DbHelper_GetÝþtekiDurumVeEkonomikFaaliyet()
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

                // Assert
                Assert.NotNull(result);
                Assert.False(result.Count().Equals(0));
            }

        }

        [Fact]
        public void DbHelper_GetSosyalGüvenlikKuruluþunaKayitlilik()
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

                // Assert
                Assert.NotNull(result);
                Assert.False(result.Count().Equals(0));
            }

        }

        [Fact]
        public void DbHelper_GetÝstatistikiBolgeBirimleriSiniflamasi()
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

                // Assert
                Assert.NotNull(result);
                Assert.False(result.Count().Equals(0));
            }

        }


        [Fact]
        public void DbHelper_GetAnaHarcamaGruplari()
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>().UseInMemoryDatabase(databaseName: "TuikDb3").Options;

            using (var context = new ApplicationDbContext(options))
            {
                var controller = new DbHelper(context);

                var anaHarcamaGruplari = Enumerable.Range(1, 10)
                    .Select(i => new AnaHarcamaGruplari { Id = i, Agirliklari = $"ExampleData{i}" });
                context.AnaHarcamaGruplari.AddRange(anaHarcamaGruplari);
                int changed = context.SaveChanges();

                // Act
                var result = controller.getAnaHarcamaGruplari();

                // Assert
                Assert.NotNull(result);
                Assert.False(result.Count().Equals(0));
            }

        }


        [Fact]
        public void DbHelper_GetTüketiciFiyatEndeksiVeDeðiþimOranlarý()
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

                // Assert
                Assert.NotNull(result);
                Assert.False(result.Count().Equals(0));
            }

        }
    }
}
