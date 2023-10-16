using BrightApp.Data.Abstract;
using BrightApp.Data.Concrete.EFCore.Context;
using BrightApp.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrightApp.Data.Concrete.EFCore.Repositories
{
    public class TrainerRepository : RepositoryBase<Trainer>, ITrainerRepository
    {
        public TrainerRepository(BrightAcademieContext context) : base(context)
        {
        }

        public void CreateTrainer(Trainer Trainer)=>Create(Trainer);

        public void DeleteTrainer(Trainer Trainer)=>Delete(Trainer);

        public IQueryable<Trainer> GetAllTrainer(bool TrackChanges)=>FindAll(TrackChanges);

        public Trainer GetOneTrainer(int id, bool TrackChanges)
            => FindByCondition(x => x.Id.Equals(id), TrackChanges)
            .SingleOrDefault();

        public void UpdateTrainer(Trainer Trainer)=>Update(Trainer);
    }
}
