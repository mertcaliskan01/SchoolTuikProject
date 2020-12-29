using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using TuikProject.Data;
using TuikProject.Helper;
using TuikProject.Models.IssizlikOraniModels;
using TuikProject.Models.T�keticiFiyatEndeksiModels;
using Xunit;

namespace TuikProjectXUnitTest
{
    public class UnitTest1
    {


        [Fact]
        public void DbHelper_Get��tekiDurumVeEkonomikFaaliyet()
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

                // Assert
                Assert.NotNull(result);
                Assert.False(result.Count().Equals(0));
            }

        }

        [Fact]
        public void DbHelper_GetSosyalG�venlikKurulu�unaKayitlilik()
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

                // Assert
                Assert.NotNull(result);
                Assert.False(result.Count().Equals(0));
            }

        }

        [Fact]
        public void DbHelper_Get�statistikiBolgeBirimleriSiniflamasi()
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
        public void DbHelper_GetT�keticiFiyatEndeksiVeDe�i�imOranlar�()
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

                // Assert
                Assert.NotNull(result);
                Assert.False(result.Count().Equals(0));
            }

        }
    }
}
