using AutoMapper;
using BrightApp.Data.Abstract;
using BrightApp.Entity.Concrete;
using BrightApp.Entity.DataTransferObjects;
using BrightApp.Entity.Exceptions;
using Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class TraineeManager : ITraineeService
    {
        private readonly IRepositoryManager _manager;
        private readonly ILoggerService _logger;
        private readonly IMapper _mapper;

        public TraineeManager(IRepositoryManager manager, ILoggerService logger, IMapper mapper)
        {
            _manager = manager;
            _logger = logger;
            _mapper = mapper;
        }

        public Trainee CreateTrainee(Trainee trainee)
        {
           
            _manager.Trainee.Create(trainee);
            _manager.save();
            return trainee;
        }

        public void DeleteTrainee(int id, bool trackchanges)
        {
            var trainee = _manager.Trainee.GetOneTrainee(id, trackchanges);

            if (trainee is null)
                throw new TraineeNotFoundException(id); 

            _manager.Trainee.DeleteTrainee(trainee);
            _manager.save();
        }

        public IEnumerable<Trainee> GetAllTrainee(bool trackchanges)
        {
          return _manager.Trainee.GetAllTrainee(trackchanges);
        }

        public Trainee GetTrainee(int id, bool trackchanges)
        {
            var trainee= _manager.Trainee.GetOneTrainee(id, trackchanges);
            if (trainee == null)
                throw new TraineeNotFoundException(id);

            return trainee;
        }

        public void UpdateTrainee(int id, TraineeDtoForUpdate TraineeDto, bool trackchanges)
        {
            var entity = _manager.Trainee.GetOneTrainee(id, trackchanges);

            if (TraineeDto is null)
            throw new TraineeNotFoundException(id);

            //entity.CourseId = TraineeDto.CourseId;
            //entity.KursiyerEgitimDurumu = TraineeDto.KursiyerEgitimDurumu;
            //entity.KursiyerAdi = TraineeDto.KursiyerAdi;
            //entity.KursiyerSoyAdi=TraineeDto.KursiyerSoyAdi;
            //entity.TrainerId = TraineeDto.TrainerId;

            entity = _mapper.Map<Trainee>(TraineeDto);

            _manager.Trainee.UpdateTrainee(entity);
            _manager.save();
        }
    }
}
