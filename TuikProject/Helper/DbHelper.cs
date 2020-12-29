using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using TuikProject.Data;
using TuikProject.Models;
using TuikProject.Models.IssizlikOraniModels;
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
            var list = _context.İştekiDurumVeEkonomikFaaliyet.ToList();
            return list;

        }

        public IEnumerable<SosyalGüvenlikKuruluşunaKayitlilik> getSosyalGüvenlikKuruluşunaKayitlilik()
        {
            var list = _context.SosyalGüvenlikKuruluşunaKayitlilik.ToList();

            return list;
        }

        public IEnumerable<İstatistikiBolgeBirimleriSiniflamasi> getİstatistikiBolgeBirimleriSiniflamasi()
        {
            var list = _context.İstatistikiBolgeBirimleriSiniflamasi.ToList();

            return list;
        }
        public IEnumerable<AnaHarcamaGruplari> getAnaHarcamaGruplari()
        {
            var list = _context.AnaHarcamaGruplari.ToList();

            return list;
        }
        public IEnumerable<TüketiciFiyatEndeksiVeDeğişimOranları> getTüketiciFiyatEndeksiVeDeğişimOranları()
        {
            var list = _context.TüketiciFiyatEndeksiVeDeğişimOranları.ToList();

            return list;
        }

    }
}
