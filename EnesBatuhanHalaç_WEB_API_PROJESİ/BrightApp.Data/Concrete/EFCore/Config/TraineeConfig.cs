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
    public class TraineeConfig : IEntityTypeConfiguration<Trainee>
    {
        public void Configure(EntityTypeBuilder<Trainee> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.KursiyerAdi).IsRequired();
            builder.Property(x => x.KursiyerSoyAdi).IsRequired();
            builder.Property(x => x.KursiyerEgitimDurumu).IsRequired();

            builder.HasData(new Trainee
            {
                Id = 1,
                KursiyerAdi = "Mucahit",
                KursiyerSoyAdi = "Çetin",
                KursiyerEgitimDurumu = "Lise",
                CourseId = 1,
                TrainerId = 1,
            },
            new Trainee
            {
                Id = 2,
                KursiyerAdi = "Emine",
                KursiyerSoyAdi = "Uzun",
                KursiyerEgitimDurumu = "Üniversite",
                CourseId = 1,
                TrainerId = 1,
            },
            new Trainee
            {
                Id = 3,
                KursiyerAdi = "Sinan",
                KursiyerEgitimDurumu = "Yükseklisans",
                KursiyerSoyAdi = "ÇetinALP",
                CourseId = 1,
                TrainerId = 1,
            },
            new Trainee
            {
                Id = 4,
                KursiyerAdi = "Emine",
                KursiyerSoyAdi = "Uzun",
                KursiyerEgitimDurumu = "Üniversite",
                CourseId = 2,
                TrainerId = 2
            },
            new Trainee
            {
                Id = 5,
                KursiyerAdi = "Mehmet",
                KursiyerSoyAdi = "Uzun",
                KursiyerEgitimDurumu = "Önlisans",
                CourseId = 2,
                TrainerId = 2
            },
            new Trainee
            {
                Id = 6,
                KursiyerAdi = "Ali",
                KursiyerSoyAdi = "Yerli",
                KursiyerEgitimDurumu = "Önlisans",
                CourseId = 2,
                TrainerId = 2
            },
             new Trainee
             {
                 Id = 7,
                 KursiyerAdi = "Ahmet",
                 KursiyerSoyAdi = "Uzun",
                 KursiyerEgitimDurumu = "Üniversite",
                 CourseId = 3,
                 TrainerId = 3
             },
            new Trainee
            {
                Id = 8,
                KursiyerAdi = "Hasan",
                KursiyerSoyAdi = "Uzun",
                KursiyerEgitimDurumu = "Önlisans",
                CourseId = 3,
                TrainerId = 3
            },
            new Trainee
            {
                Id = 9,
                KursiyerAdi = "Ömür",
                KursiyerSoyAdi = "Yerli",
                KursiyerEgitimDurumu = "Önlisans",
                CourseId = 3,
                TrainerId = 3
            },
             new Trainee
             {
                 Id = 10,
                 KursiyerAdi = "Enes",
                 KursiyerSoyAdi = "Yerli",
                 KursiyerEgitimDurumu = "Üniversite",
                 CourseId = 4,
                 TrainerId = 4
             },
            new Trainee
            {
                Id = 11,
                KursiyerAdi = "Mehmet",
                KursiyerSoyAdi = "Yerli",
                KursiyerEgitimDurumu = "Önlisans",
                CourseId = 4,
                TrainerId = 4
            },
            new Trainee
            {
                Id = 12,
                KursiyerAdi = "Ahmet",
                KursiyerSoyAdi = "Yerli",
                KursiyerEgitimDurumu = "Önlisans",
                CourseId = 4,
                TrainerId = 4
            },
             new Trainee
             {
                 Id = 13,
                 KursiyerAdi = "Emine",
                 KursiyerSoyAdi = "Kısa",
                 KursiyerEgitimDurumu = "Üniversite",
                 CourseId = 5,
                 TrainerId = 5
             },
            new Trainee
            {
                Id = 14,
                KursiyerAdi = "Mehmet",
                KursiyerSoyAdi = "Kısa",
                KursiyerEgitimDurumu = "Önlisans",
                CourseId = 5,
                TrainerId = 5
            },
            new Trainee
            {
                Id = 15,
                KursiyerAdi = "Ali",
                KursiyerSoyAdi = "Keskin",
                KursiyerEgitimDurumu = "Önlisans",
                CourseId = 5,
                TrainerId = 5
            }            
            );
        }
    }
}
