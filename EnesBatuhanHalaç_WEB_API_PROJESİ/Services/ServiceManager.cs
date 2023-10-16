using AutoMapper;
using BrightApp.Data.Abstract;
using BrightApp.Data.Concrete.EFCore.Context;
using BrightApp.Data.Concrete.EFCore.Repositories;
using Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class ServiceManager : IServiceManager
    {
        private readonly Lazy<ICategoryService> _categoryService;
        private readonly Lazy<ICourseService> _courseService;
        private readonly Lazy<ITraineeService> _traineeService;
        private readonly Lazy<ITrainerService> _trainerService;
        private readonly ILoggerService _loggerService;

        public ServiceManager(IRepositoryManager _manager, ILoggerService loggerService,IMapper _mapper)
        {
            _categoryService = new Lazy<ICategoryService>(() => new CategoryManager(_manager,loggerService,_mapper));
            _courseService = new Lazy<ICourseService>(() => new CourseManager(_manager, loggerService, _mapper));
            _traineeService = new Lazy<ITraineeService>(() => new TraineeManager(_manager, loggerService, _mapper));
            _trainerService = new Lazy<ITrainerService>(() => new TrainerManager(_manager,loggerService,_mapper));
            _loggerService = loggerService;
        }




        public ICategoryService CategoryService => _categoryService.Value;

        public ICourseService CourseService => _courseService.Value;

        public ITraineeService TraineeService => _traineeService.Value;

        public ITrainerService TrainerService => _trainerService.Value;
    }
}
