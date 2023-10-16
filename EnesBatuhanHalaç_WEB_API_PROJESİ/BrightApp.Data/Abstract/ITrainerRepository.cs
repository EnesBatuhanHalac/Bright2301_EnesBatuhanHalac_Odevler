using BrightApp.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrightApp.Data.Abstract
{
    public interface ITrainerRepository:IRepositoryBase<Trainer>
    {
      IQueryable<Trainer> GetAllTrainer(bool TrackChanges);
      Trainer GetOneTrainer(int id,bool TrackChanges);
        void CreateTrainer(Trainer Trainer);
        void UpdateTrainer(Trainer Trainer);
        void DeleteTrainer(Trainer Trainer);

    }
}
