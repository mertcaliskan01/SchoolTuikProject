using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StudentSystemWeb.Models
{
    public class IssizlikOrani
    {
        public int Id { get; set; }

        [Display(Name = "Toplam 2019")]
        public string Toplam2019 { get; set; }

        [Display(Name = "Toplam 2020")]
        public string Toplam2020 { get; set; }

        [Display(Name = "Erkek 2019")]
        public string Erkek2019 { get; set; }

        [Display(Name = "Erkek 2020")]
        public string Erkek2020 { get; set; }

        [Display(Name = "Kadın 2019")]
        public string Kadın2019 { get; set; }

        [Display(Name = "Kadın 2020")]
        public string Kadın2020 { get; set; }

        [Display(Name = "Toplam Oran 2019")]
        public string ToplamOran2019 { get; set; }

        [Display(Name = "Toplam Oran 2020")]
        public string ToplamOran2020 { get; set; }

        [Display(Name = "Erkek Oran 2019")]
        public string ErkekOran2019 { get; set; }

        [Display(Name = "Erkek Oran 2020")]
        public string ErkekOran2020 { get; set; }

        [Display(Name = "Kadın Oran 2019")]
        public string KadınOran2019 { get; set; }

        [Display(Name = "Kadın Oran 2020")]
        public string KadınOran2020 { get; set; }

        [Display(Name = "Açıklama")]
        public string Aciklama { get; set; }
    }
}
