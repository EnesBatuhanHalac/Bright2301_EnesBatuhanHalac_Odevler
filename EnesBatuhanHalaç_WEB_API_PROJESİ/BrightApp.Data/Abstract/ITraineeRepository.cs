using BrightApp.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrightApp.Data.Abstract
{
    public interface ITraineeRepository:IRepositoryBase<Trainee>
    {
        IQueryable<Trainee> GetAllTrainee(bool TrackChanges);
        Trainee GetOneTrainee(int id,bool TrackChanges);
        void CreateTrainee(Trainee Trainee);
        void UpdateTrainee(Trainee Trainee);
        void DeleteTrainee(Trainee Trainee);
    }
}
