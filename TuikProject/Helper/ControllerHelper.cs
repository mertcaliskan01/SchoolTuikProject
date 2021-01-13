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
using TuikProject.Models.IssizlikOraniModels;
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


    }
}
