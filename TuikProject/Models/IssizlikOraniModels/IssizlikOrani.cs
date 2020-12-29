using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using TuikProject.Models;

namespace TuikProject.Models.IssizlikOraniModels
{
    public class IssizlikOrani
    {
        public int Id { get; set; }

        public IEnumerable<İştekiDurumVeEkonomikFaaliyet> İştekiDurumVeEkonomikFaaliyet { get; set; }

        public IEnumerable<SosyalGüvenlikKuruluşunaKayitlilik> SosyalGüvenlikKuruluşunaKayitlilik { get; set; }

    }
}
