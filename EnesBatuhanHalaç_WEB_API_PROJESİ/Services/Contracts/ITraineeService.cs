using BrightApp.Entity.Concrete;
using BrightApp.Entity.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Contracts
{
    public interface ITraineeService
    {
        IEnumerable<Trainee> GetAllTrainee(bool trackchanges);
        Trainee GetTrainee(int id,bool trackchanges);
        void UpdateTrainee(int id,TraineeDtoForUpdate TraineeDto,bool trackchanges);
        Trainee CreateTrainee(Trainee trainee);
        void DeleteTrainee(int id,bool trackchanges);

    }
}
