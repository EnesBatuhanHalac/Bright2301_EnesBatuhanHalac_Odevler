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
    public class SettingConfig : IEntityTypeConfiguration<Setting>
    {
        public void Configure(EntityTypeBuilder<Setting> builder)
        {
            builder.HasKey(x=> x.Id);
            builder.Property(x=> x.FirmaAdi).IsRequired();
            builder.Property(x=> x.FirmaAdresi).IsRequired();
            builder.Property(x=> x.SıkSorularSorular).IsRequired();
            builder.Property(x=> x.Hakkimizda).IsRequired();
            builder.Property(x=> x.IletisimBilgileri).IsRequired();

            builder.HasData(new Setting
            {
                Id = 1,
                FirmaAdi = "Bright Academy",
                FirmaAdresi = "Kuloğlu Mh., Barbaros Blv. Yıldız İş Hanı No:9, 34353 Beşiktaş/İstanbul",
                Hakkimizda = "Junior Yazilimci Yetistirmek adina belirli alanlarda kurslar veren bir Kurum",
                IletisimBilgileri = "Telefon:(0212) 381 50 00",
                SıkSorularSorular = "1-) Ne zaman Kuruldunuz? 2-)Kurs Bitiminde Ne olacak? 3-)Kurslarinizin İçerigi Nedir?"
            });
        }
    }
}
