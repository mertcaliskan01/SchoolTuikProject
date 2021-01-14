using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TuikProject.Models.KulturEkonomisiModels
{
    public class KulturEkonomisi
    {
        public int Id { get; set; }
        public IEnumerable<HarcamaTurlerineGoreHanehalkininHarcamalari> HarcamaTurlerineGoreHanehalkininHarcamalari { get; set; }
        public IEnumerable<KulturelAlanlaraGoreGenelDevletHarcamasi> KulturelAlanlaraGoreGenelDevletHarcamasi { get; set; }
        public IEnumerable<KulturelAlanlaraGoreMahalliIdarelerHarcamasi> KulturelAlanlaraGoreMahalliIdarelerHarcamasi { get; set; }
        public IEnumerable<KulturelAlanlaraGoreMalIhracatVeIthalati> KulturelAlanlaraGoreMalIhracatVeIthalati { get; set; }
        public IEnumerable<KulturelAlanlaraGoreMerkeziDevletHarcamasi> KulturelAlanlaraGoreMerkeziDevletHarcamasi { get; set; }
        public IEnumerable<KulturelMalDisTicaretiVeDegisimOrani> KulturelMalDisTicaretiVeDegisimOrani { get; set; }
        public IEnumerable<KulturelSektorlereGoreBaziTemelGostergeler> KulturelSektorlereGoreBaziTemelGostergeler { get; set; }
        public IEnumerable<KulturHarcamalari> KulturHarcamalari { get; set; }
    }
}
