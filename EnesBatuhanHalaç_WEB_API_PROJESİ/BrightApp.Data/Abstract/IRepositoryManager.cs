using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrightApp.Data.Abstract
{
    public interface IRepositoryManager
    {
        ICategoryRepository Category { get; }
        ITraineeRepository  Trainee { get; }
        ICourseRepository Course { get; }
        ITrainerRepository Trainer { get; }
        void save();
    }
}
