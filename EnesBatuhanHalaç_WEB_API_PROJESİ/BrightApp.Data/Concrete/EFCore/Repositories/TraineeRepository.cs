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
    public class TraineeRepository : RepositoryBase<Trainee>, ITraineeRepository
    {
        public TraineeRepository(BrightAcademieContext context) : base(context)
        {
        }

        public void CreateTrainee(Trainee Trainee) => Create(Trainee);

        public void DeleteTrainee(Trainee Trainee)=>Delete(Trainee);

        public IQueryable<Trainee> GetAllTrainee(bool TrackChanges) => FindAll(TrackChanges);

        public Trainee GetOneTrainee(int id, bool TrackChanges) =>
            FindByCondition(x => x.Id.Equals(id), TrackChanges)
            .SingleOrDefault();

        public void UpdateTrainee(Trainee Trainee) => Update(Trainee);
    }
}
