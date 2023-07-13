﻿// <auto-generated />
using System;
using LanguesApp.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LanguesApp.Data.Migrations
{
    [DbContext(typeof(LanguesAppDbContext))]
    partial class LanguesAppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.19");

            modelBuilder.Entity("LanguesApp.Entity.Entities.Langue", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("About")
                        .HasMaxLength(400)
                        .HasColumnType("TEXT");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("DeletedBy")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Url")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Langues");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            About = "ilk olarak 5. yüzyılda İngiltere'de ortaya çıkmış, modern zamanlarda ise küresel bir lingua franca haline gelmiş Batı Cermen dili. İngilizce günümüzde Birleşik Krallık, Amerika Birleşik Devletleri, Karayipler, Avustralya, İrlanda, Kanada ve Yeni Zelanda'da yaşayan kişilerin çoğunluğunun anadilini oluşturmaktadır. İkinci dil ve resmî dil olarak dünya genelinde, özellikle İngiliz Milletler Topluluğu üyeleri ve çok sayıda uluslararası örgüt tarafından kullanılmaktadır.",
                            CreatedBy = "Admin",
                            CreatedDate = new DateTime(2023, 7, 11, 19, 56, 50, 139, DateTimeKind.Local).AddTicks(223),
                            IsDeleted = false,
                            Name = "İngilizce"
                        },
                        new
                        {
                            Id = 2,
                            About = "Almanca (Deutsch; Almanca telaffuz: [dɔʏtʃ]), Hint-Avrupa dillerinin Cermen dilleri koluna bağlıdır ve dünyanın yaygın lisanlarından biridir. Avrupa Birliği'nin resmî dillerinden biri ve en çok konuşulanıdır. Özellikle Almanya, Avusturya, Lihtenştayn, Lüksemburg, İsviçre'nin büyük bölümü, İtalya'nın Güney Tirol bölümü, Belçika'nın doğu kantonları, Polonya ve Romanya'nın kimi bölgeleri ve Fransa'nın Alsas-Loren bölgesinde konuşulmaktadır. Almanca içinde Fransız kelime kökenli sözcükler taşır. Almanca, eski dönemlerde Türkçede Slav dilleri ile benzer şekilde Nemçece olarak adlandırılmıştır.",
                            CreatedBy = "Admin",
                            CreatedDate = new DateTime(2023, 7, 11, 19, 56, 50, 139, DateTimeKind.Local).AddTicks(234),
                            IsDeleted = false,
                            Name = "Almanca"
                        },
                        new
                        {
                            Id = 3,
                            About = "Rusça, Beyaz Rusça ve Ukraynaca ile birlikte Hint-Avrupa dil ailesinin Slav Dilleri grubunun Doğu Slav Dilleri alt grubuna girer. 20. yüzyılda politik açıdan önemli bir dil olan Rusça, Birleşmiş Milletlerin resmi dillerinden biridir. Rusça dünya üzerinde en çok konuşulan 7. dildir.Rusça Kiril alfabesini kullanır. Çünkü Latin harfleri Rus dilindeki tüm sesleri ifade etmek için yeterli değildir.[13] Rusçada vurgu çok önemlidir. Rusça sözcüklerde vurgunun belli bir yeri yoktur.[14] DolayısıyӀa sözcükleri öğrenirken vurguyu ve telaffuzu doğru öğrenmek önemlidir. Rusça kelime okunuş vurgu bulunduğu yere bağlı olarak değişebilmektedir",
                            CreatedBy = "Admin",
                            CreatedDate = new DateTime(2023, 7, 11, 19, 56, 50, 139, DateTimeKind.Local).AddTicks(236),
                            IsDeleted = false,
                            Name = "Rusca"
                        },
                        new
                        {
                            Id = 4,
                            About = " Sümerlerin anadili. Güney Mezopotamya'da MÖ 4000 yılında konuşuluyordu. MÖ 2000'li yılların başlarında yerini konuşma dili olarak Akadcaya bıraktı, ancak Mezopotamya'da MS 1. yüzyıla kadar kutsal, şölensel, edebî ve bilimsel bir dil olarak kullanılmaya devam etti. Daha sonra ise bu dil 19. yüzyıla kadar unutuldu. Mezopotamya'da konuşulan diğer dillerin aksine Sümercenin izole dillerden olduğu kabul edilir.",
                            CreatedBy = "Admin",
                            CreatedDate = new DateTime(2023, 7, 11, 19, 56, 50, 139, DateTimeKind.Local).AddTicks(237),
                            IsDeleted = false,
                            Name = "Sumerce"
                        },
                        new
                        {
                            Id = 5,
                            About = "Türkçe, diğer pek çok Türk dili ile de paylaştığı sondan eklemeli olması ve ünlü uyumu gibi dil bilgisi özellikleri ile karakterize edilir. Dil, tümce yapısı açısından genellikle özne-nesne-yüklem sırasına sahiptir. Almanca, Arapça gibi dillerin aksine gramatik cinsiyetin (erillik, dişilik, cinsiyet ayrımı) bulunmadığı Türkçede sözcüklerin bir kısmı Arapça, Farsça ve Fransızca gibi yabancı dillerden geçmedir. Ayrıca Azerice, Gagavuzca ve Türkmence gibi diğer Oğuz dilleri ile Türkçe yüksek oranda karşılıklı anlaşılabilirlik gösterir.",
                            CreatedBy = "Admin",
                            CreatedDate = new DateTime(2023, 7, 11, 19, 56, 50, 139, DateTimeKind.Local).AddTicks(239),
                            IsDeleted = false,
                            Name = "Turkce"
                        },
                        new
                        {
                            Id = 6,
                            About = "Dünya'da yaklaşık olarak 200 milyon insan Fransızca bilmektedir. 128 milyon insan Fransızcayı anadili veya ikinci dili olarak konuşurken, 54 ülkede 72 milyon insan tarafından da bilinmekte ve konuşulmaktadır. Avrupa'da Fransa ve Monako dışında Belçika, İsviçre ve Lüksemburg ülkelerinin belirli bölgelerinde olmak üzere, Afrika ve Amerika kıtası dahil, dünyanın farklı köşelerinde resmî dil konumundadır.",
                            CreatedBy = "Admin",
                            CreatedDate = new DateTime(2023, 7, 11, 19, 56, 50, 139, DateTimeKind.Local).AddTicks(240),
                            IsDeleted = false,
                            Name = "Fransizca"
                        },
                        new
                        {
                            Id = 7,
                            About = "Arapça kendi içerisinde çeşitli değişkelere ayrılır. Bu değişkeler birbirleriyle farklı oranlarda karşılıklı anlaşılabilirllik gösterebilirler veya hiç göstermezler. Bu nedenden ötürü bazı kaynaklar bunları ayrı birer dil olarak ele almaktadır. Arapçanın standartlaştırılmış formu olan ve Kuran Arapçasını temel alan Fasih Arapça, Arap dünyasında yazı dili olarak kullanılan Arapça lehçesidir. İslam'ın kutsal kitabı Kur'an Kuran Arapçası ile yazılmıştır ve bu Müslümanların ibadet dilidir.",
                            CreatedBy = "Admin",
                            CreatedDate = new DateTime(2023, 7, 11, 19, 56, 50, 139, DateTimeKind.Local).AddTicks(242),
                            IsDeleted = false,
                            Name = "Arapça"
                        },
                        new
                        {
                            Id = 8,
                            About = "Orta Çağ itibarıyla Halk Latincesi (Vulgar Latince) çeşitli dillere ayrılmıştır. Orta Çağ'ın sonunda Floransa şehrinin kültür ve edebiyat üstünlüğü etkisiyle, Toskana yazı dilinden bugünkü İtalyanca şekillenmiştir. Dilin gelişiminde Boccaccio, Dante Alighieri ve Petrarca gibi isimlerin Latince yerine Toskana ağzını kullanmalarının büyük etkisi vardır. Buna rağmen İtalyan dili, siyasi birliğin de uzun zaman tamamlanamamış olmasının da etkisiyle bölgeden bölgeye büyük farklılıklar taşır. Her bölgenin kendine özgü şivesi vardır. Buna ek olarak İtalyanca gibi Halk Latincesinden türemiş ancak İtalyancadan farklı ve karşılıklı anlaşılabilirlik göstermeyen 30 civarı dil de İtalyada bulunmaktadır. Çoğu İtalyanca konuşuru hem İtalyanca ve şivelerini, hem de kendi bölgesel dillerini (örneğin Sicilyaca veya Furlanca) konuşmaktadır.",
                            CreatedBy = "Admin",
                            CreatedDate = new DateTime(2023, 7, 11, 19, 56, 50, 139, DateTimeKind.Local).AddTicks(243),
                            IsDeleted = false,
                            Name = "Italyanca"
                        });
                });

            modelBuilder.Entity("LanguesApp.Entity.Entities.LangueTeacher", b =>
                {
                    b.Property<int>("TeacherId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("LangueId")
                        .HasColumnType("INTEGER");

                    b.HasKey("TeacherId", "LangueId");

                    b.HasIndex("LangueId");

                    b.ToTable("LangueTeachers");

                    b.HasData(
                        new
                        {
                            TeacherId = 1,
                            LangueId = 1
                        },
                        new
                        {
                            TeacherId = 2,
                            LangueId = 2
                        },
                        new
                        {
                            TeacherId = 2,
                            LangueId = 3
                        },
                        new
                        {
                            TeacherId = 3,
                            LangueId = 3
                        },
                        new
                        {
                            TeacherId = 3,
                            LangueId = 1
                        },
                        new
                        {
                            TeacherId = 4,
                            LangueId = 4
                        },
                        new
                        {
                            TeacherId = 4,
                            LangueId = 6
                        },
                        new
                        {
                            TeacherId = 5,
                            LangueId = 5
                        },
                        new
                        {
                            TeacherId = 5,
                            LangueId = 7
                        },
                        new
                        {
                            TeacherId = 6,
                            LangueId = 5
                        },
                        new
                        {
                            TeacherId = 6,
                            LangueId = 8
                        },
                        new
                        {
                            TeacherId = 7,
                            LangueId = 1
                        });
                });

            modelBuilder.Entity("LanguesApp.Entity.Entities.Teacher", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("About")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("TEXT");

                    b.Property<int>("Age")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Country")
                        .HasColumnType("TEXT");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("DeletedBy")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsActive")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Phone")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Price")
                        .HasColumnType("TEXT");

                    b.Property<string>("Url")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Teachers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            About = "Merhabalar Ben Ecem Ünal Bogaz İçi Üniversitesi İngilizce Bölümü mezunuyum 1 yıldır İngilizce Ögretmeniyim.",
                            Age = 28,
                            Country = "Turkey",
                            CreatedBy = "Admin",
                            CreatedDate = new DateTime(2023, 7, 11, 19, 56, 50, 139, DateTimeKind.Local).AddTicks(3016),
                            Email = "Ecemunal@gmail.com",
                            FullName = "Ecem Ünal",
                            ImageUrl = "kadin1.jpg",
                            IsActive = true,
                            IsDeleted = false,
                            Phone = "+905426742261",
                            Price = 220m,
                            Url = "ilk Ogretmen"
                        },
                        new
                        {
                            Id = 2,
                            About = "Hi I am Hannibal Lecter. I am 33 years old.I have Experience 5 years be Germany teacher.And I am teaching russian langue",
                            Age = 28,
                            Country = "North America",
                            CreatedBy = "Admin",
                            CreatedDate = new DateTime(2023, 7, 11, 19, 56, 50, 139, DateTimeKind.Local).AddTicks(3025),
                            Email = "HannibalLecter@gmail.com",
                            FullName = "Hannibal Lecter ",
                            ImageUrl = "Erkek1.jpg",
                            IsActive = true,
                            IsDeleted = false,
                            Phone = "+756425271963",
                            Price = 300m,
                            Url = "ikinci Ogretmen"
                        },
                        new
                        {
                            Id = 3,
                            About = "Hi I am Ragnar Lotbrook. I am 38 years old.I have Experience 10 years be Russian teacher and I have experiance english ",
                            Age = 38,
                            Country = "Kremlin",
                            CreatedBy = "Admin",
                            CreatedDate = new DateTime(2023, 7, 11, 19, 56, 50, 139, DateTimeKind.Local).AddTicks(3028),
                            Email = "RagnarLotbrook@gmail.com",
                            FullName = "Ragnar Lotbrook",
                            ImageUrl = "Erkek2.jpg",
                            IsActive = true,
                            IsDeleted = false,
                            Phone = "+709624789231",
                            Price = 350m,
                            Url = "Ucuncu Ogretmen"
                        },
                        new
                        {
                            Id = 4,
                            About = "Merhaba Ben Yagmur su 35 yaşındayim 8 yıldır Sümer Dili Ve edebiyati Ögretmenligi yapiyorum ayni zamanda Fransizca ögretmenligi yapiyorum.",
                            Age = 35,
                            Country = "Turkey",
                            CreatedBy = "Admin",
                            CreatedDate = new DateTime(2023, 7, 11, 19, 56, 50, 139, DateTimeKind.Local).AddTicks(3031),
                            Email = "SuYagmur@gmail.com",
                            FullName = "Yagmur Su",
                            ImageUrl = "kadin2.jpg",
                            IsActive = true,
                            IsDeleted = false,
                            Phone = "+905346712263",
                            Price = 280m,
                            Url = "Dorduncu Ogretmen"
                        },
                        new
                        {
                            Id = 5,
                            About = "Merhaba Ben Ümit Ozdag 8 yıldır Arap Dili Ve Edebiyati Ögretmenligi Yapiyorum Suan Zafer Dersanesinde Arapça Ogretmeniyim.Ve Türk Dili ve Edebiyati Dersi veriyorum.",
                            Age = 42,
                            Country = "Suriye",
                            CreatedBy = "Admin",
                            CreatedDate = new DateTime(2023, 7, 11, 19, 56, 50, 139, DateTimeKind.Local).AddTicks(3033),
                            Email = "OzdagUmit3425@gmail.com",
                            FullName = "Umit Ozdag",
                            ImageUrl = "Erkek3.jpg",
                            IsActive = true,
                            IsDeleted = false,
                            Phone = "+905425346734",
                            Price = 320m,
                            Url = "Besinci Ogretmen"
                        },
                        new
                        {
                            Id = 6,
                            About = "Merhaba Bendeniz Atilla Kurt Yasım 34 ve 6 yıldır Türk Dili Ve Edebiyatı Ögretmeniyim. 3 yıllık İtalyanca Tecrübem var ",
                            Age = 34,
                            Country = "Turkiye",
                            CreatedBy = "Admin",
                            CreatedDate = new DateTime(2023, 7, 11, 19, 56, 50, 139, DateTimeKind.Local).AddTicks(3036),
                            Email = "KurAtilla@gmail.com",
                            FullName = "Atilla Kurt",
                            ImageUrl = "Erkek4.jpg",
                            IsActive = true,
                            IsDeleted = false,
                            Phone = "+902221369523",
                            Price = 200m,
                            Url = "Altıncı Ogretmen"
                        },
                        new
                        {
                            Id = 7,
                            About = "Deneme ",
                            Age = 42,
                            Country = "Turkiye",
                            CreatedBy = "Admin",
                            CreatedDate = new DateTime(2023, 7, 11, 19, 56, 50, 139, DateTimeKind.Local).AddTicks(3038),
                            Email = "Deneme3425@gmail.com",
                            FullName = "DenemeTeacher ingilizce",
                            ImageUrl = "Erkek5.jpg",
                            IsActive = false,
                            IsDeleted = false,
                            Phone = "+904563219874",
                            Price = 2080m,
                            Url = "deneme Ogretmen"
                        });
                });

            modelBuilder.Entity("LanguesApp.Entity.Entities.LangueTeacher", b =>
                {
                    b.HasOne("LanguesApp.Entity.Entities.Langue", "Langue")
                        .WithMany("LangueTeachers")
                        .HasForeignKey("LangueId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LanguesApp.Entity.Entities.Teacher", "Teacher")
                        .WithMany("LangueTeachers")
                        .HasForeignKey("TeacherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Langue");

                    b.Navigation("Teacher");
                });

            modelBuilder.Entity("LanguesApp.Entity.Entities.Langue", b =>
                {
                    b.Navigation("LangueTeachers");
                });

            modelBuilder.Entity("LanguesApp.Entity.Entities.Teacher", b =>
                {
                    b.Navigation("LangueTeachers");
                });
#pragma warning restore 612, 618
        }
    }
}
