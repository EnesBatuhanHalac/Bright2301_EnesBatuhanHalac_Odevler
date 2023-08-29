using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LanguesApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Langues",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    About = table.Column<string>(type: "TEXT", nullable: false),
                    Url = table.Column<string>(type: "TEXT", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    IsActive = table.Column<bool>(type: "INTEGER", nullable: false),
                    IsDeleted = table.Column<bool>(type: "INTEGER", nullable: true),
                    CreatedBy = table.Column<string>(type: "TEXT", nullable: false)
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
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    LastName = table.Column<string>(type: "TEXT", nullable: false),
                    About = table.Column<string>(type: "TEXT", nullable: false),
                    Country = table.Column<string>(type: "TEXT", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false),
                    Url = table.Column<string>(type: "TEXT", nullable: false),
                    ImageUrl = table.Column<string>(type: "TEXT", nullable: false),
                    PhoneNumber = table.Column<string>(type: "TEXT", nullable: false),
                    Age = table.Column<int>(type: "INTEGER", nullable: false),
                    Price = table.Column<int>(type: "INTEGER", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    IsActive = table.Column<bool>(type: "INTEGER", nullable: false),
                    IsDeleted = table.Column<bool>(type: "INTEGER", nullable: true),
                    CreatedBy = table.Column<string>(type: "TEXT", nullable: false)
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
                columns: new[] { "Id", "About", "CreatedBy", "CreatedDate", "IsActive", "IsDeleted", "ModifiedDate", "Name", "Url" },
                values: new object[,]
                {
                    { 1, "ilk olarak 5. yüzyılda İngiltere'de ortaya çıkmış, modern zamanlarda ise küresel bir lingua franca haline gelmiş Batı Cermen dili. İngilizce günümüzde Birleşik Krallık, Amerika Birleşik Devletleri, Karayipler, Avustralya, İrlanda, Kanada ve Yeni Zelanda'da yaşayan kişilerin çoğunluğunun anadilini oluşturmaktadır. İkinci dil ve resmî dil olarak dünya genelinde, özellikle İngiliz Milletler Topluluğu üyeleri ve çok sayıda uluslararası örgüt tarafından kullanılmaktadır.", "Admin", new DateTime(2023, 8, 17, 14, 13, 1, 567, DateTimeKind.Local).AddTicks(6009), true, false, null, "İngilizce", "Ingilizce" },
                    { 2, "Almanca (Deutsch; Almanca telaffuz: [dɔʏtʃ]), Hint-Avrupa dillerinin Cermen dilleri koluna bağlıdır ve dünyanın yaygın lisanlarından biridir. Avrupa Birliği'nin resmî dillerinden biri ve en çok konuşulanıdır. Özellikle Almanya, Avusturya, Lihtenştayn, Lüksemburg, İsviçre'nin büyük bölümü, İtalya'nın Güney Tirol bölümü, Belçika'nın doğu kantonları, Polonya ve Romanya'nın kimi bölgeleri ve Fransa'nın Alsas-Loren bölgesinde konuşulmaktadır. Almanca içinde Fransız kelime kökenli sözcükler taşır. Almanca, eski dönemlerde Türkçede Slav dilleri ile benzer şekilde Nemçece olarak adlandırılmıştır.", "Admin", new DateTime(2023, 8, 17, 14, 13, 1, 567, DateTimeKind.Local).AddTicks(6011), true, false, null, "Almanca", "Almanca" },
                    { 3, "Rusça, Beyaz Rusça ve Ukraynaca ile birlikte Hint-Avrupa dil ailesinin Slav Dilleri grubunun Doğu Slav Dilleri alt grubuna girer. 20. yüzyılda politik açıdan önemli bir dil olan Rusça, Birleşmiş Milletlerin resmi dillerinden biridir. Rusça dünya üzerinde en çok konuşulan 7. dildir.Rusça Kiril alfabesini kullanır. Çünkü Latin harfleri Rus dilindeki tüm sesleri ifade etmek için yeterli değildir.[13] Rusçada vurgu çok önemlidir. Rusça sözcüklerde vurgunun belli bir yeri yoktur.[14] DolayısıyӀa sözcükleri öğrenirken vurguyu ve telaffuzu doğru öğrenmek önemlidir. Rusça kelime okunuş vurgu bulunduğu yere bağlı olarak değişebilmektedir", "Admin", new DateTime(2023, 8, 17, 14, 13, 1, 567, DateTimeKind.Local).AddTicks(6014), true, false, null, "Rusca", "Rusca" },
                    { 4, " Sümerlerin anadili. Güney Mezopotamya'da MÖ 4000 yılında konuşuluyordu. MÖ 2000'li yılların başlarında yerini konuşma dili olarak Akadcaya bıraktı, ancak Mezopotamya'da MS 1. yüzyıla kadar kutsal, şölensel, edebî ve bilimsel bir dil olarak kullanılmaya devam etti. Daha sonra ise bu dil 19. yüzyıla kadar unutuldu. Mezopotamya'da konuşulan diğer dillerin aksine Sümercenin izole dillerden olduğu kabul edilir.", "Admin", new DateTime(2023, 8, 17, 14, 13, 1, 567, DateTimeKind.Local).AddTicks(6016), true, false, null, "Sumerce", "Sumerce" },
                    { 5, "Türkçe, diğer pek çok Türk dili ile de paylaştığı sondan eklemeli olması ve ünlü uyumu gibi dil bilgisi özellikleri ile karakterize edilir. Dil, tümce yapısı açısından genellikle özne-nesne-yüklem sırasına sahiptir. Almanca, Arapça gibi dillerin aksine gramatik cinsiyetin (erillik, dişilik, cinsiyet ayrımı) bulunmadığı Türkçede sözcüklerin bir kısmı Arapça, Farsça ve Fransızca gibi yabancı dillerden geçmedir. Ayrıca Azerice, Gagavuzca ve Türkmence gibi diğer Oğuz dilleri ile Türkçe yüksek oranda karşılıklı anlaşılabilirlik gösterir.", "Admin", new DateTime(2023, 8, 17, 14, 13, 1, 567, DateTimeKind.Local).AddTicks(6019), true, false, null, "Turkce", "Turkce" },
                    { 6, "Dünya'da yaklaşık olarak 200 milyon insan Fransızca bilmektedir. 128 milyon insan Fransızcayı anadili veya ikinci dili olarak konuşurken, 54 ülkede 72 milyon insan tarafından da bilinmekte ve konuşulmaktadır. Avrupa'da Fransa ve Monako dışında Belçika, İsviçre ve Lüksemburg ülkelerinin belirli bölgelerinde olmak üzere, Afrika ve Amerika kıtası dahil, dünyanın farklı köşelerinde resmî dil konumundadır.", "Admin", new DateTime(2023, 8, 17, 14, 13, 1, 567, DateTimeKind.Local).AddTicks(6021), true, false, null, "Fransizca", "Fransizca" },
                    { 7, "Arapça kendi içerisinde çeşitli değişkelere ayrılır. Bu değişkeler birbirleriyle farklı oranlarda karşılıklı anlaşılabilirllik gösterebilirler veya hiç göstermezler. Bu nedenden ötürü bazı kaynaklar bunları ayrı birer dil olarak ele almaktadır. Arapçanın standartlaştırılmış formu olan ve Kuran Arapçasını temel alan Fasih Arapça, Arap dünyasında yazı dili olarak kullanılan Arapça lehçesidir. İslam'ın kutsal kitabı Kur'an Kuran Arapçası ile yazılmıştır ve bu Müslümanların ibadet dilidir.", "Admin", new DateTime(2023, 8, 17, 14, 13, 1, 567, DateTimeKind.Local).AddTicks(6024), true, false, null, "Arapça", "Arapca" },
                    { 8, "Orta Çağ itibarıyla Halk Latincesi (Vulgar Latince) çeşitli dillere ayrılmıştır. Orta Çağ'ın sonunda Floransa şehrinin kültür ve edebiyat üstünlüğü etkisiyle, Toskana yazı dilinden bugünkü İtalyanca şekillenmiştir. Dilin gelişiminde Boccaccio, Dante Alighieri ve Petrarca gibi isimlerin Latince yerine Toskana ağzını kullanmalarının büyük etkisi vardır. Buna rağmen İtalyan dili, siyasi birliğin de uzun zaman tamamlanamamış olmasının da etkisiyle bölgeden bölgeye büyük farklılıklar taşır. Her bölgenin kendine özgü şivesi vardır. Buna ek olarak İtalyanca gibi Halk Latincesinden türemiş ancak İtalyancadan farklı ve karşılıklı anlaşılabilirlik göstermeyen 30 civarı dil de İtalyada bulunmaktadır. Çoğu İtalyanca konuşuru hem İtalyanca ve şivelerini, hem de kendi bölgesel dillerini (örneğin Sicilyaca veya Furlanca) konuşmaktadır.", "Admin", new DateTime(2023, 8, 17, 14, 13, 1, 567, DateTimeKind.Local).AddTicks(6026), true, false, null, "Italyanca", "Italyanca" }
                });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "About", "Age", "Country", "CreatedBy", "CreatedDate", "Email", "ImageUrl", "IsActive", "IsDeleted", "LastName", "ModifiedDate", "Name", "PhoneNumber", "Price", "Url" },
                values: new object[,]
                {
                    { 1, "Merhabalar Ben Ecem Ünal Bogaz İçi Üniversitesi İngilizce Bölümü mezunuyum 1 yıldır İngilizce Ögretmeniyim.", 28, "Turkey", "Admin", new DateTime(2023, 8, 17, 14, 13, 1, 569, DateTimeKind.Local).AddTicks(6608), "Ecemunal@gmail.com", "kadin1.jpg", true, false, "Ünal", null, "Ecem", "+905426742261", 220, "ilk Ogretmen" },
                    { 2, "Hi I am Hannibal Lecter. I am 33 years old.I have Experience 5 years be Germany teacher.And I am teaching russian langue", 28, "North America", "Admin", new DateTime(2023, 8, 17, 14, 13, 1, 569, DateTimeKind.Local).AddTicks(6613), "HannibalLecter@gmail.com", "Erkek1.jpg", true, false, "Lecter", null, "Hannibal", "+756425271963", 300, "ikinci Ogretmen" },
                    { 3, "Hi I am Ragnar Lotbrook. I am 38 years old.I have Experience 10 years be Russian teacher and I have experiance english ", 38, "Kremlin", "Admin", new DateTime(2023, 8, 17, 14, 13, 1, 569, DateTimeKind.Local).AddTicks(6617), "RagnarLotbrook@gmail.com", "Erkek2.jpg", true, false, "Lotbrook", null, "Ragnar", "+709624789231", 350, "Ucuncu Ogretmen" },
                    { 4, "Merhaba Ben Yagmur su 35 yaşındayim 8 yıldır Sümer Dili Ve edebiyati Ögretmenligi yapiyorum ayni zamanda Fransizca ögretmenligi yapiyorum.", 35, "Turkey", "Admin", new DateTime(2023, 8, 17, 14, 13, 1, 569, DateTimeKind.Local).AddTicks(6621), "SuYagmur@gmail.com", "kadin2.jpg", true, false, "Su", null, "Yagmur", "+905346712263", 280, "Dorduncu Ogretmen" },
                    { 5, "Merhaba Ben Ümit Ozdag 8 yıldır Arap Dili Ve Edebiyati Ögretmenligi Yapiyorum Suan Zafer Dersanesinde Arapça Ogretmeniyim.Ve Türk Dili ve Edebiyati Dersi veriyorum.", 42, "Suriye", "Admin", new DateTime(2023, 8, 17, 14, 13, 1, 569, DateTimeKind.Local).AddTicks(6673), "OzdagUmit3425@gmail.com", "Erkek3.jpg", true, false, "Ozdag", null, "Umit", "+905425346734", 320, "Besinci Ogretmen" },
                    { 6, "Merhaba Bendeniz Atilla Kurt Yasım 34 ve 6 yıldır Türk Dili Ve Edebiyatı Ögretmeniyim. 3 yıllık İtalyanca Tecrübem var ", 34, "Turkiye", "Admin", new DateTime(2023, 8, 17, 14, 13, 1, 569, DateTimeKind.Local).AddTicks(6678), "KurAtilla@gmail.com", "Erkek4.jpg", true, false, "Kurt", null, "Atilla", "+902221369523", 200, "Altıncı Ogretmen" },
                    { 7, "Deneme ", 42, "Turkiye", "Admin", new DateTime(2023, 8, 17, 14, 13, 1, 569, DateTimeKind.Local).AddTicks(6682), "Deneme3425@gmail.com", "Erkek5.jpg", false, false, "ingilizce", null, "DenemeTeacher ", "+904563219874", 2080, "deneme Ogretmen" }
                });

            migrationBuilder.InsertData(
                table: "LangueTeachers",
                columns: new[] { "LangueId", "TeacherId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 2 },
                    { 3, 2 },
                    { 1, 3 },
                    { 3, 3 },
                    { 4, 4 },
                    { 6, 4 },
                    { 5, 5 },
                    { 7, 5 },
                    { 5, 6 },
                    { 8, 6 },
                    { 1, 7 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_LangueTeachers_LangueId",
                table: "LangueTeachers",
                column: "LangueId");
        }

        /// <inheritdoc />
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
