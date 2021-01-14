using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TuikProject.Models.SaglikHarcamalariIstatistikleriModels
{
    public class SaglikHarcamalariIstatistikleri
    {
        public int Id { get; set; }
        public IEnumerable<SaglikHarcamalarininGenelToplamDagilimi> SaglikHarcamalarininGenelToplamDagilimi { get; set; }
        public IEnumerable<SaglikHizmetiSunucularinaGoreHarcamalar> SaglikHizmetiSunucularinaGoreHarcamalar { get; set; }

    }
}
