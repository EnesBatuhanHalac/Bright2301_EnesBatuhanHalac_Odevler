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
    public class TrainerConfig : IEntityTypeConfiguration<Trainer>
    {
        public void Configure(EntityTypeBuilder<Trainer> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.EgitmenDegerlendirmesiPuan).IsRequired();
            builder.Property(x => x.CourseId).IsRequired();
            builder.Property(x => x.EgitmenAdi).IsRequired();
            builder.Property(x => x.EgitmenDegerlendirmesiYorum).IsRequired();
            builder.Property(x => x.EgitmenDeneyim).IsRequired();
            builder.Property(x => x.EgitmenEgitimBilgileri).IsRequired();
            builder.Property(x => x.EgitmeninAktiflikDurumu).IsRequired();
            builder.Property(x => x.EgitmenSoyAdi).IsRequired();
            builder.Property(x => x.EgitmenUzmanlikAlani).IsRequired();
            builder.Property(x => x.EgitmenDeneyim).IsRequired();

            builder.HasData(new Trainer
            {
                Id = 3,
                EgitmenAdi = "EnginNiyazi",
                EgitmenSoyAdi = "Ergül",
                EgitmenDegerlendirmesiPuan = 8,
                EgitmenDegerlendirmesiYorum = "",
                EgitmenDeneyim = "Deneyimli",
                EgitmenEgitimBilgileri = "İstanbul Üniversitesi Bilgisayar Mühendisligi ",
                EgitmeninAktiflikDurumu = true,
                EgitmenUzmanlikAlani = "BackEnd Development",
                CourseId=3

            },
            new Trainer
            {
                Id = 1,
                EgitmenAdi = "Enes",
                EgitmenSoyAdi = "Uzun",
                EgitmenDegerlendirmesiPuan = 9,
                EgitmenDegerlendirmesiYorum = "",
                EgitmenDeneyim = "Deneyimli",
                EgitmenEgitimBilgileri = "ODTÜ Bilgisayar Mühendisligi ve Kodlama Egitimi,MIT California Yapayzeka ",
                EgitmeninAktiflikDurumu = true,
                EgitmenUzmanlikAlani = "FullStack Development",
                CourseId=1

            },
            new Trainer
            {
                Id = 2,
                EgitmenAdi = "Ali can",
                EgitmenSoyAdi = "Gören",
                EgitmenDegerlendirmesiPuan = 7,
                EgitmenDegerlendirmesiYorum = "",
                EgitmenDeneyim = "Deneyimsiz",
                EgitmenEgitimBilgileri = "İstanbul Üniversitesi Bilgisayar Mühendisligi ",
                EgitmeninAktiflikDurumu = true,
                EgitmenUzmanlikAlani = "FrontEnd Development",
                CourseId=2

            },
            new Trainer
            {
                Id = 4,
                EgitmenAdi = "Asli",
                EgitmenSoyAdi = "Mizrak",
                EgitmenDegerlendirmesiPuan = 8,
                EgitmenDegerlendirmesiYorum = "",
                EgitmenDeneyim = "Deneyimli",
                EgitmenEgitimBilgileri = "İstanbul Üniversitesi Bilgisayar Mühendisligi ",
                EgitmeninAktiflikDurumu = true,
                EgitmenUzmanlikAlani = "Mobile Development",
                CourseId = 4

            },
            new Trainer
            {
                Id = 5,
                EgitmenAdi = "Ecem",
                EgitmenSoyAdi = "Gül",
                EgitmenDegerlendirmesiPuan = 5,
                EgitmenDegerlendirmesiYorum = "",
                EgitmenDeneyim = "Deneyimli",
                EgitmenEgitimBilgileri = "İstanbul Üniversitesi Bilgisayar Mühendisligi ",
                EgitmeninAktiflikDurumu = true,
                EgitmenUzmanlikAlani = "SiberSecurityDevelopment",
                CourseId=5
            }

            );


        }
    }
}
