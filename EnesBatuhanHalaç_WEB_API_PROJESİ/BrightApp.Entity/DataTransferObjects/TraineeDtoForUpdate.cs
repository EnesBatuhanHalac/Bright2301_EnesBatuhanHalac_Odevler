using BrightApp.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrightApp.Entity.DataTransferObjects
{
    public record TraineeDtoForUpdate
    {
        public string KursiyerAdi { get; init; }
        public string KursiyerSoyAdi { get; init; }
        public string KursiyerEgitimDurumu { get; init; }
        public Trainer Trainer { get; init; }
        public int TrainerId { get; init; }
        public Course Course { get; init; }
        public int CourseId { get; init; }
    }
}
