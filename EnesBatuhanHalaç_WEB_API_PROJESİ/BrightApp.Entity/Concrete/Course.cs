using BrightApp.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrightApp.Entity.Concrete
{
    public class Course:BaseEntity
    {
        public string EgitimAdi { get; set; }
        public int EgitimToplamDersSaati { get; set; }
        public int EgitimSuresiAy { get; set; }
        public DateTime EgitimBaslangicTarihi { get; set; }
        public DateTime EgitimPlanlananBitisTarihi { get; set; }
        public string Aciklama { get; set; }
        public string EgitiminSeviyesi { get; set; }
        public string EgitiminKazanimlari { get; set; }
        public string EgitiminYeri { get; set; }
        public string EgitiminIcerigi { get; set; }
        public string EgitiminDegerlendirilmesi { get; set; }
        public string EgitiminStatusu { get; set; }
        public bool EgitiminAktiflikDurumu { get; set; }
        public Category Category { get; set; }
        public int CategoryId { get; set; }
        public List<Trainee> Trainees { get; set; }
    }
}
