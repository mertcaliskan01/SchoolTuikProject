using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TuikProject.Models.EgitimHarcamaIstatistikleriModels
{
    public class EgitimHarcamaIstatistikleri
    {
        public int Id { get; set; }
        public IEnumerable<EgitimDuzeylerineGoreOgrenciBasina> EgitimDuzeylerineGoreOgrenciBasina { get; set; }
        public IEnumerable<FinansKaynagiVeEgitimDuzeylerineGore> FinansKaynagiVeEgitimDuzeylerineGore { get; set; }
        public IEnumerable<HizmetSunuculariVeEgitimDuzeylerineGore> HizmetSunuculariVeEgitimDuzeylerineGore { get; set; }

    }
}
