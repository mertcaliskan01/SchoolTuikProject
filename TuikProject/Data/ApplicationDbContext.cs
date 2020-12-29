using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TuikProject.Models;
using TuikProject.Models.IssizlikOraniModels;
using TuikProject.Models.TüketiciFiyatEndeksiModels;

namespace TuikProject.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<İştekiDurumVeEkonomikFaaliyet> İştekiDurumVeEkonomikFaaliyet { get; set; }
        public DbSet<SosyalGüvenlikKuruluşunaKayitlilik> SosyalGüvenlikKuruluşunaKayitlilik { get; set; }

        public DbSet<İstatistikiBolgeBirimleriSiniflamasi> İstatistikiBolgeBirimleriSiniflamasi { get; set; }
        public DbSet<AnaHarcamaGruplari> AnaHarcamaGruplari { get; set; }
        public DbSet<TüketiciFiyatEndeksiVeDeğişimOranları> TüketiciFiyatEndeksiVeDeğişimOranları { get; set; }
    }
}
