using BrightApp.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrightApp.Entity.Concrete
{
    public class Trainee:BaseEntity
    {
        public string KursiyerAdi { get; set; }
        public string KursiyerSoyAdi { get; set; }
        public string KursiyerEgitimDurumu { get; set; }
        public Trainer Trainer { get; set; }
        public int TrainerId { get; set; }
        public Course Course { get; set; }
        public int CourseId { get; set; }
    }
}
