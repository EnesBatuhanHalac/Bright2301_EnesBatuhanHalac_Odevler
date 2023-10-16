using BrightApp.Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrightApp.Data.Concrete.EFCore.Config
{
    public class CourseConfig : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x=>x.EgitiminSeviyesi).IsRequired();
            builder.Property(x=>x.EgitiminYeri).IsRequired();
            builder.Property(x=>x.EgitiminStatusu).IsRequired();
            builder.Property(x=>x.Aciklama).IsRequired();
            builder.Property(x=>x.EgitimAdi).IsRequired();
            builder.Property(x=>x.EgitimBaslangicTarihi).IsRequired();
            builder.Property(x=>x.EgitiminAktiflikDurumu).IsRequired();
            builder.Property(x=>x.EgitiminDegerlendirilmesi).IsRequired();
            builder.Property(x=>x.EgitiminIcerigi).IsRequired();
            builder.Property(x=>x.EgitiminKazanimlari).IsRequired();
            builder.Property(x=>x.EgitimPlanlananBitisTarihi).IsRequired();
            builder.Property(x=>x.EgitimSuresiAy).IsRequired();
            builder.Property(x=>x.EgitimToplamDersSaati).IsRequired();

            builder.HasData(new Course
            {
                Id = 1,
                EgitimAdi = "Full Stack Developer Yetiştirme Kursu",
                EgitiminAktiflikDurumu = true,
                EgitimBaslangicTarihi = new DateTime(2025, 10, 10),
                Aciklama = "Bu Kurs Sonunda Junior Bir Full Stack Developer Olacaksiniz.",
                EgitimSuresiAy = 6,
                EgitiminIcerigi = "C#/ HTML / CSS / BOOTSTRAP/ JAVASCRİPT / ASP.NETCORE MVC/ASP.NETCORE API /REACT ",
                EgitiminDegerlendirilmesi = "Bu Egitim Yazilima Yeni Başlayacak Olan Kişiler icindir.",
                EgitiminYeri = "Kuloğlu Mh., Barbaros Blv. Yıldız İş Hanı No:9, 34353 Beşiktaş/İstanbul",
                EgitiminKazanimlari = "Bu egitim Sonunda Front-End Teklonojisini BackEnd Teklonojisini Ve Mobil Teklonojisini Ögrenmiş Olacaksiniz.Ögrendiginiz Programlar ile" +
                "Bir Site ve Mobil Uygulama'nin Tüm Adimlarinda Yer Alabilirsiniz.",
                EgitimPlanlananBitisTarihi = new DateTime(2026, 04, 10),
                EgitimToplamDersSaati = 600,
                EgitiminStatusu = "SoftwareDeveloper",
                EgitiminSeviyesi = "Kolay",
                CategoryId = 1,
            },
            new Course
            {
                Id = 2,
                EgitimAdi = "Siber Güvenlik Uzmani Yetistirme Kursu",
                EgitiminAktiflikDurumu = true,
                EgitimBaslangicTarihi = new DateTime(2025, 01, 01),
                Aciklama = "Bu Kurs Ortalama Yazilim bilen Siber Güvenlige ilgisi olan kisiler için tasarlanmistir.",
                EgitimSuresiAy = 6,
                EgitiminIcerigi = "Aircrack-ng,BeEF,Burp Suite Scanner,Cain and Abel,Fern Wifi Cracker",
                EgitiminDegerlendirilmesi = "Bu Egitim Yazilimi Orta Seviye Bilen Kişiler İçindir.",
                EgitiminYeri = "Kuloğlu Mh., Barbaros Blv. Yıldız İş Hanı No:9, 34353 Beşiktaş/İstanbul",
                EgitiminKazanimlari = "Bu kurstan Sonra Siber Güvenlik Elemani veya Siber Güvenlik Uzmani olarak işe başlayabilirsiniz.",
                EgitimPlanlananBitisTarihi = new DateTime(2025, 07, 01),
                EgitimToplamDersSaati = 600,
                EgitiminStatusu = "Siber Security",
                EgitiminSeviyesi = "Orta",
                CategoryId = 5
            },
            new Course
            {
                Id = 3,
                EgitimAdi = "BackEnd Geliştirme Kursu",
                EgitiminAktiflikDurumu = true,
                EgitimBaslangicTarihi = new DateTime(2025, 01, 01),
                Aciklama = "Bu Kurs Yazilim Uzmanlari İçin Kendilerine Artı Katacaktır.",
                EgitimSuresiAy = 6,
                EgitiminIcerigi = "C#,C++,JAVA,NODEJS,Asp.NetCore Web Api, Asp.NETCore MVC",
                EgitiminDegerlendirilmesi = "Bu Egitim Yazilimi Senior Seviye Yazilima Hakim Kişiler İçindir.",
                EgitiminYeri = "Kuloğlu Mh., Barbaros Blv. Yıldız İş Hanı No:9, 34353 Beşiktaş/İstanbul",
                EgitiminKazanimlari = "Bu kurstan Sonra BackEnd Yazilim Uzmani olarak işe başlayabilirsiniz.",
                EgitimPlanlananBitisTarihi = new DateTime(2025, 07, 01),
                EgitimToplamDersSaati = 600,
                EgitiminStatusu = "BackEndDevelopment",
                EgitiminSeviyesi = "Zor",
                CategoryId = 3,
            },
            new Course
            {
                Id = 4,
                EgitimAdi = "FrontEndDeveloper Yetistirme Kursu",
                EgitiminAktiflikDurumu = true,
                EgitimBaslangicTarihi = new DateTime(2025, 01, 01),
                Aciklama = "Bu Kurs Yazilima Başlayacak ve Yazilima İlgisi olan kisiler için tasarlanmistir. FrontEnd Tasarimlari Yapmaniz İçin Ögrenmeniz Gereken Programlari İçerir.",
                EgitimSuresiAy = 6,
                EgitiminIcerigi = "JavaScript,Html,css,Bootstrap",
                EgitiminDegerlendirilmesi = "Bu Egitim Yazilima Yeni Başlayan Kişiler İçindir..",
                EgitiminYeri = "Kuloğlu Mh., Barbaros Blv. Yıldız İş Hanı No:9, 34353 Beşiktaş/İstanbul",
                EgitiminKazanimlari = "Bu kurstan Sonra Herhangi Bir Web Uygulamasina Front End Tasarimlarini Uygulama Yetenegi Kazanacaksiniz. ",
                EgitimPlanlananBitisTarihi = new DateTime(2025, 07, 01),
                EgitimToplamDersSaati = 600,
                EgitiminStatusu = "FrontEnd",
                EgitiminSeviyesi = "Orta",
                CategoryId=2,
            },
            new Course
            {
                Id = 5,
                EgitimAdi = "Mobile Developer Yetistirme Kursu",
                EgitiminAktiflikDurumu = true,
                EgitimBaslangicTarihi = new DateTime(2025, 01, 01),
                Aciklama = "Bu Kurs Yazilima Yeni Başlayacak  Ve Mobil Development'a ilgili kisiler için tasarlanmistir.",
                EgitimSuresiAy = 6,
                EgitiminIcerigi = "React ,Ajax ,NodeJs,TypeScript,Javascript,Html,Css,Flutter",
                EgitiminDegerlendirilmesi = "Bu Egitim Yazilima Yeni Başlayacak Kişiler İçindir.",
                EgitiminYeri = "Kuloğlu Mh., Barbaros Blv. Yıldız İş Hanı No:9, 34353 Beşiktaş/İstanbul",
                EgitiminKazanimlari = "Bu kurstan Sonra Mobile Developer Olarak İşe Başlayabilirsiniz.Ögrendiginiz Programlar ile Mobil Uygulamalar Tasarlayabilirsiniz.",
                EgitimPlanlananBitisTarihi = new DateTime(2025, 07, 01),
                EgitimToplamDersSaati = 600,
                EgitiminStatusu = "Mobile Development",
                EgitiminSeviyesi = "Kolay",
                CategoryId = 4,
            }
            );
        }
    }
}
