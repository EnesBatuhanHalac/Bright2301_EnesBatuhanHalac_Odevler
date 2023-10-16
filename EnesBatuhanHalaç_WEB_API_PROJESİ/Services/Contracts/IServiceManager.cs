using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Contracts
{
    public interface IServiceManager
    {
        ICategoryService CategoryService { get; }
        ICourseService CourseService { get; }
        ITraineeService TraineeService { get; }
        ITrainerService TrainerService { get; }

    }
}
