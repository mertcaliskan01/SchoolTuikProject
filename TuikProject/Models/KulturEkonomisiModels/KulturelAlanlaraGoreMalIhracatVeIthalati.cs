using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TuikProject.Models.KulturEkonomisiModels
{
    public class KulturelAlanlaraGoreMalIhracatVeIthalati
    {
        public int Id { get; set; }
        public string Aciklama { get; set; }
        public string Yil { get; set; }
        public string Toplam { get; set; }
        public string KulturelMirasArsivKutuphane { get; set; }
        public string KitapYaziliBasin { get; set; }
        public string GorselSanatlar { get; set; }
        public string GosteriSanatlariOrtakKutlama { get; set; }
        public string GorselIsitselMedya { get; set; }
        public string MimarlikTasarimUrunler { get; set; }
        public string ElSanatlar { get; set; }
        
    }
}
