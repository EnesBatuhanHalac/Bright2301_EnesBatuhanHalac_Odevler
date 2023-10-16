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
    public class CourseManager : ICourseService
    {
        private readonly IRepositoryManager _manager;
        private readonly ILoggerService _logger;
        private readonly IMapper _mapper;

        public CourseManager(IRepositoryManager manager, ILoggerService logger, IMapper mapper)
        {
            _manager = manager;
            _logger = logger;
            _mapper = mapper;
        }

        public Course CreateOneCourse(Course course)
        {
            _manager.Course.CreateOneCourse(course);
            _manager.save();
            return course;
        }

        public void DeleteOneCourse(int id, bool trackchanges)
        {
            var entity = _manager.Course.GetOneCourse(id, trackchanges);
            if (entity is null)
           throw new CourseNotFoundException(id);

            _manager.Course.DeleteOneCourse(entity);
            _manager.save();

        }

        public IEnumerable<Course> GetAllCourse(bool trackchanges)
        {
           var Courses= _manager.Course.GetAllCourse(trackchanges);
            return Courses;
        }

        public Course GetOneCourse(int id, bool trackchanges)
        {
            var course = _manager.Course.GetOneCourse(id, trackchanges);
            if (course is null)
                throw new CourseNotFoundException(id);

            return course;
        }

        public void UpdateOneCourse(int id, CourseDtoForUpdate courseDto, bool trackchanges)
        {
            var entity=_manager.Course.GetOneCourse(id,trackchanges);
            if (entity is null)
           throw new CourseNotFoundException(id);

         

            //entity.EgitiminAktiflikDurumu = courseDto.EgitiminAktiflikDurumu;
            //entity.EgitiminStatusu = courseDto.EgitiminStatusu;
            //entity.EgitimSuresiAy = courseDto.EgitimSuresiAy;
            //entity.EgitiminSeviyesi = courseDto.EgitiminSeviyesi;
            //entity.EgitiminIcerigi = courseDto.EgitiminIcerigi;
            //entity.EgitiminYeri = courseDto.EgitiminYeri;
            //entity.Aciklama = courseDto.Aciklama;
            //entity.EgitiminKazanimlari = courseDto.EgitiminKazanimlari;
            //entity.EgitimAdi = courseDto.EgitimAdi;
            //entity.CategoryId = courseDto.CategoryId;
            //entity.EgitimBaslangicTarihi = courseDto.EgitimBaslangicTarihi;
            //entity.EgitiminDegerlendirilmesi = courseDto.EgitiminDegerlendirilmesi;
            //entity.EgitimPlanlananBitisTarihi = courseDto.EgitimPlanlananBitisTarihi;
            //entity.EgitimToplamDersSaati = courseDto.EgitimToplamDersSaati;

            entity=_mapper.Map<Course>(courseDto);


            _manager.Course.Update(entity);
            _manager.save();

        }
    }
}
