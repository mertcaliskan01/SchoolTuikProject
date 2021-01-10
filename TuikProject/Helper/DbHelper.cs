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

    }
}
