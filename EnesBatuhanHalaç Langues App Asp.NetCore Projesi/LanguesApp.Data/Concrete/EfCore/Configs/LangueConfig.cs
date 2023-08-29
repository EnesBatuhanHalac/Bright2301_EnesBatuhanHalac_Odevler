using LanguesApp.Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguesApp.Data.Concrete.EfCore.Config
{
    public class LangueConfig : IEntityTypeConfiguration<Langue>
    {
        public void Configure(EntityTypeBuilder<Langue> builder)
        {
            builder.HasKey(x=>x.Id);

            builder.HasData(new Langue
            {
                Id = 1,
                Name = "İngilizce",
                About = "ilk olarak 5. yüzyılda İngiltere'de ortaya çıkmış, modern zamanlarda ise küresel bir lingua franca haline gelmiş Batı Cermen dili. İngilizce günümüzde Birleşik Krallık, " +
                "Amerika Birleşik Devletleri, Karayipler, Avustralya, İrlanda, Kanada ve Yeni Zelanda'da yaşayan kişilerin çoğunluğunun anadilini oluşturmaktadır." +
                " İkinci dil ve resmî dil olarak dünya genelinde, özellikle İngiliz Milletler Topluluğu üyeleri ve çok sayıda uluslararası örgüt tarafından kullanılmaktadır.",
                CreatedBy = "Admin",
                CreatedDate = DateTime.Now,
                IsDeleted = false,
                IsActive = true,
                Url="Ingilizce"

            },
            
            new Langue
            {
                Id = 2,
                Name = "Almanca",
                About = "Almanca (Deutsch; Almanca telaffuz: [dɔʏtʃ]), Hint-Avrupa dillerinin Cermen dilleri koluna bağlıdır ve dünyanın yaygın lisanlarından biridir." +
                " Avrupa Birliği'nin resmî dillerinden biri ve en çok konuşulanıdır. Özellikle Almanya, Avusturya, Lihtenştayn, Lüksemburg, İsviçre'nin büyük bölümü," +
                " İtalya'nın Güney Tirol bölümü, Belçika'nın doğu kantonları, Polonya ve Romanya'nın kimi bölgeleri ve Fransa'nın Alsas-Loren bölgesinde konuşulmaktadır. " +
                "Almanca içinde Fransız kelime kökenli sözcükler taşır. " +
                "Almanca, eski dönemlerde Türkçede Slav dilleri ile benzer şekilde Nemçece olarak adlandırılmıştır.",
                CreatedBy = "Admin",
                CreatedDate = DateTime.Now,
                IsDeleted = false,
                IsActive = true,
                Url = "Almanca"

            },

            new Langue
            {
                Id = 3,
                Name = "Rusca",
                About = "Rusça, Beyaz Rusça ve Ukraynaca ile birlikte Hint-Avrupa dil ailesinin Slav Dilleri grubunun Doğu Slav Dilleri alt grubuna girer." +
                " 20. yüzyılda politik açıdan önemli bir dil olan Rusça, Birleşmiş Milletlerin resmi dillerinden biridir. Rusça dünya üzerinde en çok konuşulan 7. dildir." +
                "Rusça Kiril alfabesini kullanır. Çünkü Latin harfleri Rus dilindeki tüm sesleri ifade etmek için yeterli değildir.[13] Rusçada vurgu çok önemlidir." +
                " Rusça sözcüklerde vurgunun belli bir yeri yoktur.[14] DolayısıyӀa sözcükleri öğrenirken vurguyu ve telaffuzu doğru öğrenmek önemlidir. Rusça kelime okunuş vurgu " +
                "bulunduğu yere bağlı olarak değişebilmektedir",
                CreatedBy = "Admin",
                CreatedDate = DateTime.Now,
                IsDeleted = false,
                IsActive = true,
                Url="Rusca"
            },

            new Langue
            {
                Id = 4,
                Name = "Sumerce",
                About = " Sümerlerin anadili. Güney Mezopotamya'da MÖ 4000 yılında konuşuluyordu. MÖ 2000'li yılların başlarında yerini konuşma dili olarak Akadcaya bıraktı, " +
                 "ancak Mezopotamya'da MS 1. yüzyıla kadar kutsal, şölensel, edebî ve bilimsel bir dil olarak kullanılmaya devam etti." +
                 " Daha sonra ise bu dil 19. yüzyıla kadar unutuldu. Mezopotamya'da konuşulan diğer dillerin aksine Sümercenin izole dillerden olduğu kabul edilir.",
                CreatedBy = "Admin",
                CreatedDate = DateTime.Now,
                IsDeleted = false,
                IsActive = true,
                Url="Sumerce"
            },

            new Langue
            {
                Id = 5,
                Name = "Turkce",
                About = "Türkçe, diğer pek çok Türk dili ile de paylaştığı sondan eklemeli olması ve ünlü uyumu gibi dil bilgisi özellikleri ile karakterize edilir. " +
                  "Dil, tümce yapısı açısından genellikle özne-nesne-yüklem sırasına sahiptir. " +
                  "Almanca, Arapça gibi dillerin aksine gramatik cinsiyetin (erillik, dişilik, cinsiyet ayrımı) bulunmadığı " +
                  "Türkçede sözcüklerin bir kısmı Arapça, Farsça ve Fransızca gibi yabancı dillerden geçmedir. Ayrıca Azerice," +
                  " Gagavuzca ve Türkmence gibi diğer Oğuz dilleri ile Türkçe yüksek oranda karşılıklı anlaşılabilirlik gösterir.",
                CreatedBy = "Admin",
                CreatedDate = DateTime.Now,
                IsDeleted = false,
                IsActive = true,
                Url="Turkce"
            },

            new Langue
            {
                Id = 6,
                Name = "Fransizca",
                About = "Dünya'da yaklaşık olarak 200 milyon insan Fransızca bilmektedir. 128 milyon insan" +
                  " Fransızcayı anadili veya ikinci dili olarak konuşurken, " +
                  "54 ülkede 72 milyon insan tarafından da bilinmekte ve konuşulmaktadır. " +
                  "Avrupa'da Fransa ve Monako dışında Belçika, İsviçre ve Lüksemburg ülkelerinin belirli " +
                  "bölgelerinde olmak üzere, Afrika ve Amerika kıtası dahil, dünyanın farklı köşelerinde resmî dil konumundadır.",
                CreatedBy = "Admin",
                CreatedDate = DateTime.Now,
                IsDeleted = false,
                IsActive = true,
                Url="Fransizca"
            },

            new Langue
            {
                Id = 7,
                Name = "Arapça",
                About = "Arapça kendi içerisinde çeşitli değişkelere ayrılır. Bu değişkeler birbirleriyle farklı oranlarda karşılıklı" +
                  " anlaşılabilirllik gösterebilirler veya hiç göstermezler. Bu nedenden ötürü bazı kaynaklar bunları ayrı birer dil olarak " +
                  "ele almaktadır. Arapçanın standartlaştırılmış formu olan ve Kuran Arapçasını temel alan Fasih Arapça, Arap dünyasında yazı" +
                  " dili olarak kullanılan Arapça lehçesidir. İslam'ın kutsal kitabı Kur'an Kuran Arapçası ile yazılmıştır ve bu Müslümanların" +
                  " ibadet dilidir.",
                CreatedBy = "Admin",
                CreatedDate = DateTime.Now,
                IsDeleted = false,
                IsActive = true,
                Url="Arapca"
            },

            new Langue
            {
                Id = 8,
                Name = "Italyanca",
                About = "Orta Çağ itibarıyla Halk Latincesi (Vulgar Latince) çeşitli dillere ayrılmıştır. " +
                  "Orta Çağ'ın sonunda Floransa şehrinin kültür ve edebiyat üstünlüğü etkisiyle, " +
                  "Toskana yazı dilinden bugünkü İtalyanca şekillenmiştir. Dilin gelişiminde Boccaccio," +
                  " Dante Alighieri ve Petrarca gibi isimlerin Latince yerine Toskana ağzını kullanmalarının büyük etkisi vardır." +
                  " Buna rağmen İtalyan dili, siyasi birliğin de uzun zaman tamamlanamamış olmasının da etkisiyle bölgeden bölgeye büyük farklılıklar taşır." +
                  " Her bölgenin kendine özgü şivesi vardır. Buna ek olarak İtalyanca gibi Halk Latincesinden türemiş ancak İtalyancadan " +
                  "farklı ve karşılıklı anlaşılabilirlik göstermeyen 30 civarı dil de İtalyada bulunmaktadır. Çoğu İtalyanca konuşuru hem İtalyanca ve şivelerini," +
                  " hem de kendi bölgesel dillerini (örneğin Sicilyaca veya Furlanca) konuşmaktadır.",
                CreatedBy = "Admin",
                CreatedDate = DateTime.Now,
                IsDeleted = false,
                IsActive = true,
                Url="Italyanca"
            }
            
            );

        }
    }
}
