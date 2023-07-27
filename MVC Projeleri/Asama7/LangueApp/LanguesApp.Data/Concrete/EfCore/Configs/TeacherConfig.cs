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
          

            builder.HasData(new Teacher
            {
                Id =1,
                FullName="Ecem Ünal",
                Age=28,
                About="Merhabalar Ben Ecem Ünal Bogaz İçi Üniversitesi İngilizce Bölümü mezunuyum 1 yıldır İngilizce Ögretmeniyim.",
                Url="ilk Ogretmen",
                ImageUrl="kadin1.jpg",
                Price=220,
                CreatedBy="Admin",
                CreatedDate=DateTime.Now,
                IsDeleted=false,
                IsActive=true,
                Country="Turkey",
                Email="Ecemunal@gmail.com",
                Phone="+905426742261"

            },

            new Teacher
            {
                Id=2,
                FullName = "Hannibal Lecter ",
                Age = 28,
                About = "Hi I am Hannibal Lecter. I am 33 years old.I have Experience 5 years be Germany teacher.And I am teaching russian langue",
                Url = "ikinci Ogretmen",
                ImageUrl = "Erkek1.jpg",
                Price = 300,
                CreatedBy = "Admin",
                CreatedDate = DateTime.Now,
                IsDeleted = false,
                IsActive = true,
                Country = "North America",
                 Email = "HannibalLecter@gmail.com",
                Phone = "+756425271963"
            },

            new Teacher
            {
                Id=3,
                FullName = "Ragnar Lotbrook",
                Age = 38,
                About = "Hi I am Ragnar Lotbrook. I am 38 years old.I have Experience 10 years be Russian teacher and I have experiance english ",
                Url = "Ucuncu Ogretmen",
                ImageUrl = "Erkek2.jpg",
                Price = 350,
                CreatedBy = "Admin",
                CreatedDate = DateTime.Now,
                IsDeleted = false,
                Country="Kremlin",
                IsActive = true,
                Email = "RagnarLotbrook@gmail.com",
                Phone = "+709624789231"

            },
            new Teacher
            {
                Id = 4,
                FullName = "Yagmur Su",
                Age = 35,
                About = "Merhaba Ben Yagmur su 35 yaşındayim 8 yıldır Sümer Dili Ve edebiyati Ögretmenligi yapiyorum ayni zamanda Fransizca ögretmenligi yapiyorum.",
                Country="Turkey",
                Url = "Dorduncu Ogretmen",
                ImageUrl = "kadin2.jpg",
                Price = 280,
                CreatedBy = "Admin",
                CreatedDate = DateTime.Now,
                IsDeleted = false,
                IsActive = true,
                Email = "SuYagmur@gmail.com",
                Phone = "+905346712263"

            },
            new Teacher
            {
                Id=5,
                FullName = "Umit Ozdag",
                Age = 42,
                About = "Merhaba Ben Ümit Ozdag 8 yıldır Arap Dili Ve Edebiyati Ögretmenligi Yapiyorum Suan Zafer Dersanesinde Arapça Ogretmeniyim.Ve Türk Dili ve Edebiyati Dersi veriyorum.",
                Country="Suriye",
                Url = "Besinci Ogretmen",
                ImageUrl = "Erkek3.jpg",
                Price = 320,
                CreatedBy = "Admin",
                CreatedDate = DateTime.Now,
                IsDeleted = false,
                IsActive = true,
                Email = "OzdagUmit3425@gmail.com",
                Phone = "+905425346734"

            },
            new Teacher
            {
                Id = 6,
                FullName = "Atilla Kurt",
                Age = 34,
                About = "Merhaba Bendeniz Atilla Kurt Yasım 34 ve 6 yıldır Türk Dili Ve Edebiyatı Ögretmeniyim. 3 yıllık İtalyanca Tecrübem var ",
                Country="Turkiye",
                Url = "Altıncı Ogretmen",
                ImageUrl = "Erkek4.jpg",
                Price = 200,
                CreatedBy = "Admin",
                CreatedDate = DateTime.Now,
                IsDeleted = false,
                IsActive = true,
                Email = "KurAtilla@gmail.com",
                Phone = "+902221369523"

            },
            new Teacher
            {
                Id = 7,
                FullName = "DenemeTeacher ingilizce",
                Age = 42,
                About = "Deneme ",
                Country = "Turkiye",
                Url = "deneme Ogretmen",
                ImageUrl = "Erkek5.jpg",
                Price = 2080,
                CreatedBy = "Admin",
                CreatedDate = DateTime.Now,
                IsDeleted = false,
                IsActive = false,
                Email = "Deneme3425@gmail.com",
                Phone = "+904563219874"

            }


            );;
        }
       
    }
}
