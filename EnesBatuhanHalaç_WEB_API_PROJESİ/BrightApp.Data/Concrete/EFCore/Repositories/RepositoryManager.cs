using BrightApp.Data.Abstract;
using BrightApp.Data.Concrete.EFCore.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrightApp.Data.Concrete.EFCore.Repositories
{
    public class RepositoryManager : IRepositoryManager
    {
        private readonly BrightAcademieContext _context;
        private readonly Lazy<ICategoryRepository> _categoryRepository;
        private readonly Lazy<ITraineeRepository> _traineeRepository;
        private readonly Lazy<ITrainerRepository> _trainerRepository;
        private readonly Lazy<ICourseRepository> _CourseRepository;

        public RepositoryManager(BrightAcademieContext context)
        {
            _context = context;
            _traineeRepository = new Lazy<ITraineeRepository>(() => new TraineeRepository(_context));
            _categoryRepository = new Lazy<ICategoryRepository>(() => new CategoryRepository(_context));
            _trainerRepository = new Lazy<ITrainerRepository>(() => new TrainerRepository(_context));
            _CourseRepository = new Lazy<ICourseRepository>(() => new CourseRepository(_context));
        }

        public ICategoryRepository Category => _categoryRepository.Value;

        public ITraineeRepository Trainee => _traineeRepository.Value;

        public ICourseRepository Course => _CourseRepository.Value;

        public ITrainerRepository Trainer => _trainerRepository.Value;

        public void save()
        {
            _context.SaveChanges();
        }
    }
}
