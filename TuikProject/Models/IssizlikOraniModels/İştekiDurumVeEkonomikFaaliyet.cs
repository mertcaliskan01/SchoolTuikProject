using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TuikProject.Models.IssizlikOraniModels
{
    public class İştekiDurumVeEkonomikFaaliyet
    {
        public int Id { get; set; }
        public string Aciklama { get; set; }
        public string Toplam2019 { get; set; }
        public string Toplam2020 { get; set; }
        public string Erkek2019 { get; set; }
        public string Erkek2020 { get; set; }
        public string Kadin2019 { get; set; }
        public string Kadin2020 { get; set; }
        public string ToplamOran2019 { get; set; }
        public string ToplamOran2020 { get; set; }
        public string ErkekOran2019 { get; set; }
        public string ErkekOran2020 { get; set; }
        public string KadinOran2019 { get; set; }
        public string KadinOran2020 { get; set; }
    }
}
