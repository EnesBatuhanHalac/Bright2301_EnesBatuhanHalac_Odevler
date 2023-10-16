using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BrightAcademieWebApp.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    KategoriAdi = table.Column<string>(type: "TEXT", nullable: false),
                    KategoriAciklamasi = table.Column<string>(type: "TEXT", nullable: false),
                    KategorininAktiflikDurumu = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Settings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FirmaAdi = table.Column<string>(type: "TEXT", nullable: false),
                    FirmaAdresi = table.Column<string>(type: "TEXT", nullable: false),
                    Hakkimizda = table.Column<string>(type: "TEXT", nullable: false),
                    IletisimBilgileri = table.Column<string>(type: "TEXT", nullable: false),
                    SıkSorularSorular = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Settings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    EgitimAdi = table.Column<string>(type: "TEXT", nullable: false),
                    EgitimToplamDersSaati = table.Column<int>(type: "INTEGER", nullable: false),
                    EgitimSuresiAy = table.Column<int>(type: "INTEGER", nullable: false),
                    EgitimBaslangicTarihi = table.Column<DateTime>(type: "TEXT", nullable: false),
                    EgitimPlanlananBitisTarihi = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Aciklama = table.Column<string>(type: "TEXT", nullable: false),
                    EgitiminSeviyesi = table.Column<string>(type: "TEXT", nullable: false),
                    EgitiminKazanimlari = table.Column<string>(type: "TEXT", nullable: false),
                    EgitiminYeri = table.Column<string>(type: "TEXT", nullable: false),
                    EgitiminIcerigi = table.Column<string>(type: "TEXT", nullable: false),
                    EgitiminDegerlendirilmesi = table.Column<string>(type: "TEXT", nullable: false),
                    EgitiminStatusu = table.Column<string>(type: "TEXT", nullable: false),
                    EgitiminAktiflikDurumu = table.Column<bool>(type: "INTEGER", nullable: false),
                    CategoryId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Courses_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Trainers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    EgitmenAdi = table.Column<string>(type: "TEXT", nullable: false),
                    EgitmenSoyAdi = table.Column<string>(type: "TEXT", nullable: false),
                    EgitmenUzmanlikAlani = table.Column<string>(type: "TEXT", nullable: false),
                    EgitmenDeneyim = table.Column<string>(type: "TEXT", nullable: false),
                    EgitmenEgitimBilgileri = table.Column<string>(type: "TEXT", nullable: false),
                    EgitmenDegerlendirmesiYorum = table.Column<string>(type: "TEXT", nullable: false),
                    EgitmenDegerlendirmesiPuan = table.Column<int>(type: "INTEGER", nullable: false),
                    EgitmeninAktiflikDurumu = table.Column<bool>(type: "INTEGER", nullable: false),
                    CourseId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trainers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Trainers_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Trainees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    KursiyerAdi = table.Column<string>(type: "TEXT", nullable: false),
                    KursiyerSoyAdi = table.Column<string>(type: "TEXT", nullable: false),
                    KursiyerEgitimDurumu = table.Column<string>(type: "TEXT", nullable: false),
                    TrainerId = table.Column<int>(type: "INTEGER", nullable: false),
                    CourseId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trainees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Trainees_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Trainees_Trainers_TrainerId",
                        column: x => x.TrainerId,
                        principalTable: "Trainers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "KategoriAciklamasi", "KategoriAdi", "KategorininAktiflikDurumu" },
                values: new object[,]
                {
                    { 1, "FullStack Developer Yetkinlikleri Kazandirir", "Full Stack Development", true },
                    { 2, "FrontEnd Developer Yetkinlikleri Kazandirir", "FrontEnd Development", true },
                    { 3, "BackEnd Development Yetkinlikleri Kazandirir.", "BackEnd Development", true },
                    { 4, "Siber Güvenlik Uzmani Yetistirme Kursu", "SiberGüvenlik", true },
                    { 5, "Mobile Developer Yetistirme Kursu", "Mobile Development", true },
                    { 6, "DevOps Bt Operations", "DevOps", true }
                });

            migrationBuilder.InsertData(
                table: "Settings",
                columns: new[] { "Id", "FirmaAdi", "FirmaAdresi", "Hakkimizda", "IletisimBilgileri", "SıkSorularSorular" },
                values: new object[] { 1, "Bright Academy", "Kuloğlu Mh., Barbaros Blv. Yıldız İş Hanı No:9, 34353 Beşiktaş/İstanbul", "Junior Yazilimci Yetistirmek adina belirli alanlarda kurslar veren bir Kurum", "Telefon:(0212) 381 50 00", "1-) Ne zaman Kuruldunuz? 2-)Kurs Bitiminde Ne olacak? 3-)Kurslarinizin İçerigi Nedir?" });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Aciklama", "CategoryId", "EgitimAdi", "EgitimBaslangicTarihi", "EgitimPlanlananBitisTarihi", "EgitimSuresiAy", "EgitimToplamDersSaati", "EgitiminAktiflikDurumu", "EgitiminDegerlendirilmesi", "EgitiminIcerigi", "EgitiminKazanimlari", "EgitiminSeviyesi", "EgitiminStatusu", "EgitiminYeri" },
                values: new object[,]
                {
                    { 1, "Bu Kurs Sonunda Junior Bir Full Stack Developer Olacaksiniz.", 1, "Full Stack Developer Yetiştirme Kursu", new DateTime(2025, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, 600, true, "Bu Egitim Yazilima Yeni Başlayacak Olan Kişiler icindir.", "C#/ HTML / CSS / BOOTSTRAP/ JAVASCRİPT / ASP.NETCORE MVC/ASP.NETCORE API /REACT ", "Bu egitim Sonunda Front-End Teklonojisini BackEnd Teklonojisini Ve Mobil Teklonojisini Ögrenmiş Olacaksiniz.Ögrendiginiz Programlar ileBir Site ve Mobil Uygulama'nin Tüm Adimlarinda Yer Alabilirsiniz.", "Kolay", "SoftwareDeveloper", "Kuloğlu Mh., Barbaros Blv. Yıldız İş Hanı No:9, 34353 Beşiktaş/İstanbul" },
                    { 2, "Bu Kurs Ortalama Yazilim bilen Siber Güvenlige ilgisi olan kisiler için tasarlanmistir.", 5, "Siber Güvenlik Uzmani Yetistirme Kursu", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, 600, true, "Bu Egitim Yazilimi Orta Seviye Bilen Kişiler İçindir.", "Aircrack-ng,BeEF,Burp Suite Scanner,Cain and Abel,Fern Wifi Cracker", "Bu kurstan Sonra Siber Güvenlik Elemani veya Siber Güvenlik Uzmani olarak işe başlayabilirsiniz.", "Orta", "Siber Security", "Kuloğlu Mh., Barbaros Blv. Yıldız İş Hanı No:9, 34353 Beşiktaş/İstanbul" },
                    { 3, "Bu Kurs Yazilim Uzmanlari İçin Kendilerine Artı Katacaktır.", 3, "BackEnd Geliştirme Kursu", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, 600, true, "Bu Egitim Yazilimi Senior Seviye Yazilima Hakim Kişiler İçindir.", "C#,C++,JAVA,NODEJS,Asp.NetCore Web Api, Asp.NETCore MVC", "Bu kurstan Sonra BackEnd Yazilim Uzmani olarak işe başlayabilirsiniz.", "Zor", "BackEndDevelopment", "Kuloğlu Mh., Barbaros Blv. Yıldız İş Hanı No:9, 34353 Beşiktaş/İstanbul" },
                    { 4, "Bu Kurs Yazilima Başlayacak ve Yazilima İlgisi olan kisiler için tasarlanmistir. FrontEnd Tasarimlari Yapmaniz İçin Ögrenmeniz Gereken Programlari İçerir.", 2, "FrontEndDeveloper Yetistirme Kursu", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, 600, true, "Bu Egitim Yazilima Yeni Başlayan Kişiler İçindir..", "JavaScript,Html,css,Bootstrap", "Bu kurstan Sonra Herhangi Bir Web Uygulamasina Front End Tasarimlarini Uygulama Yetenegi Kazanacaksiniz. ", "Orta", "FrontEnd", "Kuloğlu Mh., Barbaros Blv. Yıldız İş Hanı No:9, 34353 Beşiktaş/İstanbul" },
                    { 5, "Bu Kurs Yazilima Yeni Başlayacak  Ve Mobil Development'a ilgili kisiler için tasarlanmistir.", 4, "Mobile Developer Yetistirme Kursu", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, 600, true, "Bu Egitim Yazilima Yeni Başlayacak Kişiler İçindir.", "React ,Ajax ,NodeJs,TypeScript,Javascript,Html,Css,Flutter", "Bu kurstan Sonra Mobile Developer Olarak İşe Başlayabilirsiniz.Ögrendiginiz Programlar ile Mobil Uygulamalar Tasarlayabilirsiniz.", "Kolay", "Mobile Development", "Kuloğlu Mh., Barbaros Blv. Yıldız İş Hanı No:9, 34353 Beşiktaş/İstanbul" }
                });

            migrationBuilder.InsertData(
                table: "Trainers",
                columns: new[] { "Id", "CourseId", "EgitmenAdi", "EgitmenDegerlendirmesiPuan", "EgitmenDegerlendirmesiYorum", "EgitmenDeneyim", "EgitmenEgitimBilgileri", "EgitmenSoyAdi", "EgitmenUzmanlikAlani", "EgitmeninAktiflikDurumu" },
                values: new object[,]
                {
                    { 1, 1, "Enes", 9, "", "Deneyimli", "ODTÜ Bilgisayar Mühendisligi ve Kodlama Egitimi,MIT California Yapayzeka ", "Uzun", "FullStack Development", true },
                    { 2, 2, "Ali can", 7, "", "Deneyimsiz", "İstanbul Üniversitesi Bilgisayar Mühendisligi ", "Gören", "FrontEnd Development", true },
                    { 3, 3, "EnginNiyazi", 8, "", "Deneyimli", "İstanbul Üniversitesi Bilgisayar Mühendisligi ", "Ergül", "BackEnd Development", true },
                    { 4, 4, "Asli", 8, "", "Deneyimli", "İstanbul Üniversitesi Bilgisayar Mühendisligi ", "Mizrak", "Mobile Development", true },
                    { 5, 5, "Ecem", 5, "", "Deneyimli", "İstanbul Üniversitesi Bilgisayar Mühendisligi ", "Gül", "SiberSecurityDevelopment", true }
                });

            migrationBuilder.InsertData(
                table: "Trainees",
                columns: new[] { "Id", "CourseId", "KursiyerAdi", "KursiyerEgitimDurumu", "KursiyerSoyAdi", "TrainerId" },
                values: new object[,]
                {
                    { 1, 1, "Mucahit", "Lise", "Çetin", 1 },
                    { 2, 1, "Emine", "Üniversite", "Uzun", 1 },
                    { 3, 1, "Sinan", "Yükseklisans", "ÇetinALP", 1 },
                    { 4, 2, "Emine", "Üniversite", "Uzun", 2 },
                    { 5, 2, "Mehmet", "Önlisans", "Uzun", 2 },
                    { 6, 2, "Ali", "Önlisans", "Yerli", 2 },
                    { 7, 3, "Ahmet", "Üniversite", "Uzun", 3 },
                    { 8, 3, "Hasan", "Önlisans", "Uzun", 3 },
                    { 9, 3, "Ömür", "Önlisans", "Yerli", 3 },
                    { 10, 4, "Enes", "Üniversite", "Yerli", 4 },
                    { 11, 4, "Mehmet", "Önlisans", "Yerli", 4 },
                    { 12, 4, "Ahmet", "Önlisans", "Yerli", 4 },
                    { 13, 5, "Emine", "Üniversite", "Kısa", 5 },
                    { 14, 5, "Mehmet", "Önlisans", "Kısa", 5 },
                    { 15, 5, "Ali", "Önlisans", "Keskin", 5 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Courses_CategoryId",
                table: "Courses",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Trainees_CourseId",
                table: "Trainees",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_Trainees_TrainerId",
                table: "Trainees",
                column: "TrainerId");

            migrationBuilder.CreateIndex(
                name: "IX_Trainers_CourseId",
                table: "Trainers",
                column: "CourseId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Settings");

            migrationBuilder.DropTable(
                name: "Trainees");

            migrationBuilder.DropTable(
                name: "Trainers");

            migrationBuilder.DropTable(
                name: "Courses");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
