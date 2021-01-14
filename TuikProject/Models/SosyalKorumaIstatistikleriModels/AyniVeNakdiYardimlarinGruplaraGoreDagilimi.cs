using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TuikProject.Models.SosyalKorumaIstatistikleriModels
{
    public class AyniVeNakdiYardimlarinGruplaraGoreDagilimi
    {
        public int Id { get; set; }
        public string Aciklama{ get; set; }
        public string ToplamYardim2018 { get; set; }
        public string ToplamYardim2019 { get; set; }
        public string NakdiYardim2018 { get; set; }
        public string NakdiYardim2019 { get; set; }
        public string AyniYardim2018 { get; set; }
        public string AyniYardim2019 { get; set; }
    }
}
