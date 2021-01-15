using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TuikProject.Migrations
{
    public partial class migration123456 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AnaHarcamaGruplari",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HarcamaGruplari = table.Column<string>(nullable: true),
                    Agirliklari = table.Column<string>(nullable: true),
                    AylikDegisim = table.Column<string>(nullable: true),
                    AralikDegisim = table.Column<string>(nullable: true),
                    YillikDegisim = table.Column<string>(nullable: true),
                    OrtalamayaGoreDegisim = table.Column<string>(nullable: true),
                    Endeks = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnaHarcamaGruplari", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AyniVeNakdiYardimlarinGruplaraGoreDagilimi",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Aciklama = table.Column<string>(nullable: true),
                    ToplamYardim2018 = table.Column<string>(nullable: true),
                    ToplamYardim2019 = table.Column<string>(nullable: true),
                    NakdiYardim2018 = table.Column<string>(nullable: true),
                    NakdiYardim2019 = table.Column<string>(nullable: true),
                    AyniYardim2018 = table.Column<string>(nullable: true),
                    AyniYardim2019 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AyniVeNakdiYardimlarinGruplaraGoreDagilimi", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CezaInfazKurumlarıSayıKapasiteBilgileri",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Aciklama = table.Column<string>(nullable: true),
                    Baslik2015 = table.Column<string>(nullable: true),
                    Baslik2016 = table.Column<string>(nullable: true),
                    Baslik2017 = table.Column<string>(nullable: true),
                    Baslik2018 = table.Column<string>(nullable: true),
                    Baslik2019 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CezaInfazKurumlarıSayıKapasiteBilgileri", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CezaInfazKurumuCinsiyetStatuUyluk",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Aciklama = table.Column<string>(nullable: true),
                    Sayi2015 = table.Column<string>(nullable: true),
                    Oran2015 = table.Column<string>(nullable: true),
                    Sayi2016 = table.Column<string>(nullable: true),
                    Oran2016 = table.Column<string>(nullable: true),
                    Sayi2017 = table.Column<string>(nullable: true),
                    Oran2017 = table.Column<string>(nullable: true),
                    Sayi2018 = table.Column<string>(nullable: true),
                    Oran2018 = table.Column<string>(nullable: true),
                    Sayi2019 = table.Column<string>(nullable: true),
                    Oran2019 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CezaInfazKurumuCinsiyetStatuUyluk", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CezaInfazKurumunaGirdigiAndakiYasGrubunaGore",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Aciklama = table.Column<string>(nullable: true),
                    Sayi2015 = table.Column<string>(nullable: true),
                    Oran2015 = table.Column<string>(nullable: true),
                    Sayi2016 = table.Column<string>(nullable: true),
                    Oran2016 = table.Column<string>(nullable: true),
                    Sayi2017 = table.Column<string>(nullable: true),
                    Oran2017 = table.Column<string>(nullable: true),
                    Sayi2018 = table.Column<string>(nullable: true),
                    Oran2018 = table.Column<string>(nullable: true),
                    Sayi2019 = table.Column<string>(nullable: true),
                    Oran2019 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CezaInfazKurumunaGirdigiAndakiYasGrubunaGore", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EgitimDurumunaGoreGirenHukumluler",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Aciklama = table.Column<string>(nullable: true),
                    Baslik2015 = table.Column<string>(nullable: true),
                    Baslik2016 = table.Column<string>(nullable: true),
                    Baslik2017 = table.Column<string>(nullable: true),
                    Baslik2018 = table.Column<string>(nullable: true),
                    Baslik2019 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EgitimDurumunaGoreGirenHukumluler", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GruplaraGoreBrutVeNetSosyalKorumaHarcamaları",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Aciklama = table.Column<string>(nullable: true),
                    Brut2018 = table.Column<string>(nullable: true),
                    Net2019 = table.Column<string>(nullable: true),
                    Brut22018 = table.Column<string>(nullable: true),
                    Net22019 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GruplaraGoreBrutVeNetSosyalKorumaHarcamaları", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HarcamaTurlerineGoreHanehalkininHarcamalari",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HarcamaTuru = table.Column<string>(nullable: true),
                    Harcama2018 = table.Column<string>(nullable: true),
                    Harcama2019 = table.Column<string>(nullable: true),
                    Oran2018 = table.Column<string>(nullable: true),
                    Oran2019 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HarcamaTurlerineGoreHanehalkininHarcamalari", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "İstatistikiBolgeBirimleriSiniflamasi",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Aciklama = table.Column<string>(nullable: true),
                    AylikDegisim = table.Column<string>(nullable: true),
                    AralikDegisim = table.Column<string>(nullable: true),
                    YillikDegisim = table.Column<string>(nullable: true),
                    OrtalamayaGoreDegisim = table.Column<string>(nullable: true),
                    Endeks = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_İstatistikiBolgeBirimleriSiniflamasi", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "İştekiDurumVeEkonomikFaaliyet",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Aciklama = table.Column<string>(nullable: true),
                    Toplam2019 = table.Column<string>(nullable: true),
                    Toplam2020 = table.Column<string>(nullable: true),
                    Erkek2019 = table.Column<string>(nullable: true),
                    Erkek2020 = table.Column<string>(nullable: true),
                    Kadin2019 = table.Column<string>(nullable: true),
                    Kadin2020 = table.Column<string>(nullable: true),
                    ToplamOran2019 = table.Column<string>(nullable: true),
                    ToplamOran2020 = table.Column<string>(nullable: true),
                    ErkekOran2019 = table.Column<string>(nullable: true),
                    ErkekOran2020 = table.Column<string>(nullable: true),
                    KadinOran2019 = table.Column<string>(nullable: true),
                    KadinOran2020 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_İştekiDurumVeEkonomikFaaliyet", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "KulturelAlanlaraGoreGenelDevletHarcamasi",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KulturelAlanlar = table.Column<string>(nullable: true),
                    Toplam2018 = table.Column<string>(nullable: true),
                    Toplam2019 = table.Column<string>(nullable: true),
                    CariHarcama2018 = table.Column<string>(nullable: true),
                    CariHarcama2019 = table.Column<string>(nullable: true),
                    SermayeHarcama2018 = table.Column<string>(nullable: true),
                    SermayeHarcama2019 = table.Column<string>(nullable: true),
                    Diger2018 = table.Column<string>(nullable: true),
                    Diger2019 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KulturelAlanlaraGoreGenelDevletHarcamasi", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "KulturelAlanlaraGoreMahalliIdarelerHarcamasi",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KulturelAlanlar = table.Column<string>(nullable: true),
                    Toplam2018 = table.Column<string>(nullable: true),
                    Toplam2019 = table.Column<string>(nullable: true),
                    CariHarcama2018 = table.Column<string>(nullable: true),
                    CariHarcama2019 = table.Column<string>(nullable: true),
                    SermayeHarcama2018 = table.Column<string>(nullable: true),
                    SermayeHarcama2019 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KulturelAlanlaraGoreMahalliIdarelerHarcamasi", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "KulturelAlanlaraGoreMalIhracatVeIthalati",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Aciklama = table.Column<string>(nullable: true),
                    Yil = table.Column<string>(nullable: true),
                    Toplam = table.Column<string>(nullable: true),
                    KulturelMirasArsivKutuphane = table.Column<string>(nullable: true),
                    KitapYaziliBasin = table.Column<string>(nullable: true),
                    GorselSanatlar = table.Column<string>(nullable: true),
                    GosteriSanatlariOrtakKutlama = table.Column<string>(nullable: true),
                    GorselIsitselMedya = table.Column<string>(nullable: true),
                    MimarlikTasarimUrunler = table.Column<string>(nullable: true),
                    ElSanatlar = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KulturelAlanlaraGoreMalIhracatVeIthalati", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "KulturelAlanlaraGoreMerkeziDevletHarcamasi",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KulturelAlanlar = table.Column<string>(nullable: true),
                    Toplam2018 = table.Column<string>(nullable: true),
                    Toplam2019 = table.Column<string>(nullable: true),
                    CariHarcama2018 = table.Column<string>(nullable: true),
                    CariHarcama2019 = table.Column<string>(nullable: true),
                    SermayeHarcama2018 = table.Column<string>(nullable: true),
                    SermayeHarcama2019 = table.Column<string>(nullable: true),
                    Diger2018 = table.Column<string>(nullable: true),
                    Diger2019 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KulturelAlanlaraGoreMerkeziDevletHarcamasi", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "KulturelMalDisTicaretiVeDegisimOrani",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Yil = table.Column<string>(nullable: true),
                    IH_ToplamIhracat = table.Column<string>(nullable: true),
                    IH_Toplam = table.Column<string>(nullable: true),
                    IH_AnaMal = table.Column<string>(nullable: true),
                    IH_IkinciMal = table.Column<string>(nullable: true),
                    IT_ToplamIthalat = table.Column<string>(nullable: true),
                    IT_Toplam = table.Column<string>(nullable: true),
                    IT_AnaMal = table.Column<string>(nullable: true),
                    IT_IkinciMal = table.Column<string>(nullable: true),
                    IH_KulturelMalIhracatToplamIhracat = table.Column<string>(nullable: true),
                    IH_KulturelMalIhracatToplam = table.Column<string>(nullable: true),
                    IH_KulturelMalIhracatAnaMal = table.Column<string>(nullable: true),
                    IH_KulturelMalIhracatIkinciMal = table.Column<string>(nullable: true),
                    IT_KulturelMalIthalatToplamIthalat = table.Column<string>(nullable: true),
                    IT_KulturelMalIthalatToplam = table.Column<string>(nullable: true),
                    IT_KulturelMalIthalatAnaMal = table.Column<string>(nullable: true),
                    IT_KulturelMalIthalatIkinciMal = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KulturelMalDisTicaretiVeDegisimOrani", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "KulturelSektorlereGoreBaziTemelGostergeler",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KulturelSektorler = table.Column<string>(nullable: true),
                    Yil = table.Column<string>(nullable: true),
                    GirisimSayisi = table.Column<string>(nullable: true),
                    CiroBinTL = table.Column<string>(nullable: true),
                    KatmaDeger = table.Column<string>(nullable: true),
                    CalisanSayisi = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KulturelSektorlereGoreBaziTemelGostergeler", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "KulturHarcamalari",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Aciklama = table.Column<string>(nullable: true),
                    Harcama2018 = table.Column<string>(nullable: true),
                    Harcama2019Mtl = table.Column<string>(nullable: true),
                    Oran2018 = table.Column<string>(nullable: true),
                    Oran2019 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KulturHarcamalari", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MedeniDurumaGoreGirenHukumluler",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Aciklama = table.Column<string>(nullable: true),
                    Sayi2015 = table.Column<string>(nullable: true),
                    Oran2015 = table.Column<string>(nullable: true),
                    Sayi2016 = table.Column<string>(nullable: true),
                    Oran2016 = table.Column<string>(nullable: true),
                    Sayi2017 = table.Column<string>(nullable: true),
                    Oran2017 = table.Column<string>(nullable: true),
                    Sayi2018 = table.Column<string>(nullable: true),
                    Oran2018 = table.Column<string>(nullable: true),
                    Sayi2019 = table.Column<string>(nullable: true),
                    Oran2019 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedeniDurumaGoreGirenHukumluler", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SaglikHarcamalarininGenelToplamDagilimi",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Aciklama = table.Column<string>(nullable: true),
                    GenelToplam2018 = table.Column<string>(nullable: true),
                    GenelToplam2019 = table.Column<string>(nullable: true),
                    Toplam2018 = table.Column<string>(nullable: true),
                    Toplam2019 = table.Column<string>(nullable: true),
                    MerkeziDevlet2018 = table.Column<string>(nullable: true),
                    MerkeziDevlet2019 = table.Column<string>(nullable: true),
                    MahalliIdareler2018 = table.Column<string>(nullable: true),
                    MahalliIdareler2019 = table.Column<string>(nullable: true),
                    SGK2018 = table.Column<string>(nullable: true),
                    SGK2019 = table.Column<string>(nullable: true),
                    Toplam22018 = table.Column<string>(nullable: true),
                    Toplam22019 = table.Column<string>(nullable: true),
                    Hanehalklari2018 = table.Column<string>(nullable: true),
                    Hanehalklari2019 = table.Column<string>(nullable: true),
                    Sigortasirket2018 = table.Column<string>(nullable: true),
                    Sigortasirket2019 = table.Column<string>(nullable: true),
                    Diger2018 = table.Column<string>(nullable: true),
                    Diger2019 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SaglikHarcamalarininGenelToplamDagilimi", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SaglikHizmetiSunucularinaGoreHarcamalar",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Aciklama = table.Column<string>(nullable: true),
                    GenelToplam2018 = table.Column<string>(nullable: true),
                    GenelToplam2019 = table.Column<string>(nullable: true),
                    Toplam2018 = table.Column<string>(nullable: true),
                    Toplam2019 = table.Column<string>(nullable: true),
                    MerkeziDevlet2018 = table.Column<string>(nullable: true),
                    MerkeziDevlet2019 = table.Column<string>(nullable: true),
                    MahalliIdareler2018 = table.Column<string>(nullable: true),
                    MahalliIdareler2019 = table.Column<string>(nullable: true),
                    SGK2018 = table.Column<string>(nullable: true),
                    SGK2019 = table.Column<string>(nullable: true),
                    Toplam22018 = table.Column<string>(nullable: true),
                    Toplam22019 = table.Column<string>(nullable: true),
                    Hanehalklari2018 = table.Column<string>(nullable: true),
                    Hanehalklari2019 = table.Column<string>(nullable: true),
                    Sigortasirket2018 = table.Column<string>(nullable: true),
                    Sigortasirket2019 = table.Column<string>(nullable: true),
                    Diger2018 = table.Column<string>(nullable: true),
                    Diger2019 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SaglikHizmetiSunucularinaGoreHarcamalar", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SartliVeSartsizYardimlarinGruplaraGoreDagilimi",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Aciklama = table.Column<string>(nullable: true),
                    ToplamYardim2018 = table.Column<string>(nullable: true),
                    ToplamYardim2019 = table.Column<string>(nullable: true),
                    SartliYardim2018 = table.Column<string>(nullable: true),
                    SartliYardim2019 = table.Column<string>(nullable: true),
                    SartsizYardim2018 = table.Column<string>(nullable: true),
                    SartsizYardim2019 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SartliVeSartsizYardimlarinGruplaraGoreDagilimi", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SosyalGüvenlikKuruluşunaKayitlilik",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Aciklama = table.Column<string>(nullable: true),
                    ToplamIstihdam2019 = table.Column<string>(nullable: true),
                    ToplamIstihdam2020 = table.Column<string>(nullable: true),
                    ToplamKayitdisi2019 = table.Column<string>(nullable: true),
                    ToplamKayitdisi2020 = table.Column<string>(nullable: true),
                    ToplamKayitdisiOrani2019 = table.Column<string>(nullable: true),
                    ToplamKayitdisiOrani2020 = table.Column<string>(nullable: true),
                    ErkekIstihdam2019 = table.Column<string>(nullable: true),
                    ErkekIstihdam2020 = table.Column<string>(nullable: true),
                    ErkekKayitdisi2019 = table.Column<string>(nullable: true),
                    ErkekKayitdisi2020 = table.Column<string>(nullable: true),
                    ErkekKayitdisiOrani2019 = table.Column<string>(nullable: true),
                    ErkekKayitdisiOrani2020 = table.Column<string>(nullable: true),
                    KadinIstihdam2019 = table.Column<string>(nullable: true),
                    KadinIstihdam2020 = table.Column<string>(nullable: true),
                    KadinKayitdisi2019 = table.Column<string>(nullable: true),
                    KadinKayitdisi2020 = table.Column<string>(nullable: true),
                    KadinKayitdisiOrani2019 = table.Column<string>(nullable: true),
                    KadinKayitdisiOrani2020 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SosyalGüvenlikKuruluşunaKayitlilik", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SosyalKorumaGelirlerininTurlerineGore",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Aciklama = table.Column<string>(nullable: true),
                    Baslik2018 = table.Column<string>(nullable: true),
                    Baslik2019 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SosyalKorumaGelirlerininTurlerineGore", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SosyalKorumaKapsamindaYardimAlanSayisi",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Aciklama = table.Column<string>(nullable: true),
                    Toplam2018 = table.Column<string>(nullable: true),
                    Erkek2018 = table.Column<string>(nullable: true),
                    Kadin2018 = table.Column<string>(nullable: true),
                    Toplam2019 = table.Column<string>(nullable: true),
                    Erkek2019 = table.Column<string>(nullable: true),
                    Kadin2019 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SosyalKorumaKapsamindaYardimAlanSayisi", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SucIslenenYasGrubunaGoreGirenHukumluler",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Aciklama = table.Column<string>(nullable: true),
                    Sayi2015 = table.Column<string>(nullable: true),
                    Oran2015 = table.Column<string>(nullable: true),
                    Sayi2016 = table.Column<string>(nullable: true),
                    Oran2016 = table.Column<string>(nullable: true),
                    Sayi2017 = table.Column<string>(nullable: true),
                    Oran2017 = table.Column<string>(nullable: true),
                    Sayi2018 = table.Column<string>(nullable: true),
                    Oran2018 = table.Column<string>(nullable: true),
                    Sayi2019 = table.Column<string>(nullable: true),
                    Oran2019 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SucIslenenYasGrubunaGoreGirenHukumluler", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SucTuruneGoreGirenHukumluler",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Aciklama = table.Column<string>(nullable: true),
                    SayiToplam = table.Column<string>(nullable: true),
                    OranToplam = table.Column<string>(nullable: true),
                    SayiErkek = table.Column<string>(nullable: true),
                    OranErkek = table.Column<string>(nullable: true),
                    SayiKadin = table.Column<string>(nullable: true),
                    OranKadin = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SucTuruneGoreGirenHukumluler", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SucTuruVeEgitimDurumunaGoreGirenHukumluler",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Aciklama = table.Column<string>(nullable: true),
                    Toplam = table.Column<string>(nullable: true),
                    Okumayazmabilmeyen = table.Column<string>(nullable: true),
                    Okuryazarokulbitirmeyen = table.Column<string>(nullable: true),
                    Ilkokul = table.Column<string>(nullable: true),
                    Ilkogretim = table.Column<string>(nullable: true),
                    Ortaokuldengimeslekokulu = table.Column<string>(nullable: true),
                    Lisedengimeslekokulu = table.Column<string>(nullable: true),
                    Yuksekogretim = table.Column<string>(nullable: true),
                    Bilinmeyen = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SucTuruVeEgitimDurumunaGoreGirenHukumluler", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TüketiciFiyatEndeksiVeDeğişimOranları",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Aciklama = table.Column<string>(nullable: true),
                    Yil = table.Column<string>(nullable: true),
                    Ocak = table.Column<string>(nullable: true),
                    Subat = table.Column<string>(nullable: true),
                    Mart = table.Column<string>(nullable: true),
                    Nisan = table.Column<string>(nullable: true),
                    Mayis = table.Column<string>(nullable: true),
                    Haziran = table.Column<string>(nullable: true),
                    Temmuz = table.Column<string>(nullable: true),
                    Agustos = table.Column<string>(nullable: true),
                    Eylul = table.Column<string>(nullable: true),
                    Ekim = table.Column<string>(nullable: true),
                    Kasim = table.Column<string>(nullable: true),
                    Aralik = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TüketiciFiyatEndeksiVeDeğişimOranları", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "YılIcindeGirenVeCikanHukumluler",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Aciklama = table.Column<string>(nullable: true),
                    Sayi2015 = table.Column<string>(nullable: true),
                    Oran2015 = table.Column<string>(nullable: true),
                    Sayi2016 = table.Column<string>(nullable: true),
                    Oran2016 = table.Column<string>(nullable: true),
                    Sayi2017 = table.Column<string>(nullable: true),
                    Oran2017 = table.Column<string>(nullable: true),
                    Sayi2018 = table.Column<string>(nullable: true),
                    Oran2018 = table.Column<string>(nullable: true),
                    Sayi2019 = table.Column<string>(nullable: true),
                    Oran2019 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_YılIcindeGirenVeCikanHukumluler", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "YuzBinNufusaDusenCezaInfazKurumuNufusu",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Aciklama = table.Column<string>(nullable: true),
                    Baslik2015 = table.Column<string>(nullable: true),
                    Baslik2016 = table.Column<string>(nullable: true),
                    Baslik2017 = table.Column<string>(nullable: true),
                    Baslik2018 = table.Column<string>(nullable: true),
                    Baslik2019 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_YuzBinNufusaDusenCezaInfazKurumuNufusu", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    Name = table.Column<string>(maxLength: 128, nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AnaHarcamaGruplari");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "AyniVeNakdiYardimlarinGruplaraGoreDagilimi");

            migrationBuilder.DropTable(
                name: "CezaInfazKurumlarıSayıKapasiteBilgileri");

            migrationBuilder.DropTable(
                name: "CezaInfazKurumuCinsiyetStatuUyluk");

            migrationBuilder.DropTable(
                name: "CezaInfazKurumunaGirdigiAndakiYasGrubunaGore");

            migrationBuilder.DropTable(
                name: "EgitimDurumunaGoreGirenHukumluler");

            migrationBuilder.DropTable(
                name: "GruplaraGoreBrutVeNetSosyalKorumaHarcamaları");

            migrationBuilder.DropTable(
                name: "HarcamaTurlerineGoreHanehalkininHarcamalari");

            migrationBuilder.DropTable(
                name: "İstatistikiBolgeBirimleriSiniflamasi");

            migrationBuilder.DropTable(
                name: "İştekiDurumVeEkonomikFaaliyet");

            migrationBuilder.DropTable(
                name: "KulturelAlanlaraGoreGenelDevletHarcamasi");

            migrationBuilder.DropTable(
                name: "KulturelAlanlaraGoreMahalliIdarelerHarcamasi");

            migrationBuilder.DropTable(
                name: "KulturelAlanlaraGoreMalIhracatVeIthalati");

            migrationBuilder.DropTable(
                name: "KulturelAlanlaraGoreMerkeziDevletHarcamasi");

            migrationBuilder.DropTable(
                name: "KulturelMalDisTicaretiVeDegisimOrani");

            migrationBuilder.DropTable(
                name: "KulturelSektorlereGoreBaziTemelGostergeler");

            migrationBuilder.DropTable(
                name: "KulturHarcamalari");

            migrationBuilder.DropTable(
                name: "MedeniDurumaGoreGirenHukumluler");

            migrationBuilder.DropTable(
                name: "SaglikHarcamalarininGenelToplamDagilimi");

            migrationBuilder.DropTable(
                name: "SaglikHizmetiSunucularinaGoreHarcamalar");

            migrationBuilder.DropTable(
                name: "SartliVeSartsizYardimlarinGruplaraGoreDagilimi");

            migrationBuilder.DropTable(
                name: "SosyalGüvenlikKuruluşunaKayitlilik");

            migrationBuilder.DropTable(
                name: "SosyalKorumaGelirlerininTurlerineGore");

            migrationBuilder.DropTable(
                name: "SosyalKorumaKapsamindaYardimAlanSayisi");

            migrationBuilder.DropTable(
                name: "SucIslenenYasGrubunaGoreGirenHukumluler");

            migrationBuilder.DropTable(
                name: "SucTuruneGoreGirenHukumluler");

            migrationBuilder.DropTable(
                name: "SucTuruVeEgitimDurumunaGoreGirenHukumluler");

            migrationBuilder.DropTable(
                name: "TüketiciFiyatEndeksiVeDeğişimOranları");

            migrationBuilder.DropTable(
                name: "YılIcindeGirenVeCikanHukumluler");

            migrationBuilder.DropTable(
                name: "YuzBinNufusaDusenCezaInfazKurumuNufusu");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
