using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TuikProject.Models.KulturEkonomisiModels
{
    public class KulturelMalDisTicaretiVeDegisimOrani
    {
        public int Id { get; set; }
        public string Yil { get; set; }
        public string IH_ToplamIhracat { get; set; }
        public string IH_Toplam { get; set; }
        public string IH_AnaMal { get; set; }
        public string IH_IkinciMal { get; set; }
        public string IT_ToplamIthalat { get; set; }
        public string IT_Toplam { get; set; }
        public string IT_AnaMal { get; set; }
        public string IT_IkinciMal { get; set; }
        public string IH_KulturelMalIhracatToplamIhracat { get; set; }
        public string IH_KulturelMalIhracatToplam { get; set; }
        public string IH_KulturelMalIhracatAnaMal { get; set; }
        public string IH_KulturelMalIhracatIkinciMal { get; set; }
        public string IT_KulturelMalIthalatToplamIthalat { get; set; }
        public string IT_KulturelMalIthalatToplam { get; set; }
        public string IT_KulturelMalIthalatAnaMal { get; set; }
        public string IT_KulturelMalIthalatIkinciMal { get; set; }
      
    }
}
