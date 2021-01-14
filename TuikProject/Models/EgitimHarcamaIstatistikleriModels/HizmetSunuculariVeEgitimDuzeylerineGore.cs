using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TuikProject.Models.EgitimHarcamaIstatistikleriModels
{
    public class HizmetSunuculariVeEgitimDuzeylerineGore
    {
        public int Id { get; set; }
        public string EgitimDuzeyi { get; set; }
        public string Yil { get; set; }
        public string DO_ToplamHarcama { get; set; }
        public string DO_CariHarcama { get; set; }
        public string DO_PersonelHarcama { get; set; }
        public string DO_PersonelOdemeDisiHarcama  { get; set; }
        public string DO_SermayeHarcama { get; set; }
        public string D_ToplamHarcama { get; set; }
        public string D_CariHarcama { get; set; }
        public string D_PersonelHarcama { get; set; }
        public string D_PersonelOdemeDisiHarcama  { get; set; }
        public string D_SermayeHarcama { get; set; }
        public string O_ToplamHarcama { get; set; }
        public string O_CariHarcama { get; set; }
        public string O_PersonelHarcama { get; set; }
        public string O_PersonelOdemeDisiHarcama  { get; set; }
        public string O_SermayeHarcama { get; set; }
        
    }
}
