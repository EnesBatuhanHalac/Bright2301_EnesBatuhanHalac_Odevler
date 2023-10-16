using BrightApp.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrightApp.Entity.DataTransferObjects
{
    public record CourseDtoForUpdate
    {
        public string EgitimAdi { get; init; }
        public int EgitimToplamDersSaati { get; init; }
        public int EgitimSuresiAy { get; init; }
        public DateTime EgitimBaslangicTarihi { get; init; }
        public DateTime EgitimPlanlananBitisTarihi { get; init; }
        public string Aciklama { get; init; }
        public string EgitiminSeviyesi { get; init; }
        public string EgitiminKazanimlari { get; init; }
        public string EgitiminYeri { get; init; }
        public string EgitiminIcerigi { get; init; }
        public string EgitiminDegerlendirilmesi { get; init; }
        public string EgitiminStatusu { get; init; }
        public bool EgitiminAktiflikDurumu { get; init; }
        public Category Category { get; init; }
        public int CategoryId { get; init; }
        public List<Trainee> Trainees { get; init; }
    }
}
