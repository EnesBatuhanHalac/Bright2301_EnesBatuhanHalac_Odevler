using BrightApp.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrightApp.Entity.Concrete
{
    public class Trainer:BaseEntity
    {
        public string EgitmenAdi { get; set; }
        public string EgitmenSoyAdi { get; set; }
        public string EgitmenUzmanlikAlani { get; set; }
        public string EgitmenDeneyim { get; set; }
        public string EgitmenEgitimBilgileri { get; set; }
        public string EgitmenDegerlendirmesiYorum { get; set; }
        public int EgitmenDegerlendirmesiPuan { get; set; }
        public bool EgitmeninAktiflikDurumu { get; set; }
        public Course Course { get; set; }//one to one teke tek ilişki
        public int CourseId { get; set; }//one to one teke tek ilişki
        public List<Trainee> Trainees { get; set; }

    }
}
