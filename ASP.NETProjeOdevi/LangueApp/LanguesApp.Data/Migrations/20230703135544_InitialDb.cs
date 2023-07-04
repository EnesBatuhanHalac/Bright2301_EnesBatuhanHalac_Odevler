using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LanguesApp.Data.Migrations
{
    public partial class InitialDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Langues",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    About = table.Column<string>(type: "TEXT", maxLength: 400, nullable: true),
                    CreatedBy = table.Column<string>(type: "TEXT", nullable: false),
                    ModifiedBy = table.Column<string>(type: "TEXT", nullable: true),
                    DeletedBy = table.Column<string>(type: "TEXT", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    IsDeleted = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Langues", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Teachers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FullName = table.Column<string>(type: "TEXT", nullable: false),
                    Age = table.Column<int>(type: "INTEGER", nullable: false),
                    About = table.Column<string>(type: "TEXT", maxLength: 250, nullable: false),
                    Url = table.Column<string>(type: "TEXT", nullable: true),
                    ImageUrl = table.Column<string>(type: "TEXT", nullable: false),
                    Price = table.Column<decimal>(type: "TEXT", nullable: false),
                    Country = table.Column<string>(type: "TEXT", nullable: true),
                    CreatedBy = table.Column<string>(type: "TEXT", nullable: false),
                    ModifiedBy = table.Column<string>(type: "TEXT", nullable: true),
                    DeletedBy = table.Column<string>(type: "TEXT", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    IsDeleted = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teachers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LangueTeachers",
                columns: table => new
                {
                    LangueId = table.Column<int>(type: "INTEGER", nullable: false),
                    TeacherId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LangueTeachers", x => new { x.TeacherId, x.LangueId });
                    table.ForeignKey(
                        name: "FK_LangueTeachers_Langues_LangueId",
                        column: x => x.LangueId,
                        principalTable: "Langues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LangueTeachers_Teachers_TeacherId",
                        column: x => x.TeacherId,
                        principalTable: "Teachers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Langues",
                columns: new[] { "Id", "About", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "IsDeleted", "ModifiedBy", "ModifiedDate", "Name" },
                values: new object[] { 1, "ilk olarak 5. yüzyılda İngiltere'de ortaya çıkmış, modern zamanlarda ise küresel bir lingua franca haline gelmiş Batı Cermen dili. İngilizce günümüzde Birleşik Krallık, Amerika Birleşik Devletleri, Karayipler, Avustralya, İrlanda, Kanada ve Yeni Zelanda'da yaşayan kişilerin çoğunluğunun anadilini oluşturmaktadır. İkinci dil ve resmî dil olarak dünya genelinde, özellikle İngiliz Milletler Topluluğu üyeleri ve çok sayıda uluslararası örgüt tarafından kullanılmaktadır.", "Admin", new DateTime(2023, 7, 3, 16, 55, 44, 650, DateTimeKind.Local).AddTicks(94), null, null, false, null, null, "İngilizce" });

            migrationBuilder.InsertData(
                table: "Langues",
                columns: new[] { "Id", "About", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "IsDeleted", "ModifiedBy", "ModifiedDate", "Name" },
                values: new object[] { 2, "Almanca (Deutsch; Almanca telaffuz: [dɔʏtʃ]), Hint-Avrupa dillerinin Cermen dilleri koluna bağlıdır ve dünyanın yaygın lisanlarından biridir. Avrupa Birliği'nin resmî dillerinden biri ve en çok konuşulanıdır. Özellikle Almanya, Avusturya, Lihtenştayn, Lüksemburg, İsviçre'nin büyük bölümü, İtalya'nın Güney Tirol bölümü, Belçika'nın doğu kantonları, Polonya ve Romanya'nın kimi bölgeleri ve Fransa'nın Alsas-Loren bölgesinde konuşulmaktadır. Almanca içinde Fransız kelime kökenli sözcükler taşır. Almanca, eski dönemlerde Türkçede Slav dilleri ile benzer şekilde Nemçece olarak adlandırılmıştır.", "Admin", new DateTime(2023, 7, 3, 16, 55, 44, 650, DateTimeKind.Local).AddTicks(96), null, null, false, null, null, "Almanca" });

            migrationBuilder.InsertData(
                table: "Langues",
                columns: new[] { "Id", "About", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "IsDeleted", "ModifiedBy", "ModifiedDate", "Name" },
                values: new object[] { 3, "Rusça, Beyaz Rusça ve Ukraynaca ile birlikte Hint-Avrupa dil ailesinin Slav Dilleri grubunun Doğu Slav Dilleri alt grubuna girer. 20. yüzyılda politik açıdan önemli bir dil olan Rusça, Birleşmiş Milletlerin resmi dillerinden biridir. Rusça dünya üzerinde en çok konuşulan 7. dildir.Rusça Kiril alfabesini kullanır. Çünkü Latin harfleri Rus dilindeki tüm sesleri ifade etmek için yeterli değildir.[13] Rusçada vurgu çok önemlidir. Rusça sözcüklerde vurgunun belli bir yeri yoktur.[14] DolayısıyӀa sözcükleri öğrenirken vurguyu ve telaffuzu doğru öğrenmek önemlidir. Rusça kelime okunuş vurgu bulunduğu yere bağlı olarak değişebilmektedir", "Admin", new DateTime(2023, 7, 3, 16, 55, 44, 650, DateTimeKind.Local).AddTicks(98), null, null, false, null, null, "Rusca" });

            migrationBuilder.InsertData(
                table: "Langues",
                columns: new[] { "Id", "About", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "IsDeleted", "ModifiedBy", "ModifiedDate", "Name" },
                values: new object[] { 4, " Sümerlerin anadili. Güney Mezopotamya'da MÖ 4000 yılında konuşuluyordu. MÖ 2000'li yılların başlarında yerini konuşma dili olarak Akadcaya bıraktı, ancak Mezopotamya'da MS 1. yüzyıla kadar kutsal, şölensel, edebî ve bilimsel bir dil olarak kullanılmaya devam etti. Daha sonra ise bu dil 19. yüzyıla kadar unutuldu. Mezopotamya'da konuşulan diğer dillerin aksine Sümercenin izole dillerden olduğu kabul edilir.", "Admin", new DateTime(2023, 7, 3, 16, 55, 44, 650, DateTimeKind.Local).AddTicks(146), null, null, false, null, null, "Sumerce" });

            migrationBuilder.InsertData(
                table: "Langues",
                columns: new[] { "Id", "About", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "IsDeleted", "ModifiedBy", "ModifiedDate", "Name" },
                values: new object[] { 5, "Türkçe, diğer pek çok Türk dili ile de paylaştığı sondan eklemeli olması ve ünlü uyumu gibi dil bilgisi özellikleri ile karakterize edilir. Dil, tümce yapısı açısından genellikle özne-nesne-yüklem sırasına sahiptir. Almanca, Arapça gibi dillerin aksine gramatik cinsiyetin (erillik, dişilik, cinsiyet ayrımı) bulunmadığı Türkçede sözcüklerin bir kısmı Arapça, Farsça ve Fransızca gibi yabancı dillerden geçmedir. Ayrıca Azerice, Gagavuzca ve Türkmence gibi diğer Oğuz dilleri ile Türkçe yüksek oranda karşılıklı anlaşılabilirlik gösterir.", "Admin", new DateTime(2023, 7, 3, 16, 55, 44, 650, DateTimeKind.Local).AddTicks(148), null, null, false, null, null, "Turkce" });

            migrationBuilder.InsertData(
                table: "Langues",
                columns: new[] { "Id", "About", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "IsDeleted", "ModifiedBy", "ModifiedDate", "Name" },
                values: new object[] { 6, "Dünya'da yaklaşık olarak 200 milyon insan Fransızca bilmektedir. 128 milyon insan Fransızcayı anadili veya ikinci dili olarak konuşurken, 54 ülkede 72 milyon insan tarafından da bilinmekte ve konuşulmaktadır. Avrupa'da Fransa ve Monako dışında Belçika, İsviçre ve Lüksemburg ülkelerinin belirli bölgelerinde olmak üzere, Afrika ve Amerika kıtası dahil, dünyanın farklı köşelerinde resmî dil konumundadır.", "Admin", new DateTime(2023, 7, 3, 16, 55, 44, 650, DateTimeKind.Local).AddTicks(150), null, null, false, null, null, "Fransizca" });

            migrationBuilder.InsertData(
                table: "Langues",
                columns: new[] { "Id", "About", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "IsDeleted", "ModifiedBy", "ModifiedDate", "Name" },
                values: new object[] { 7, "Arapça kendi içerisinde çeşitli değişkelere ayrılır. Bu değişkeler birbirleriyle farklı oranlarda karşılıklı anlaşılabilirllik gösterebilirler veya hiç göstermezler. Bu nedenden ötürü bazı kaynaklar bunları ayrı birer dil olarak ele almaktadır. Arapçanın standartlaştırılmış formu olan ve Kuran Arapçasını temel alan Fasih Arapça, Arap dünyasında yazı dili olarak kullanılan Arapça lehçesidir. İslam'ın kutsal kitabı Kur'an Kuran Arapçası ile yazılmıştır ve bu Müslümanların ibadet dilidir.", "Admin", new DateTime(2023, 7, 3, 16, 55, 44, 650, DateTimeKind.Local).AddTicks(152), null, null, false, null, null, "Arapça" });

            migrationBuilder.InsertData(
                table: "Langues",
                columns: new[] { "Id", "About", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "IsDeleted", "ModifiedBy", "ModifiedDate", "Name" },
                values: new object[] { 8, "Orta Çağ itibarıyla Halk Latincesi (Vulgar Latince) çeşitli dillere ayrılmıştır. Orta Çağ'ın sonunda Floransa şehrinin kültür ve edebiyat üstünlüğü etkisiyle, Toskana yazı dilinden bugünkü İtalyanca şekillenmiştir. Dilin gelişiminde Boccaccio, Dante Alighieri ve Petrarca gibi isimlerin Latince yerine Toskana ağzını kullanmalarının büyük etkisi vardır. Buna rağmen İtalyan dili, siyasi birliğin de uzun zaman tamamlanamamış olmasının da etkisiyle bölgeden bölgeye büyük farklılıklar taşır. Her bölgenin kendine özgü şivesi vardır. Buna ek olarak İtalyanca gibi Halk Latincesinden türemiş ancak İtalyancadan farklı ve karşılıklı anlaşılabilirlik göstermeyen 30 civarı dil de İtalyada bulunmaktadır. Çoğu İtalyanca konuşuru hem İtalyanca ve şivelerini, hem de kendi bölgesel dillerini (örneğin Sicilyaca veya Furlanca) konuşmaktadır.", "Admin", new DateTime(2023, 7, 3, 16, 55, 44, 650, DateTimeKind.Local).AddTicks(154), null, null, false, null, null, "Italyanca" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "About", "Age", "Country", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "FullName", "ImageUrl", "IsDeleted", "ModifiedBy", "ModifiedDate", "Price", "Url" },
                values: new object[] { 1, "Merhabalar Ben Ecem Ünal Bogaz İçi Üniversitesi İngilizce Bölümü mezunuyum 1 yıldır İngilizce Ögretmeniyim.", 28, "Turkey", "Admin", new DateTime(2023, 7, 3, 16, 55, 44, 650, DateTimeKind.Local).AddTicks(2324), null, null, "Ecem Ünal", "ilk Ogermen ImageUrl", false, null, null, 220m, "ilk Ogretmen" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "About", "Age", "Country", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "FullName", "ImageUrl", "IsDeleted", "ModifiedBy", "ModifiedDate", "Price", "Url" },
                values: new object[] { 2, "Hi I am Hannibal Lecter. I am 33 years old.I have Experience 5 years be Germany teacher.And I am teaching russian langue", 28, "North America", "Admin", new DateTime(2023, 7, 3, 16, 55, 44, 650, DateTimeKind.Local).AddTicks(2327), null, null, "Hannibal Lecter ", "ikinci Ogretmen ImageUrl", false, null, null, 300m, "ikinci Ogretmen" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "About", "Age", "Country", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "FullName", "ImageUrl", "IsDeleted", "ModifiedBy", "ModifiedDate", "Price", "Url" },
                values: new object[] { 3, "Hi I am Ragnar Lotbrook. I am 38 years old.I have Experience 10 years be Russian teacher and I have experiance english ", 38, "Kremlin", "Admin", new DateTime(2023, 7, 3, 16, 55, 44, 650, DateTimeKind.Local).AddTicks(2329), null, null, "Ragnar Lotbrook", "Ucuncu Ogretmen ImageUrl", false, null, null, 350m, "Ucuncu Ogretmen" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "About", "Age", "Country", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "FullName", "ImageUrl", "IsDeleted", "ModifiedBy", "ModifiedDate", "Price", "Url" },
                values: new object[] { 4, "Merhaba Ben Yagmur su 35 yaşındayim 8 yıldır Sümer Dili Ve edebiyati Ögretmenligi yapiyorum ayni zamanda Fransizca ögretmenligi yapiyorum.", 35, null, "Admin", new DateTime(2023, 7, 3, 16, 55, 44, 650, DateTimeKind.Local).AddTicks(2332), null, null, "Yagmur Su", "Dorduncu Ogretmen ImageUrl", false, null, null, 280m, "Dorduncu Ogretmen" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "About", "Age", "Country", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "FullName", "ImageUrl", "IsDeleted", "ModifiedBy", "ModifiedDate", "Price", "Url" },
                values: new object[] { 5, "Merhaba Ben Ümit Ozdag 8 yıldır Arap Dili Ve Edebiyati Ögretmenligi Yapiyorum Suan Zafer Dersanesinde Arapça Ogretmeniyim.Ve Türk Dili ve Edebiyati Dersi veriyorum.", 42, null, "Admin", new DateTime(2023, 7, 3, 16, 55, 44, 650, DateTimeKind.Local).AddTicks(2334), null, null, "Umit Ozdag", "Besinci Ogretmen ImageUrl", false, null, null, 320m, "Besinci Ogretmen" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "About", "Age", "Country", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "FullName", "ImageUrl", "IsDeleted", "ModifiedBy", "ModifiedDate", "Price", "Url" },
                values: new object[] { 6, "Merhaba Bendeniz Atilla Kurt Yasım 34 ve 6 yıldır Türk Dili Ve Edebiyatı Ögretmeniyim. 3 yıllık İtalyanca Tecrübem var ", 34, null, "Admin", new DateTime(2023, 7, 3, 16, 55, 44, 650, DateTimeKind.Local).AddTicks(2336), null, null, "Atilla Kurt", "Altıncı Ogretmen ImageUrl", false, null, null, 200m, "Altıncı Ogretmen" });

            migrationBuilder.InsertData(
                table: "LangueTeachers",
                columns: new[] { "LangueId", "TeacherId" },
                values: new object[] { 1, 1 });

            migrationBuilder.InsertData(
                table: "LangueTeachers",
                columns: new[] { "LangueId", "TeacherId" },
                values: new object[] { 2, 2 });

            migrationBuilder.InsertData(
                table: "LangueTeachers",
                columns: new[] { "LangueId", "TeacherId" },
                values: new object[] { 3, 2 });

            migrationBuilder.InsertData(
                table: "LangueTeachers",
                columns: new[] { "LangueId", "TeacherId" },
                values: new object[] { 1, 3 });

            migrationBuilder.InsertData(
                table: "LangueTeachers",
                columns: new[] { "LangueId", "TeacherId" },
                values: new object[] { 3, 3 });

            migrationBuilder.InsertData(
                table: "LangueTeachers",
                columns: new[] { "LangueId", "TeacherId" },
                values: new object[] { 4, 4 });

            migrationBuilder.InsertData(
                table: "LangueTeachers",
                columns: new[] { "LangueId", "TeacherId" },
                values: new object[] { 6, 4 });

            migrationBuilder.InsertData(
                table: "LangueTeachers",
                columns: new[] { "LangueId", "TeacherId" },
                values: new object[] { 5, 5 });

            migrationBuilder.InsertData(
                table: "LangueTeachers",
                columns: new[] { "LangueId", "TeacherId" },
                values: new object[] { 7, 5 });

            migrationBuilder.InsertData(
                table: "LangueTeachers",
                columns: new[] { "LangueId", "TeacherId" },
                values: new object[] { 5, 6 });

            migrationBuilder.InsertData(
                table: "LangueTeachers",
                columns: new[] { "LangueId", "TeacherId" },
                values: new object[] { 8, 6 });

            migrationBuilder.CreateIndex(
                name: "IX_LangueTeachers_LangueId",
                table: "LangueTeachers",
                column: "LangueId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LangueTeachers");

            migrationBuilder.DropTable(
                name: "Langues");

            migrationBuilder.DropTable(
                name: "Teachers");
        }
    }
}
