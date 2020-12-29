using System;
using System.Collections.Generic;
using TuikProject.Models.TüketiciFiyatEndeksiModels;

namespace TuikProject.Models.TüketiciFiyatEndeksiModels

{
    public class TüketiciFiyatEndeksi
    {
        public int Id { get; set; }

        public IEnumerable<İstatistikiBolgeBirimleriSiniflamasi> İstatistikiBolgeBirimleriSiniflamasi { get; set; }
        public IEnumerable<AnaHarcamaGruplari> AnaHarcamaGruplari { get; set; }
        public IEnumerable<TüketiciFiyatEndeksiVeDeğişimOranları> TüketiciFiyatEndeksiVeDeğişimOranları { get; set; }
    }
}
