using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TuikProject.Models.CezaInfazKurumuIstatistikleriModels
{
    public class SucTuruneGoreGirenHukumluler
    {
        public int Id { get; set; }
        public string Aciklama { get; set; }
        public string SayiToplam { get; set; }
        public string OranToplam { get; set; }
        public string SayiErkek { get; set; }
        public string OranErkek { get; set; }
        public string SayiKadin { get; set; }
        public string OranKadin { get; set; }
    }
}
