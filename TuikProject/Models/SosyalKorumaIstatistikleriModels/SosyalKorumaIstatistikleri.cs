using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TuikProject.Models.SosyalKorumaIstatistikleriModels
{
    public class SosyalKorumaIstatistikleri
    {
        public int Id { get; set; }
        public IEnumerable<AyniVeNakdiYardimlarinGruplaraGoreDagilimi> AyniVeNakdiYardimlarinGruplaraGoreDagilimi { get; set; }
        public IEnumerable<GruplaraGoreBrutVeNetSosyalKorumaHarcamaları> GruplaraGoreBrutVeNetSosyalKorumaHarcamaları { get; set; }
        public IEnumerable<SartliVeSartsizYardimlarinGruplaraGoreDagilimi> SartliVeSartsizYardimlarinGruplaraGoreDagilimi { get; set; }
        public IEnumerable<SosyalKorumaGelirlerininTurlerineGore> SosyalKorumaGelirlerininTurlerineGore { get; set; }
        public IEnumerable<SosyalKorumaKapsamindaYardimAlanSayisi> SosyalKorumaKapsamindaYardimAlanSayisi { get; set; }

    }
}
