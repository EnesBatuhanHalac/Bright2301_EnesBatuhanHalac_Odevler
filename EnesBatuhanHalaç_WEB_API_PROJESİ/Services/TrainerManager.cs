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
    public class TrainerManager : ITrainerService
    {
        private readonly IRepositoryManager _manager;
        private readonly ILoggerService _logger;
        private readonly IMapper _mapper;

        public TrainerManager(IRepositoryManager manager, ILoggerService logger, IMapper mapper)
        {
            _manager = manager;
            _logger = logger;
            _mapper = mapper;
        }

        public Trainer CreateOneTrainer(Trainer trainer)
        {
            _manager.Trainer.Create(trainer);
            _manager.save();
            return trainer;
        }

        public void DeleteOneTrainer(int id, bool trackchanges)
        {
            var trainer = _manager.Trainer.GetOneTrainer(id, trackchanges);

            if (trainer == null)
                throw new TrainerNotFoundException(id);

            _manager.Trainer.DeleteTrainer(trainer);
            _manager.save();
        }

        public IEnumerable<Trainer> GetAllTrainer(bool trackchanges)
        {
            return _manager.Trainer.GetAllTrainer(trackchanges);
        }

        public Trainer GetOneTrainer(int id, bool trackchanges)
        {
            var trainer= _manager.Trainer.GetOneTrainer(id,trackchanges);
            if (trainer == null)
                throw new TrainerNotFoundException(id);
            return trainer;
        }

        public void UpdateOneTrainer(int id, TrainerDtoForUpdate trainerDto, bool trackChanges)
        {
            var entity = _manager.Trainer.GetOneTrainer(id, trackChanges);

            if (trainerDto is null)
                throw new TrainerNotFoundException(id);

            //entity.CourseId=trainerDto.CourseId;
            //entity.EgitmenDegerlendirmesiPuan = trainerDto.EgitmenDegerlendirmesiPuan;
            //entity.EgitmenDegerlendirmesiYorum = trainerDto.EgitmenDegerlendirmesiYorum;
            //entity.EgitmenAdi=trainerDto.EgitmenAdi;
            //entity.EgitmenDeneyim = trainerDto.EgitmenDeneyim;
            //entity.EgitmenEgitimBilgileri = trainerDto.EgitmenEgitimBilgileri;
            //entity.EgitmeninAktiflikDurumu = trainerDto.EgitmeninAktiflikDurumu;
            //entity.EgitmenSoyAdi = trainerDto.EgitmenSoyAdi;
            //entity.EgitmenUzmanlikAlani = trainerDto.EgitmenUzmanlikAlani;

            entity = _mapper.Map<Trainer>(trainerDto);
            _manager.Trainer.UpdateTrainer(entity);
            _manager.save();
        }
    }
}
