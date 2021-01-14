using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TuikProject.Models.SosyalKorumaIstatistikleriModels
{
    public class SartliVeSartsizYardimlarinGruplaraGoreDagilimi
    {
        public int Id { get; set; }
        public string Aciklama{ get; set; }
        public string ToplamYardim2018 { get; set; }
        public string ToplamYardim2019 { get; set; }
        public string SartliYardim2018 { get; set; }
        public string SartliYardim2019 { get; set; }
        public string SartsizYardim2018 { get; set; }
        public string SartsizYardim2019 { get; set; }
    }
}
