using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TuikProject.Models.CezaInfazKurumuIstatistikleriModels
{
    public class CezaInfazKurumuIstatistikleri
    {
        public int Id { get; set; }

        public IEnumerable<CezaInfazKurumlarıSayıKapasiteBilgileri> CezaInfazKurumlarıSayıKapasiteBilgileri { get; set; }
        public IEnumerable<CezaInfazKurumuCinsiyetStatuUyluk> CezaInfazKurumuCinsiyetStatuUyluk { get; set; }
        public IEnumerable<CezaInfazKurumunaGirdigiAndakiYasGrubunaGore> CezaInfazKurumunaGirdigiAndakiYasGrubunaGore { get; set; }
        public IEnumerable<EgitimDurumunaGoreGirenHukumluler> EgitimDurumunaGoreGirenHukumluler { get; set; }
        public IEnumerable<MedeniDurumaGoreGirenHukumluler> MedeniDurumaGoreGirenHukumluler { get; set; }
        public IEnumerable<SucIslenenYasGrubunaGoreGirenHukumluler> SucIslenenYasGrubunaGoreGirenHukumluler { get; set; }
        public IEnumerable<SucTuruneGoreGirenHukumluler> SucTuruneGoreGirenHukumluler { get; set; }
        public IEnumerable<SucTuruVeEgitimDurumunaGoreGirenHukumluler> SucTuruVeEgitimDurumunaGoreGirenHukumluler { get; set; }
        public IEnumerable<YılIcindeGirenVeCikanHukumluler> YılIcindeGirenVeCikanHukumluler { get; set; }
        public IEnumerable<YuzBinNufusaDusenCezaInfazKurumuNufusu> YuzBinNufusaDusenCezaInfazKurumuNufusu { get; set; }
    }
}
