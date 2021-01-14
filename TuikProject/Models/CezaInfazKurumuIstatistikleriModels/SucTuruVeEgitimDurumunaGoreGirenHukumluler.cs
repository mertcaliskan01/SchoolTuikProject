using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TuikProject.Models.CezaInfazKurumuIstatistikleriModels
{
    public class SucTuruVeEgitimDurumunaGoreGirenHukumluler
    {
        public int Id { get; set; }
        public string Aciklama { get; set; }
        public string Toplam { get; set; }
        public string Okumayazmabilmeyen { get; set; }
        public string Okuryazarokulbitirmeyen { get; set; }
        public string Ilkokul { get; set; }
        public string Ilkogretim { get; set; }
        public string Ortaokuldengimeslekokulu { get; set; }
        public string Lisedengimeslekokulu { get; set; }
        public string Yuksekogretim { get; set; }
        public string Bilinmeyen { get; set; }
    }
}
