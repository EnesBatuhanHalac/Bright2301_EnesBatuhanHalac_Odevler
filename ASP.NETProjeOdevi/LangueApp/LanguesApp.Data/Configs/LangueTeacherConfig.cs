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
    internal class LangueTeacherConfig : IEntityTypeConfiguration<LangueTeacher>
    {
        public void Configure(EntityTypeBuilder<LangueTeacher> builder)
        {
            builder.HasKey(lt=> new {lt.TeacherId, lt.LangueId});
            builder.HasData(

                new LangueTeacher { TeacherId=1,LangueId=1},
                new LangueTeacher { TeacherId=2,LangueId=2},
                new LangueTeacher { TeacherId=2,LangueId=3},
                new LangueTeacher { TeacherId=3,LangueId=3},
                new LangueTeacher { TeacherId=3,LangueId=1},
                new LangueTeacher { TeacherId=4,LangueId=4},
                new LangueTeacher { TeacherId=4,LangueId=6},
                new LangueTeacher { TeacherId=5,LangueId=5},
                new LangueTeacher { TeacherId=5,LangueId=7},
                new LangueTeacher { TeacherId=6,LangueId=5},
                new LangueTeacher { TeacherId=6,LangueId=8}

                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                );
        }
    }
}
