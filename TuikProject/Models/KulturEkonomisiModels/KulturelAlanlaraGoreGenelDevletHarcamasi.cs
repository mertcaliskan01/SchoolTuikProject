using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TuikProject.Models.KulturEkonomisiModels
{
    public class KulturelAlanlaraGoreGenelDevletHarcamasi
    {
        public int Id { get; set; }
        public string KulturelAlanlar { get; set; }
        public string Toplam2018 { get; set; }
        public string Toplam2019 { get; set; }
        public string CariHarcama2018 { get; set; }
        public string CariHarcama2019 { get; set; }
        public string SermayeHarcama2018 { get; set; }
        public string SermayeHarcama2019 { get; set; }
        public string Diger2018 { get; set; }
        public string Diger2019 { get; set; }
        
    }
}
