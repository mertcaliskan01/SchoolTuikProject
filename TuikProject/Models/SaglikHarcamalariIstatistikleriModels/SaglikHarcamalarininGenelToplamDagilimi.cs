using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TuikProject.Models.SaglikHarcamalariIstatistikleriModels
{
    public class SaglikHarcamalarininGenelToplamDagilimi
    {
        public int Id { get; set; }
        public string Aciklama{ get; set; }
        public string GenelToplam2018 { get; set; }
        public string GenelToplam2019 { get; set; }
        public string Toplam2018 { get; set; }
        public string Toplam2019 { get; set; }
        public string MerkeziDevlet2018 { get; set; }
        public string MerkeziDevlet2019 { get; set; }
        public string MahalliIdareler2018 { get; set; }
        public string MahalliIdareler2019 { get; set; }
        public string SGK2018 { get; set; }
        public string SGK2019 { get; set; }
        public string Toplam22018 { get; set; }
        public string Toplam22019 { get; set; }
        public string Hanehalklari2018 { get; set; }
        public string Hanehalklari2019 { get; set; }
        public string Sigortasirket2018 { get; set; }
        public string Sigortasirket2019 { get; set; }
        public string Diger2018 { get; set; }
        public string Diger2019 { get; set; }
    }
}
