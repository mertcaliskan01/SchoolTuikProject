using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TuikProject.Models.EgitimHarcamaIstatistikleriModels
{
    public class EgitimDuzeylerineGoreOgrenciBasina
    {
        public int Id { get; set; }
        public string EgitimDuzeyi { get; set; }
        public string Yil { get; set; }
        public string EgitimHarcamasi { get; set; }
        public string OgrenciBasinaHarcamaTL { get; set; }
        public string OgrenciBasinaHarcamaDolar { get; set; }
        
    }
}
