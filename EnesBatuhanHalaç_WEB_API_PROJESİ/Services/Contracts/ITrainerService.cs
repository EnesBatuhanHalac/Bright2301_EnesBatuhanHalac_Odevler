using BrightApp.Entity.Concrete;
using BrightApp.Entity.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Contracts
{
    public interface ITrainerService
    {
        IEnumerable<Trainer> GetAllTrainer(bool trackchanges);
        Trainer GetOneTrainer(int id, bool trackchanges);
        Trainer CreateOneTrainer(Trainer trainer);
        void DeleteOneTrainer(int id,bool trackchanges);
        void UpdateOneTrainer(int id, TrainerDtoForUpdate trainerDto,bool trackChanges);
    }
}
