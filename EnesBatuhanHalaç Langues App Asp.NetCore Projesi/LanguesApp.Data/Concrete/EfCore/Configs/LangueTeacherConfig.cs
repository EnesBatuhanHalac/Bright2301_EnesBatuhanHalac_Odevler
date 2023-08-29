using LanguesApp.Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguesApp.Data.Concrete.EfCore.Configs
{
    public class LangueTeacherConfig : IEntityTypeConfiguration<LangueTeacher>
    {
        public void Configure(EntityTypeBuilder<LangueTeacher> builder)
        {
            builder.HasKey(x => new { x.TeacherId, x.LangueId });

            builder.HasData(

                new LangueTeacher { TeacherId = 1, LangueId = 1 },
                new LangueTeacher { TeacherId = 2, LangueId = 2 },
                new LangueTeacher { TeacherId = 2, LangueId = 3 },
                new LangueTeacher { TeacherId = 3, LangueId = 3 },
                new LangueTeacher { TeacherId = 3, LangueId = 1 },
                new LangueTeacher { TeacherId = 4, LangueId = 4 },
                new LangueTeacher { TeacherId = 4, LangueId = 6 },
                new LangueTeacher { TeacherId = 5, LangueId = 5 },
                new LangueTeacher { TeacherId = 5, LangueId = 7 },
                new LangueTeacher { TeacherId = 6, LangueId = 5 },
                new LangueTeacher { TeacherId = 6, LangueId = 8 },
                new LangueTeacher { TeacherId = 7, LangueId = 1 }
                
          
           );
        }
    }
}
