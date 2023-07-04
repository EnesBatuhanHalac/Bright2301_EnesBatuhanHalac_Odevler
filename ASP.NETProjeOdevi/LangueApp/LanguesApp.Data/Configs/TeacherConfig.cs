using LanguesApp.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguesApp.Data.Configs
{
    public class TeacherConfig : IEntityTypeConfiguration<Teacher>
    {
        public void Configure(EntityTypeBuilder<Teacher> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x=> x.About).HasMaxLength(250);
            // public string FullName { get; set; }
            //public int Age { get; set; }
            //public string About { get; set; }
            //public List<LangueTeacher> LangueTeachers { get; set; }
            //public Image Image { get; set; }
            //public int ImageId { get; set; }
            //public string? Url { get; set; }
            //public string ImageUrl { get; set; }
            //public decimal Price { get; set; }

            builder.HasData(new Teacher
            {
                Id =1,
                FullName="Ecem Ünal",
                Age=28,
                About="Merhabalar Ben Ecem Ünal Bogaz İçi Üniversitesi İngilizce Bölümü mezunuyum 1 yıldır İngilizce Ögretmeniyim.",
                Url="ilk Ogretmen",
                ImageUrl="ilk Ogermen ImageUrl",
                Price=220,
                CreatedBy="Admin",
                CreatedDate=DateTime.Now,
                IsDeleted=false,
                Country="Turkey",

            },

            new Teacher
            {
                Id=2,
                FullName = "Hannibal Lecter ",
                Age = 28,
                About = "Hi I am Hannibal Lecter. I am 33 years old.I have Experience 5 years be Germany teacher.And I am teaching russian langue",
                Url = "ikinci Ogretmen",
                ImageUrl = "ikinci Ogretmen ImageUrl",
                Price = 300,
                CreatedBy = "Admin",
                CreatedDate = DateTime.Now,
                IsDeleted = false,
                Country="North America"
            },

            new Teacher
            {
                Id=3,
                FullName = "Ragnar Lotbrook",
                Age = 38,
                About = "Hi I am Ragnar Lotbrook. I am 38 years old.I have Experience 10 years be Russian teacher and I have experiance english ",

                Url = "Ucuncu Ogretmen",
                ImageUrl = "Ucuncu Ogretmen ImageUrl",
                Price = 350,
                CreatedBy = "Admin",
                CreatedDate = DateTime.Now,
                IsDeleted = false,
                Country="Kremlin"
            },
            new Teacher
            {
                Id = 4,
                FullName = "Yagmur Su",
                Age = 35,
                About = "Merhaba Ben Yagmur su 35 yaşındayim 8 yıldır Sümer Dili Ve edebiyati Ögretmenligi yapiyorum ayni zamanda Fransizca ögretmenligi yapiyorum.",
                Country="Turkey",
                Url = "Dorduncu Ogretmen",
                ImageUrl = "Dorduncu Ogretmen ImageUrl",
                Price = 280,
                CreatedBy = "Admin",
                CreatedDate = DateTime.Now,
                IsDeleted = false
            },
            new Teacher
            {
                Id=5,
                FullName = "Umit Ozdag",
                Age = 42,
                About = "Merhaba Ben Ümit Ozdag 8 yıldır Arap Dili Ve Edebiyati Ögretmenligi Yapiyorum Suan Zafer Dersanesinde Arapça Ogretmeniyim.Ve Türk Dili ve Edebiyati Dersi veriyorum.",
                Country="Suriye",
                Url = "Besinci Ogretmen",
                ImageUrl = "Besinci Ogretmen ImageUrl",
                Price = 320,
                CreatedBy = "Admin",
                CreatedDate = DateTime.Now,
                IsDeleted = false
            },
            new Teacher
            {
                Id = 6,
                FullName = "Atilla Kurt",
                Age = 34,
                About = "Merhaba Bendeniz Atilla Kurt Yasım 34 ve 6 yıldır Türk Dili Ve Edebiyatı Ögretmeniyim. 3 yıllık İtalyanca Tecrübem var ",
                Country="Turkiye",
                Url = "Altıncı Ogretmen",
                ImageUrl = "Altıncı Ogretmen ImageUrl",
                Price = 200,
                CreatedBy = "Admin",
                CreatedDate = DateTime.Now,
                IsDeleted = false
            }


            );;
        }
       
    }
}
