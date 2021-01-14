using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TuikProject.Models.EgitimHarcamaIstatistikleriModels
{
    public class FinansKaynagiVeEgitimDuzeylerineGore
    {
        public int Id { get; set; }
        public string EgitimDuzeyi { get; set; }
        public string Yil { get; set; }
        public string Toplam { get; set; }
        public string ToplamDevlet { get; set; }
        public string Merkezi { get; set; }
        public string Yerel { get; set; }
        public string Ozel { get; set; }
        public string Hanehalklari { get; set; }
        public string OzelTuzelKisilikler { get; set; }
        public string OzeldenHanehalkinatransfer { get; set; }
        public string UluslararasiKaynaklar { get; set; }
        public string DevletHanehalkiTransferler { get; set; }
        
    }
}
