using BrightApp.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrightApp.Entity.DataTransferObjects
{
    public record TrainerDtoForUpdate
    {
        public string EgitmenAdi { get; init; }
        public string EgitmenSoyAdi { get; init; }
        public string EgitmenUzmanlikAlani { get; init; }
        public string EgitmenDeneyim { get; init; }
        public string EgitmenEgitimBilgileri { get; init; }
        public string EgitmenDegerlendirmesiYorum { get; init; }
        public int EgitmenDegerlendirmesiPuan { get; init; }
        public bool EgitmeninAktiflikDurumu { get; init; }
        public Course Course { get; init; }//one to one teke tek ilişki
        public int CourseId { get; init; }//one to one teke tek ilişki
        public List<Trainee> Trainees { get; init; }
    }
}
