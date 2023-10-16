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
    public class CategoryConfig : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(x => x.Id);//primary Key
            builder.Property(x => x.KategoriAciklamasi).IsRequired();//Zorunlu
            builder.Property(x => x.KategorininAktiflikDurumu).IsRequired();
            builder.Property(x => x.KategoriAdi).IsRequired();
            builder.HasData(new Category
            {
                Id = 1,
                KategoriAdi = "Full Stack Development",
                KategoriAciklamasi = "FullStack Developer Yetkinlikleri Kazandirir",
                KategorininAktiflikDurumu = true
                
            },
            new Category
            {
                Id = 2,
                KategoriAdi = "FrontEnd Development",
                KategorininAktiflikDurumu = true,
                KategoriAciklamasi = "FrontEnd Developer Yetkinlikleri Kazandirir"

            },
            new Category
            {
                Id = 3,
                KategoriAdi = "BackEnd Development",
                KategoriAciklamasi = "BackEnd Development Yetkinlikleri Kazandirir.",
                KategorininAktiflikDurumu = true

            },
            new Category
            {
                Id = 4,
                KategoriAdi = "SiberGüvenlik",
                KategoriAciklamasi = "Siber Güvenlik Uzmani Yetistirme Kursu",
                KategorininAktiflikDurumu = true

            },
            new Category
            {
                Id = 5,
                KategoriAdi = "Mobile Development",
                KategoriAciklamasi = "Mobile Developer Yetistirme Kursu",
                KategorininAktiflikDurumu = true

            },
            new Category
            {
                Id=6,
                KategoriAdi="DevOps",
                KategoriAciklamasi="DevOps Bt Operations",
                KategorininAktiflikDurumu=true
            }

            );
        }
    }
}
