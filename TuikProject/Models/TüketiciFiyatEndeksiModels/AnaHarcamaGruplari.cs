using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TuikProject.Models.TüketiciFiyatEndeksiModels
{
    public class AnaHarcamaGruplari
    {
        public int Id { get; set; }
        public string HarcamaGruplari { get; set; }
        public string Agirliklari { get; set; }
        public string AylikDegisim { get; set; }
        public string AralikDegisim { get; set; }
        public string YillikDegisim { get; set; }
        public string OrtalamayaGoreDegisim { get; set; }
        public string Endeks { get; set; }
    }
}
